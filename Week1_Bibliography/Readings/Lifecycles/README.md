# Data Lifecycle Management

## Data lifecycle and technology-based opportunities in new Product Service System (2019)

The authors [Zambetti, M; Pinto, R; Pezzotta, G](DataLifeCycle_Technology_based_Opportunties_in_ProductServiceSystems_towards_MultiDimensionalFramework.pdf) state the fourth industrial revolution has led to an enormous amount of data collection and enhancements.  If that data remains as [Dark Data](../BigData) then it will not be operationalized nor monitized.

*Servitization* is [defined](https://www.definitions.net/definition/servitization) as _The delivery of a service component as an added value, when providing products_.  Since the 19th centry manufacturers has combined products and services to increase their product offerings.  It has evolved over time to include many data-driven decisions of which combinations should be placed together.

Making these data-driven decisions requires data collection of _facts_ that lead to enlightenment.  These facts have dimensions:

- Types of data that should be gathered to offer value added service
- data storage options for customer data
- data analysis opportunities
- types of deployment technology for the data-driven service delivery

### What are the phases of lifecycle management

There are different pipelines for _generation versus acquistion_ feeds.

- Generation > Acquisition > Storage Analysis
- Collection > Storage > Analysis > Deployment

When the data is collected from the various sources, it will come in all shapes and sizes.  The system will need to decide if its better to apply _schema on read or write_.  These decisions will influence the SQL vs NoSQL patterns that follow.

Then the data needs to be stored in a manner the customer would expected.  Consider the privacy and regulatory requirements that enforce their implicit trust in the system.

During the analysis phase machine learning and other statistical algorithms can be applied to build models.  These models should try to answer directed questions and not boil the ocean.

Then the model needs to be published either behind a service endpoint or as a curated model in a data catalog. If the system is an Open Platform, then additional considerations around third-party data integrations needs to occur.
