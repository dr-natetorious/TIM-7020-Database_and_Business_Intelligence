# Business Intelligence

## Business Intelligence Tomorrow... and what it means for today (2019)

The author [Harper, J](BI_tomorrow_article.pdf), wrote an article about the future of BI that outlined platform requirements:

1. Metadata management, e.g. classification and identification tags
2. Semantics, understanding of data's meaning
3. Data Cataloging, information governance on top of the e.g. data lake
4. Data Models, schemas and structural information

### Natural Language Processing

They also discuss the influence of Natural Language (Generation and Interactions), where users will want to ask "how many students are in Ms. Allen's math class", and those results render into a visualization or report.  This enables the self-service scenarios that are BI needs to address in order to expand outside of data scientistic.  They also highlight the need for _Natural Language Understanding_ where alias exist to "do what I mean, not what I said" (e.g. how many kids in the math class -- kids are goats not
students).

### Multi-cloud strategies

The hybrid and multi-cloud deployments pivot the strategy of BI, such that the cheapest and most performant storage is always available to the most powerful tools. As the data is free to transition between multi-cloud environments, it can naturally flow where the connectors exist for the _business specific use-cases_.  This is counter to the current strategy, that legacy technology decisions can only be undone with Extract Load Transform (ELT) and months of planning.  *TLDR*: Agility and choice.

### Edge Computing

Next they talked about the influence of edge computation, where micro-clouds of IoT devices transform `high volume/low quality` senor data into `low volume/high quality` aggregations.  These feeds can then be promoted up the tree to data collection hubs that repeat the process and give more actionable results. (e.g. dont tell me 100 times its ~72 deg, tell me once with a high confidence its 71.6 degrees).

> BI is "really about creating something that you can build on top of and go further to start to break the chains and solve the problems of [data] access and reliability," Bien asserted. "As you solve those base needs, sort of like the base needs of hunger and shelter, then you can start to move up the value chain more and provide even more to people in your organizations."

## Business Intelligence for Enterprise Systems: A Survey (2012)

The authors [Duan, L; Xy, L](BI_for_Enterprises.pdf) discuss the emergence of BI strategies that will be adopted by Enterprise systems.

### Supervised Learning

These are statistical training methods were the labels are known in advance.

1. Nearest Neighbor: A distance function _clusters_ objects into groups
2. Decision trees: clustering of choices that lead to efficient choices
3. Bayesian stats: naive probability theory that results in networks of joint conditional likelihood
4. Neural Networks: Complex weighted graphs that map inputs to choices through hidden layers
5. Support Vector Machines: Attempts to split a data set (hyperplane) into two classes
6. Regression: Attempts to fit a curve to multi-dimensional data set (linear or gradient) (think cheap)

### Unsupervised Learning

These are statistical training methods were the labels are unknown in advance.

1. Itemset Mining: Searching for common attributes that appear together (e.g. correlation pairs)
2. Clustering: Sort the data into k-groups so that all items within the group are similar

### Future Research

1. Outlier Detection
2. Graph Data
3. Environmental Issues, e.g. edge computation

## Building novel capabilities to enable business intelligence agility: results from a quantitative study (2018)

The authors [Knabke, T; Olbrich, S](Enable_BI_Agility_Capabilities.pdf) state that it is challenging for businesses to _balance long-term strategy against dynamic market competition_.  They propose that BI technology needs to fill that gap, by  

1. improving agility and reducing the time/complexity to gather information
2. allowing for self-service scenarios to internalize these facts
3. _guide decisions in all kinds of organizations and across hierarchical levels and functions_

### Current state of BI

Many organizations have implemented some notion of data warehouse-based BI, however these systems tend to focus on structured queries that are known in advance.  This is at odds with the ever growing unstructured and semi-structured ecosystem that comes with Big Data producers.  

They argue that the BI agility is not very mature despite many of the core concepts being many years old.  

> All of the existing attempts concentrate on "how" to achieve BI agility, but none investigate the drivers and effects on BI agility, i.e., the "what" (research gap 1).
> [...]
> Especially, as none of the available research analyzes the integration of BI into the external and internal processes of an organization, particularly in dynamic environments.

### Adoption of In-Memory Technologies

Specific enterprises are transitioning from traditional relational stores to in-memory databases, as they are more responsive and enable dynamic exploration of the data sets.

> Summarizing, this paper addresses the following research questions:
> How do dynamic capabilities in the domain of BI impact each other, and how can organizations use them to achieve BI agility as a basis for timely and viable decision support?
> Do emerging technologies like IMDB make a difference in achieving BI agility, either direct or via mediating effects?
