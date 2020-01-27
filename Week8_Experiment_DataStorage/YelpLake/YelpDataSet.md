# The Yelp Dataset

Yelp offers open challenges to come up with interesting use-cases for [sample data](https://www.yelp.com/dataset/download).  The data set includes business metadata, customer reviews, and photos associated with profile.

## How do I get the dataset into the cloud

```bash
# Create linux docker environment
docker run -it -v `pwd`:/files -w /files debian bash

# Externally download yelp_dataset.tar and yelp_photos.tar
tar -xvf yelp_dataset.tar
mv yelp_photos.tar photos/
tar -xvf photos/yelp_photos.tar
```

## How do I upload into Azure Data Lake

Download and install the [azure cli](https://docs.microsoft.com/en-us/azure/data-lake-analytics/data-lake-analytics-get-started-cli), if not already installed.

```s
az login
az dls fs upload --account nateb --source-path s:\yelp\*.json --destination-path "/yelp"
az dls fs upload --account nateb --source-path s:\yelp\photos\*.jpeg --destination-path "/yelp-photos"
```

## How do I enable Cognative Services

You need to install [U-SQL Extensions](https://docs.microsoft.com/en-us/u-sql/objects-and-extensions/cognitive-capabilities-in#registeringExtensions), which adds 2.5GB of tooling to the account.
