# Forecasting and Predictions

## Predicting Future Visitors of Restaurants Using Big Data (2018)

In _Proceedings of the 2018 International Conference on Machine Learning and Cybernetics, Chengdu, China, 15-18 July 2018_; [Ma X; Tian, Y; Luo, C; Zhang, Y](Predicting_Future_Visitors.pdf) discuss how restaurant owners need to accurately estimate the number of future customers.  They propose a strategy using big data and supervised learning that uses `K-Nearest-Neighbour, Random Forests, and XGBoost`.  

### Why is this story unique

> Although various techniques are proposed for many areas to predicting the number of future visitors in service industry, little is known for restaurant owners to forecast the number of future visitors using big data. [6] focused only on visitors’ revisit. Note that new customers may outnumber old customers in certain restaurants of tourist destinations.

### What is machine learning regression

Many machine learning algorithms for regression, can find correlations between factors and consequences to predict future numbers.

- *Support Vector Machine (SVM)* is commonly used to [build a kernel](https://en.wikipedia.org/wiki/Kernel_method), that is essentially a `weighted tuple` that maps to a `known value`.  When an `unknown value` comes in the algorithm attempts to fine the `most similar item` (aka: the supporting vector) to approximate the prediction.

- *Random Forest (RF)* can work for any data without prior knowledge about linearity relying on a
number of decision trees, it uses the mean prediction to generate the final prediction. Since each tree contains a subset of all features, it is robust against irrelevant features.

- *Deep Neural Networks (DNN)* uses multiple layers of networks to model highly non-linear relations, however it requires significant amounts of training data and computation time.

- *XBBoost* a decision-tree-based method based on the idea of [Gradient Boosting](http://arogozhnikov.github.io/2016/06/24/gradient_boosting_explained.html).  The algo attempts to fill in the `residual` gaps between sub-tree buckets, by approximating the missing information.  This approach _boosts_ the granularity and gives more accurate estimates.

### What is the optimization goal

The goal is to approximate `f(D, i, t) = v` minimizing [root mean squared logarithmic error](https://stats.stackexchange.com/questions/56658/how-do-you-interpret-rmsle-root-mean-squared-logarithmic-error/56659); where:

```list
D = DataSetUniverse
R = Resturants
i = index into Restaurants
t = time
v = total visitors
```

### Which features should be selected

1. The first group of features are related to time. Using time information, we constructed the following features: year, month,
week of year, day of week, and whether the data is a holiday.

2. The second group of features are from restaurant attributes. To compare different restaurants, we constructed several features: their unique ID, latitude, longitude, genre, and location area. Since some features are categorical, we use [one-hot encoding](https://machinelearningmastery.com/why-one-hot-encode-data-in-machine-learning/) for preprocessing, so that distance-based algorithms can process them. Hence, the training data has a significantly large number of columns.

3. The third group of features are from restaurant visitor history. We constructed several features: mean, median, minimum,
maximum of visitors, and the total number of visitors before a day (note that we count the repeated visits of a visitor).

4. The last group of features are from reservation history. We constructed several features: mean reserved seats, the total
number of reserved seats before a day, mean time of the reservation before expected visit, and whether the reservation is
within 48 hours.

## MyRestaurant: Smart Restaurant with Recommendation System (2018)

In _International Journal of Computing and Digital Systems Vol. 8, No. 2 (March)_; [Koubai, N and Bouyakoub, F](MyRestaurant_with_Recommendation.pdf) describe a system that:

1. Uses IoT to simplify and facilitate employee workflows
2. Performs recommendations of similar dishes for repeat customers

They define a context, the environment and actors, as the area that IoT systems operate and collaborate to describe.

TODO: Add additional summary

## Near-Field Communication Sensors and Cloud-Based (2016)

TODO: Add summary
