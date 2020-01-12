# Event Stores

## ChronicleDB: A High-Performance Event Store (2019)

In _ACM Transactions on Database Systems, Vol. 44, No. 4, Article 13. Publication date: October 2019._; [Seideman et al.](ChronicalDb_EventStore.pdf) present ChronicleDB, a novel database system with a storage layout tailored for high write performance under fluctuating data rates and powerful indexing capabilities to support a variety of queries. In addition, ChronicleDB offers low-cost fault tolerance and instant recovery within milliseconds.

Event stores, sometimes called time series databases, are responsible for ingestions and querying across billions of data objects.  These objects are sequential instances within a series and require specialized technologies, instead of relying on generic relational stores, such as Postgres.  The scalability of these systems is critical, as the number of sensors added to e.g., industrial IoT systems continues to grow exponentially.  To meet these needs, companies are looking toward Casandra and HBase, though these systems come with additional complexity that can introduce significant OPX/CAPX.  Alternative append-only technologies have emerged to address these aspects in part, though many different products offer limited support for common exceptions like out of order events.

### How did they build a better solution

The major design principal is _the log is the database_, they avoid additional operations as it only introduces more I/O.  This approach removes buffering strategies and only for out-of-order do they need special behaviors.  As the data ingests into the log it traverses through a collection of event queues, workers, and disks -- to provide memory based FIFO queues and decouple producers.  There's one queue per `event stream`, where an event stream represents a sequential feed of data objects.

### How is the storage layed out

By default, the log is written and read in a sequential manner.  This requirement constrains the layout of log files to be relatively simple, and avoid random access as is common in generic relational stores.  Within the log is a sequence of blocks, with each block a fixed size and populated with pointer offsets to the individual records.  These pointers use a virtual address strategy that uses relative jump lengths to interview user data -- for performance purposes.
