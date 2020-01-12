# Quantum Databases

The [video note section](../../Videos) contains my small crash-course on how quantum algorithms work, and their applications.  Please consult that before reviewing these papers.

## What Does Quantum Supremacy Mean for Databases? (2020)

In _Database Trends and Applications Dec 19/Jan20 pg45_; [Harrison, G](What_Does_Quantum_Mean_for_Db_article.pdf) asks now that Google has reached "quantum supremacy," what does that mean for the database community.  Quantum spremacy refers to the point where a quantum based system can perform an task better than a classical system-- note, that there is no requirement that task be useful or interesting.

When databases reach a point of quantum spremacy, requiring the quantum implementation to demostrate more efficiency than classical, there will be several key advantages such as instaneous access and significantly denser storage.  Though this is still pretty far out and will require a decade of improvements before full realization.

## Reduce data processing time in NoSQL databases based on Grover’s algorithm (2019)

At _SCA ’18, October 10–11, 2018, Tetouan, Morocco_; [H. Amellal et al.](Reduce_ProcessingTime_NoSQL_GroverAlgo.pdf) describe an application of quantium computing and NoSQL databases.  As the explosion of Big Data continues to unvail itself, new strategies need to exist to find data that is not properly indexed.  Consider the influence of millions of sensors emitting thousands of datapoints continously, as this leds rapidly pushes organizations to handle trillions of events.

Traditional systems would need to perform a linear scan of the event table, requiring a worst case of O(N).  However, if the scan can apply Grover's algorithm then it would take at most O( sqrt N ) time.  Their example attempts to find the object with unindexed value `id=Grover` through the use of a `blackbox oracle` that becomes entangled, such that the super position transitions to an angle between 0 and 1.  They measure the angle's sine to determine the probability of the record being the expected value.

One of the critical challenges with this approach is that the blackbox oracle is externally defined, and the researchers do not attempt to provide a solution.  They also highlight that it is complex to combine CPU/QPU operations in the same process.  Amazon's Bracket (see video section) reduces this friction, though its still limited in practice.

## A fast quantum mechanical algorithm for database search (1996)

In _Proceedings, 28th Annual ACM Symposium on the Theory of Computing (STOC), May 1996, pages 212-21_; [Grover, L](Quantum_Algo_for_Database_Search.pdf) provides an algorithm and its associated proofs that a value can be retreived from an unsorted list in sqrt(N) time.  This paper appears to be the basis that all other quantum database research extends from and contains details that others such as Amellal et al. breeze over.

### How does the algorithm works

1. Initialize the distribution of all elements to `1/sqrt(N)`
2. Repeat for sqrt(N) iterations:
    a. If `C(S) =1`, rotate by `pi radians`; else no change -- where `S` is the state of the system
    b. Apply the diffusion transform `D` -- where `D = WRW` with _R the rotation matrix and W the [Walsh-Hadamard Transform matrix](https://en.wikipedia.org/wiki/Hadamard_transform)_
3. Sample the resulting state; if `C(Sv) =1` there is a unique state `Sv` with final state `Sv` having a probability at least 50%

*Note*: A Walsh-Hadamard Transform is also called a Hadamard Gate in some literature.

## Optimized Methods for Inserting and Deleting Records and Data Retrieving in Quantum Database (2010)

For _2010 12th International Conference on Transparent Optical Networks Transparent Optical Networks (ICTON), 2010 12th International Conference on. :1-5 Jun, 2010_; [Gueddana, A; Chatta, R; Boudriga, N](CRUD_for_Quantum_Db.pdf) propose a reference implementation for a quantum `CNOT-based relational database`.  Their solution handles common SQL CRUD operations through a combination of traditional relational technologies (storage) and quantum specific circuits (querying).

The researchers provide mathmatical proofs that through entanglement, records can be efficiently inserted and deleted; for instance deletion becomes a negation the insert can always be appended.  They also propose a Grover-based algorithm to retrieve the records and perform natural joins between tables.  Additional research will need to investigate complex queries and potentially need more optimizations (e.g. arbitrary predicates).

### What is a CNOT gate

A [Controlled NOT gate](https://en.wikipedia.org/wiki/Controlled_NOT_gate) is a quantum logic gate used to entangle and disentangle qubits.  It *appears* the most common form is the Hadamard transform gate, as that continues to be the example.
