# Influence of Social Media and Business Intelligence

## Social media and business intelligence: defining and understanding social media intelligence (2016)

In _Journal of Decision Systems, Vol. 25 Issue 3, 191-192_ [Dutot, V and Mosconi, E](Understading_Social_BI.pdf) state that professional and industry sources are already consuming social media data however there is a "great deal of misunderstanding as to how it can be used effectively."

> There is a general desire to leverage it for solid return on investment strategies or improve customer relationship management (CRM) scenarios.

### What is Social Media Intelligence

Combining social media and business intelligence allows companies to gain a competitive edge, cut costs and release products with a higher degree of success, becoming crucial for any company.

### How is it being used

The authors provided a summary of five different articles that focused on

1. Impact of social media on Interpersonal Communication
2. Impact of social media on Decisional Liquefaction (availiability of data)
3. Factors that lead to disengagement of Social media members
4. Lack of consistent definition for social media, with focus on feature taxonomy
5. Social media application and their ability to effect business strategy

## Social Business Intelligence: Review and Research Directions (2018)

In _Journal of Intelligence Studies in Business Vol. 8, No 2 pp. 23-42_; [Gioti, H; Ponis, S; Panayiotou, N](Social_BI_Review_and_Direction.pdf) describe the new emerging field that combines BI and social media.

> Traditional BI scientists and practitioners, after an inevitable initial shock, are currently discovering and acknowledge the potential of user generated content (UGD) published in social media as an invaluable and inexhaustible source of information capable of supporting a wide range of business activities.

These authors reviewed 83 papers on SBI and organizied them into a hierarchy of themes.

### What are researchers excited about the BI

According to Ranjan (2009), BI is like a “crystal ball” in the hands of managers, revealing the best course of action depending on five major parameters:

1. the company's position in relation to its rivals
2. the overall strengths and weaknesses of the company
3. current and future market demographic and economic trends; social, political and regulatory environment
4. competitions' decisions and strategy
5. customer preferences and purchasing patterns

### What are the themes about SBI

For those critically standing before the rapid emergence of the subject, `SBI is nothing but the next logical step of BI evolution`, providing enhanced collaborative capability in the decision-making process of an organization by adding the analytical capability pertaining to social media.

For others, `SBI is a BI paradigm revolution`, especially when combined with the emergence of Big Data and the ever increasing variety, volume and velocity with which they arrive in front of business systems’ queues for further processing in order to effectively support decision making.

### How are researchers using social data

- Identify value beyond sales and marketing
- Enterprise Information Fusion, to cross multiple industries
- Extracting unstructured responses to product reviews
- `Social Customer Relationship Managment` (SCRM)
- `Voice of Customer/Voice of Market` (VoC/VoM)
- User Profiling and Personalized Marketing
- Social tagging and annotation services
- Corporate Reputation Monitoring

### What tools are analyze social data

- Typical BI ecosystems; OLAP and visualizations
- Natural Language Processing (NLP); e.g., sentiment analysis
- Processes for combining `User Generated Content (UGC)` with corporate data
- HYDRA, framework for discovering corellations between social graphs

## Generating BI Through SM Analytics (2019)

In _Journal of Management Information Systems / 2019, Vol. 36, No. 3, pp. 893–930_; [Hu, Y; Xy, A; Hong, Y; Gal, D; Sinha, V; Akkiraju, R](Generating_BI_Through_SocialMedia_Analytics.pdf) claim that humans tend to attribute human personality traits to brands, as it allows them to associate their similarity to other members of their social groups.

The authors propose a framework to extract human personality from unstructured textual data by extracting brand personality from user-generated content.  Across 219 Fortune1000 brands, they collected:

- 680k official tweets
- 312k glassdoor employee reviews
- 2m brand-user comments (tweet followers)
- 11k survey responses to measure 219 perceived ground truths (using Amazon MTurk)

Next text extraction performed sentiment analysis across the reports, and attempted to discover characteristics of the brand.  They found that glassdoor and users comments were more authentic than official posts (duh).

### What is brand personality

The term brand personality, first introduced by Martineau in 1958, refers to a set of human characteristics associated with a brand [84]. For example, the Apple brand is perceived to be young, while the IBM brand is perceived to be old.

In 1997, Aaker developed brand personality scales [...] these traits are grouped into five dimensions: Sincerity, Excitement, Competence, Sophistication and Ruggedness.

### How did they analyze the text

- Normalize text and removed stop words
- Construct bag of words and measure the term frequency
- Extract topical features (LDA modeling, k=20)
- Elastic-Net regression/regularization, good for sparse data
- Calculate the R^2 correlation across the 42 traits per brand
- Feed the correlation matric into logistical regression model, SVM, and KNN

### What did they learn

In today’s business environments, to gain competitive intelligence, firms need to gather
data not just internally but externally as well.

> Our high-performance model also provides the first real-world evidence for a brand personality-consumer identity link, thereby supporting the fundamental notion that consumers use brands symbolically to communicate their identity.
