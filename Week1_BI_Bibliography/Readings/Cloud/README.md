# Cloud Storage

## Data Storage Management in Cloud Environments: Taxonomy, Survey, and Future Directions (2017)

The authors [Mansouri, Y; Nadjaran, T; Buyya, R](DataStorage_CloudEnv_Taxonomy.pdf) discuss the impact of _Storage as a Service_ (StaaS) and how it influences design decisions of business intelligence systems.  They state that the speed of data growth doubles every two years, and has increased ten fold between 2013 to 2020 -- from 4.4 to 44 ZB.  This explosive growth needs solutions as they offer an infinite pool of highly reliable, scalable, and flexible pay-per-use economics.

### What types of data stores are common place

- Not Only SQL (NoSQL): High availability and scalability over consistency; think key-value
- Relational (SQL): ACID stores with consistency over scalability; think tables
- NewSQL: Combines aspects of ACID and NoSQL, typically through replicated partitioning schemes; think hierarchial

### What are application considerations

- Online Transaction Processing (OLTP) versus Online Analytic Processing (OLAP), optimize for row versus column access patterns
- Does the system need Geo-replicated data stores or only single cluster
- Data management costs, in terms of licensing, human effort, and latency
- Eventual consistency versus Always consistent, aspect of the CAP Theorm that is fungable

OLTP need to enforce an all-or-nothing model, that introduces complexities around locking of entities within the store.  OLAP is nearly all read-only operations and is much easier to implement as a lock-free system.  OLTP needs to handle updates occuring many times per second, versus OLAP will update daily or perhaps weekly.  Many NoSQL stores require third-party solutions (e.g. Hadoop) to provide aggregate operations or facilitate bulk operations.

### What are the layers of Intra-cloud systems

1. Hardware Layer - physical elements of the system
2. Storage Management - the replication and load balancing sub systems
3. Metadata Management - The catalog of logical names to storage model
4. Storage Overlay - the virtualization of pools to physical media
5. User interface - the API that exposes the system to consumers

These separation of duties reduces the complexity to build the cloud data store; improving:

- Performance
- Fault tolerance (2f+1 replica)
- Costs
- Elasticity and Load Balancing
- Multi-Tenant Traffic

It does however introduces challenges:

- Challenges with replication
- Vendor lock-in due to propietary implementations
- Transfer bottlenecks
- Unpredictable Performance
- Multi-Tenant Unfairness
- Increased attack surface

Inter-cloud systems attempts to address these challenges by using the most efficient tool at the lowest cost.  While this avoids vendor lock-in it introduces complexity around compatibility, network congestion/latencies, and impairs consistency models.

### What are the shapes of data models

- Structured, static schema for entities
- Semi-structured, static envelopes with application specific extensions (e.g. property bags)
- Unstructured, opaque byte streams such as audio and video files

### How is data abstraction implemented

- Block level, a page within a sequential collection is treated as atomic unit
- File level, a file within a directory is treated as atomic unit
- Database mode, an entity within a table or collection is treated as atomic unit

### What Access Models Exist

- Key-Value store, an opaque value is always addressed by the primary or composite key set
- Document store, indexes properties of the artifacts and hortizontally partitions (shards) the data
- Extensible Record store, column families are grouped with a loose association to rows that are accessed by primary key set
- Relational store, traditional table row based systems

### What replication strategies exist

- Model { State Machine or Deferred Update}, for deterministic state consistency
- Granularity, single or multi-row/shard
- Propagation, eager/synchronous or lazy/async
- Initiation, single, master, or quorum
- Placement, hash, closest, multi-get, or associated placement

### What are influences of recovery strategies

Erasure Coding (e.g., parity bits) allow for storage RAID systems to efficiently recover faster while using less storage. There are some considerations around other performance metrics such as _cost to recover, time to recover, and reliability at recovery time_.

Some systems will combine replication and erasure strategies to  provide `Hybrid Recovery Schemes` that optimize for specific scenarios, that maybe more common place for the workload. For instance RAID5 spans 3 drives and uses 1/3rd of each for a partity bit; so no data loss after 1 disk failure.  RAID10 uses 6 drives to mirror RAID5 drives; so no data loss after 2-4 disk failures.

### What are consistency levels

- I/O level, a low-level enforcement at the transport
- Application level, pushes coordination responsibility to the developer
- Object-level, convergence across Conflict-free Replicated Data Tpes (CRDT) happens transaprently
- Flow-level, extension of object-level using a model to define semantic dependencies
- Language-level (CALM), semantic and depdencies of the app maintains a long history of invariants to avoid distributed coordination across replicas

#### What is Consistency as Logical Montonicity (CALM)

According to [bloom-lang](http://bloom-lang.net/calm/)([Cached](calm.pdf)) a monotonic distributed code does not require coordination protocols, if the results are additive to the output.  Only non-monotonic operations need to be protected and syncrhonized.

For example store contains a list of students in a class, students be added without a lot of overhead (just broadcast to all replicas).  However removing that same student requires locking overhead and additional complexities.

### How is eventual consistency implemented

1. Passive: Operation submitted to the closest replica is lazy propiagated
2. Active: Gossip Protocol, an exchange of metadata between replicas as events are processed

These notifications can lead to conflicts:

- Conflict detection, semantic checks based on logical/physical clocks
- Conflict prohibition, blocking or aborted I/O based on entity locks
- Conflict ignorance, e.g., last write wins or pre-defined procedure (entity merge)
- Conflict free Replicated Data Types, logically ordered and properties that can arrive out of order

Alternatively the updates can be modeled as:

- happens-before relationships, build trees of changes that need to be applied in dependent order
- ordering_consistency, based on sequentially counting series
- adaptive-level consistency, use a combination of strategies for a hybrid approach that is optimized for a workload

### How are transactions implemented

- ACID transactional stores use a stacked layer consisting of transaction and replication layers.
- Concurrency control mechanism performs isolation and atomic commitment protocol
  - Pessimistic Control: Lock-based
  - Optimistic: Best effort with abortion
- Commitment Protocols: 2-phase commit, voting, paxos, etc.
- Transactional Granularity is classified as single or multi-shard commit
- Multiple types of transaction isolation exist (serializable, update only, read-dirty, etc.)

Distributed Transaction Protocol manages the concurrency control via write-ahead logging.

1. The log is divided into log positions
2. Different partitions will write to different segments and then use a replication protocol, such as Paxos
3. Transaction Protocol provides sequential writes to each chunk that is later replicated

Contemporary Solutions instead use:

1. Dependency-tracking techniques is paired with linear transactions protocol. Transactions are locally committed on the server, and reordered after the fact instead of aborted or blocked.
2. Transaction decomposition creates chains of semantical updates and based on application requirements, eventually commits them via Homeostatis protocol allowing for more flexibility ordering.
3. Follow logical properties to minimize coordination across transactions; e.g. reordering that are equivalent, monotonic