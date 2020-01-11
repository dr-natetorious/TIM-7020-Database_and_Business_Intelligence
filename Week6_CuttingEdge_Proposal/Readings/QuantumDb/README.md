# Quantum Databases

The [video note section](../../Videos) contains my small crash-course on how quantum algorithms work, and their applications.  Please consult that before reviewing these papers.

## What Does Quantum Supremacy Mean for Databases? (2020)

In _Database Trends and Applications Dec 19/Jan20 pg45_; [Harrison, G](What_Does_Quantum_Mean_for_Db_article.pdf) asks now that Google has reached "quantum supremacy," what does that mean for the database community.  Quantum spremacy refers to the point where a quantum based system can perform an task better than a classical system-- note, that there is no requirement that task be useful or interesting.

When databases reach a point of quantum spremacy, requiring the quantum implementation to demostrate more efficiency than classical, there will be several key advantages such as instaneous access and significantly denser storage.  Though this is still pretty far out and will require a decade of improvements before full realization.

## Reduce data processing time in NoSQL databases based on Grover’s algorithm (2019)

At _SCA ’18, October 10–11, 2018, Tetouan, Morocco_; [H. Amellal et al.](Reduce_ProcessingTime_NoSQL_GroverAlgo.pdf) describe an application of quantium computing and NoSQL databases.  As the explosion of Big Data continues to unvail itself, new strategies need to exist to find data that is not properly indexed.  Consider the influence of millions of sensors emitting thousands of datapoints continously, as this leds rapidly pushes organizations to handle trillions of events.

Traditional systems would need to perform a linear scan of the event table, requiring a worst case of O(N).  However, if the scan can apply Grover's algorithm then it would take at most O( sqrt N ) time.  Their example attempts to find the object with unindexed value `id=Grover` through the use of a `blackbox oracle` that becomes entangled, such that the super position transitions to an angle between 0 and 1.  They measure the angle's sine to determine the probability of the record being the expected value.

One of the critical challenges with this approach is that the blackbox oracle is externally defined, and the researchers do not attempt to provide a solution.  They also highlight that it is complex to combine CPU/QPU operations in the same process.  Amazon's Bracket (see video section) reduces this friction, though its still limited in practice.

## Optimized Methods for Inserting and Deleting Records and Data Retrieving in Quantum Database (2010)

For _2010 12th International Conference on Transparent Optical Networks Transparent Optical Networks (ICTON), 2010 12th International Conference on. :1-5 Jun, 2010_; [Gueddana, A; Chatta, R; Boudriga, N](CRUD_for_Quantum_Db.pdf) propose a reference implementation for a quantum `CNOT-based relational database`.  Their solution handles common SQL CRUD operations through a combination of traditional relational technologies (storage) and quantum specific circuits (querying).
