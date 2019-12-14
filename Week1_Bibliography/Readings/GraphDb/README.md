# Graph Databases

## Previous Research Link

- [TIM-8101 Data Analysis with TinkerPop](https://github.com/dr-natetorious/TIM-8101-Principals_of_Computer_Science/tree/master/Week2_DataAnalysis) - Android to TinkerPop for Callgraph Traversal

- [TIM-8101 Android to TinkerPop for Callgraph Analysis](https://github.com/dr-natetorious/TIM-8101-Principals_of_Computer_Science/tree/master/Week8_Capstone)

## A Survey on Graph Database Management Techniques for Huge Unstructured Data (2018)

The authors [Patil N. S., Kiran P, Kavya N. P., Naresh Patel K. M.](GraphDb_Management_for_Huge_Unstruct_Data.pdf) conducted a survey across the landscape of Graph database (GDB) systems and their capabilities.  A GDB is highly efficient at querying relationship information, such as social graphs, because it traverse local instead of global indexes.  Data models for GDB tend to much eaiser to create and describe, because they more naturally align with "whiteboard diagrams."

Many solutions have attempted to provide graph abstractions on top of relational databases, or other traditional technologies.  These tend to be inefficient because:

1. Horizontal scaling and layer mechanisms introduce overhead
2. Systems are optimized for specific domain, not general purpose
3. Use In-memory models, which limit the supportability
4. Lack consistency across the programming interface, with Gremlin and SPARQL gaining consensus

### What are common graph databases

- Neo4j - the most popular graph database today
- HyperGraphDb - Open source distributed database with easy conversion into tuples
- DEX - Portable high performance C++ implementation with support for hosting in Java/.NET
- Trinity - Distributed Graph over Memory Cloud to expose Key-Value store
- Infinite Graph - Single graph solution with high througput and locking capabilities
- Titan - Gremlin, Rexster, and Blueprints stack that provides a consistent abstraction layer

### What are active topics in graph database research

1. Online compression to reduce dimensionality of graphs
2. Indexing and Super Graph search
3. Feature mining
4. Similarity comparison of sub-graphs
5. Use-cases for biology (e.g. protein-protein interfaces)

## A Graph Database of Yelp Dataset Challenge and Using Cypher for Basic Statistics and Graph Pattern Exploration (2018)

The authors [Kronmueller, M; Chang, D; Hu, H; and Desoky, A](GraphDb_YelpDatasetChallenge.pdf) participated in the Yelp Dataset challenge, by loading a the extracts into a Neo4j store and then experimenting with cypher query language to find bipartites and connected components.

They found that graph based solution could traverse complex relationships to extract specific patterns.  These same discoveries would be difficult to accomplish through relational databases due to the `access patterns not aligning with the store expectations`.

It appears that Yelp has regular [Dataset challenges](https://www.yelp.com/dataset/documentation/main) and this might be a good topic for Week8 Capstone.

|File Name| File Size| Number of records|
|---------|----------|------------------|
|user.json| 1,847,071 KB| 1,326,101|
|business.json| 141,773 KB| 174,567|
|review.json| 4,099,872 KB| 5,261,669|
|tip.json| 192,928 KB |1,098,325|