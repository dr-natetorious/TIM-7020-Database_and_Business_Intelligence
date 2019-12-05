# Business Intelligence

## Business Intelligence Tomorrow... and what it means for today (2019)

The author [Harper, J](BI_tomorrow_article.pdf), wrote an article about the future of BI that outlined platform requirements:

1. Metadata management, e.g. classification and identification tags
2. Semantics, understanding of data's meaning
3. Data Cataloging, information governance on top of the e.g. data lake
4. Data Models, schemas and structural information

They also discuss the influence of Natural Language (Generation and Interactions), where users will want to ask "how many students are in Ms. Allen's math class", and those results render into a visualization or report.  This enables the self-service scenarios that are BI needs to address in order to expand outside of data scientistic.  They also highlight the need for _Natural Language Understanding_ where alias exist to "do what I mean, not what I said" (e.g. how many kids in the math class -- kids are goats not
students).

The hybrid and multi-cloud deployments pivot the strategy of BI, such that the cheapest and most performant storage is always available to the most powerful tools. As the data is free to transition between multi-cloud environments, it can naturally flow where the connectors exist for the _business specific use-cases_.  This is counter to the current strategy, that legacy technology decisions can only be undone with Extract Load Transform (ELT) and months of planning.  *TLDR*: Agility and choice.

Next they talked about the influence of edge computation, where micro-clouds of IoT devices transform `high volume/low quality` senor data into `low volume/high quality` aggregations.  These feeds can then be promoted up the tree to data collection hubs that repeat the process and give more actionable results. (e.g. dont tell me 100 times its ~72 deg, tell me once with a high confidence its 71.6 degrees).
