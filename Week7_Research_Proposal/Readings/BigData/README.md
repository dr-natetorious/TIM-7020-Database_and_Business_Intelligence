# Big Data Readings

## Big Data Impacts and Challenges: A Review (2019)

In _2019 IEEE Jordan Internation Join Conference on Electrical Engineering and Information Technology (JEEIT)_; [Al-Sai, Z; Abdullah, R; Husin, M](BigData_Impacts_and_Challenges.pdf) discuss some of the issues that are being caused by the explosion of big data, such as its exponential growth.  

### Why should I care about big data

According to one recent study, the top five domains (e.g., health care and retail) will create 215b$ worth of new value; and organizations are facing pressure to create a strategy or become irrelevant.

The ability to generate so much value comes from every system interaction emits events.  These events can be captured offline and analyzed for patterns afterwards, such as measuring marketing campaigns or reviewing customer behaviors.  Through these understandings business value can be created and agile decisions made around dynamic market conditions.

> To this end, organizations use Big Data mainly for market analysis and customers' segmentation. For example, organizations collect social media data streams like that provided by YouTube, Twitter, and Facebook.

### Why is this really hard

It is not sufficient to simply collect data and hope for osmosis; instead "this investment requires more technology, efforts, better development and effective use of valuable Big Data. Also it need to formulate regulations and policies to ensure data security, accuracy, privacy, high quality, and control of the data".  Organizations need to have specific plans to address these issues, and address specific goals of big data projects.

The authors then segment these issues into buckets:

- People challenges (e.g., training)
- Technology challenges (e.g., lots of storage and complex tooling)
- Organization challenges (e.g., political resistence, needing to show value to prioritize)
- Process challenges (e.g., information governance and retention policies)
- Data management challenges (e.g., security, privacy, compliance)

## Orchestrating Big Data Analysis Workflows in the Cloud (2019)

In _ACM Computing Surveys, Vol. 52, No. 5, Article 95. Publication date: September 2019_; [Barika, M; Garg, S](Orchestrating_BigData_Workflows_in_the_Cloud.pdf) provide a taxonmy of different tooling patterns and where they see the industry headed.  They state that Big Data workload are very different from traditional business and scientific workflows "as they have to continuously process heterogeneous data and support multiple analytical tasks."

### What are the programming models used

- MapReduce (static batch) that performs offline divide and conquer strategies
- Stream Model (unbound sets) that perform incremental calculations.  Microbatching might be used to reduce operational costs.
- NoSQL/SQL Models (store and retrieval) centric
- Message Ingestion (pub/sub and queuing)
- Hybrid Models (e.g., Google Dataflow) that support batch/stream
- Lambda model (micro batch)
- Kappa model treat everything as a stream always

### Considerations of Cloud Location and Data Management

- Private edge and public cloud have distinct QoS and SLA targets
- Consider the resource costs in terms of cpu, storage, networking, synchronization, task scheduling, fault tolerance
- influence of heterogeneous cloud provider models
- data security, movement, and `storage`, lineage (A feeds into B into C), indexing
- cross cloud straetgies either abstract, containerize, or broker

### What are open issues

See page 34 for a detailed breakdown of these items.

- Workflow interopability and openness
- Workflow fault-tolerance and dependability
- Distributed Workflow execution
- Workflow security
- Alignments with user perspective
- Cross-Cloud workflow migration
- Workflow Resource Operatbility and Volatility
- Cross-Layer Resource Configuration Selection
