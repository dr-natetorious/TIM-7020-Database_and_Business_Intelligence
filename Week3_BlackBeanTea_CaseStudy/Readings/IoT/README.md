# IoT Scenarios

## Near-Field Communication Sensors and Cloud-Based Smart Restaurant Management System (2016)

In _2016 IEEE 3rd World Forum on Internet of Things (WF-IoT) Internet of Things (WF-IoT), 2016 IEEE 3rd World Forum on. :686-691 Dec, 2016_; [Saeed, H; Shouman, A; Elfar, M; Shabka, M; Majumdar, S; Horng-Lung, C](NearField_Sensor_Cloud_Smart_Restaurant.pdf) describe a proof of concept solution that automates aspects of the restaurant experience.  Their solution contains two parts:

1. Customer Mobile App
2. Employee Web Portal

### What scenarios involve the mobile app

The mobile app can use Near-Field Communication (NFC) to order items, check-in to the restaurant, pay the check, and notify staff to assist in other items.  The researchers placed smart cameras to monitor the parking lot and then stream open parking spot information to the mobile users.

### What scenarios involve the web portal

The web portal provides real-time performance monitoring and analytics across the customer lifecycle.  For instance, if the customer has not been served within a threshold an alert is raised.  IoT systems augmet the experience of chefs and streamline the steps, so they are most performant.

### How is this solution unique

The main driver for efforts to automate traditional procedures has been the swift rise of wireless technologies used to ease conventional food ordering processes. Systems that use wireless food ordering include Wireless Ordering System (WOS) [4], Microworks [5] and Nextepsystems [6]. `All of these systems however, require either Personal Digital Assistants (PDAs) or iPads, and they are mainly used to put in orders`. This eliminates errors relating to receiving orders, but they do not eliminate the time delay for the waiter to show up and collect the iPads/PDAs or the time delay for waiters to collect bill payments.

## Microservice-based framework for integrating IoT, semantics, and AI for SCM (2019)

In _The Korean Institute of Communications and Information Sciences ICT Express 5_; [Kousiouris et al.](MicroService_Integrating_IoT_semantic_and_AI_for_SCM.pdf) state that supply chains run into challenges with environmental controls, such as humidity and temperature.  Many businesses want to solve these issues with IoT based solutions, however the range of involved technologies are difficult to connect.  They propose a micro-service based solutions that exposes a plugin model, to bridge functionality and hide differences.

### What are the major subsystems used

1. Node-RED layer, a flow control, UI and middle-ware solution
2. Semantic service block, maps the ontology of different sensors to a logical model
3. AI Block, `tensorflow + Mongo` that runs `DNNRegressor` on the semantic model to detect deviations

## MyRestaurant: Smart Restaurant with Recommendation System (2018)

In _International Journal of Computing and Digital Systems Vol. 8, No. 2 (March)_; [Koubai, N and Bouyakoub, F](MyRestaurant_with_Recommendation.pdf) describe a system that:

1. Uses IoT to simplify and facilitate employee workflows
2. Performs recommendations of similar dishes for repeat customers

### What is a context

They define a context, the environment and actors, as the area that IoT systems operate and collaborate to describe.  These devices derive decisions based on `primary context` (sensor data) and `secondary context` (processed data from sensor data), to be context aware and thus do the right thing.

### What are the connected components

- Connected Oven, refrigerator, hob, table
- Dedicated mobile apps for customers, cooks, and waiter roles
- Desktop application for management to monitor the systems

These components streamline the experience from end-to-end allowing feedback loops, monitoring, and other similar touch points.  The business is made more efficient through offerings such as inventory control.  Another touch-point exists with the customer that loyalty points can be associated and promotions sent across push notifications.
