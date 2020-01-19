# FinTech Specific Readings

## The future of fintech (2019)

In _Financial Management 2019 Volume 48 pg. 981–1007_; [Das, S](Das-2019-Financial_Management.pdf) describes the evolution of the financial industry, as it adopts `Financial Technology(FinTech)` causing a distruption across: (a)raisingcapital,(b)allocating capital, and (c) transferring capital.  He states that a long standing challenge for participants in capital markets is waste introduced by intermediates.  For instance, a customer that wants to sell their house must pay the agent 6% commission and the buyer needs to pay several percentage points to the mortgage lender.  

Despite the wide availability of cloud and big data technologies, and reductions in workforce sizes there continues to be a steady 2% overhead to financial transactions.  According to "[the world bank financial services account for 20% of the global GDP](https://www.investopedia.com/ask/answers/030515/what-percentage-global-economy-comprised-financial-services-sector.asp)(Ross, S March 5th 2015)."  Given that the global GDP is approximately 80T that equates to 0.32T/year in global overhead.  As these margins are reduced those savings can remain in the global economy for businesses to invest in growth or higher wages.  Another common challenge is seen in credit card fraud which accounts for 31b/year in losses to the financial industry.  As fraud detection improves there is the potential for enormous savings.

### Investements into Machine Learning

Systems that are capable of efficiently modeling price and risk through pattern recognition systems.  For instance, Culkin and Das created a neural network to predict option prices that could approximate values within 1% of real-world contracts.  According to Peter Novig, _all models are wrong, and increasingly you can suceed without them_.  Several hedge funds are replacing stock pickers with algorithms and this is improving their consistency while reducing costs.

A deep survey in 2018 analyzed neural networks that attempted to predict the SP500, and found that the accuracy is generally lacking.  Typical results are comparable to the a coin toss; though open source software like Tensorflow is improving the cost economics of continued investigation.

### Network Models for Risk Analysis

System risk occurs when an issue impacts a segment, not just an individual name.  For instance, 2008 financial crisis impacted the banking industry as a whole not just one or two companies.  These interconnected models can be represented as `graph strutures` with edges weighted based on the Merton (1974) model.  Financial systems can use this information to efficiently price insurance and determine how black swan events could propigate across sectors.

### Personal and Consumer Finance

Yield hunting continues to impact consumers as the risk free rate is near zero and asset prices have been stagnet.  This has driven investments into higher risk assets, such as Bitcoin, despite it not having any real value.  Seniors, typically retire on bond dividends are also forced to live at a lower standard of living.  The little that is made becomes split with the intermediates and their 2% overhead.  

Robo-advisors can solve `kapsack problems` and boost yield through diversification that still optimizes of high return and lower standard deviation of risk.

### Nowcasting (vs Forecasting)

Another challenge comes from forecasting demand across macroeconomic systems, such as GDP and unemployment, because these numbers are infrequent and often revised.  Specific systems are constructing their own approximations through microeconomic measurements that become aggregated into the larger picture.  These `semantic models` that valuate the likely values and provide more adaptive predictions.

The same concerns occur within ETF products as illiquity can cause the bundle's price to not align with its components.  `Realtime modeling` allows the risk associated with that illiquidity to be calculated and its risk accounted for.

### Cybersecurity

Nearly 45% of businesses within the financial sector experience some sort of cyber attack, versus only 34% in most other industries.  There are millions of stolen credit card number each year as the theft of product is literal cash.  Cryptocurrencies also continue to be unregulated and often used by criminals to mask the transactions of illegal operations.

A fincial service called a `Tumbler` operates as a transaction proxy so that these transactions cannot be easily traced between source and destination receipiants.  These algorithms specifically mask the behavior for a small transaction fee.

Fraud through stolen credit cards has become a huge challenge for shopping sites, as they cannot easily determine a transaction used an illegit card.  Even if the site wants to prevent these transactions the fraud rate is around `1 in 1000` which makes precision of detection a hard problem.

### Payment and funding

Digital payment systems have allowed customers to bypass the banking system with peer-to-peer networking.  Government's such as India have attempted to stop these systems, most recently demonitizing the 500 and 1000 rupee.  These actions invalidated millions of dollars that was not accounted for and avoiding taxation.

Not all payment systems are bad, others have enabled p2p lending for small loans that traditional banks are unwilling to transact.  Big names like GoFundMe and Kickstarter have also entered and evolved this space, while retaining 5-10% of the collected amount for themselves.

### High freuqnecy trading

The availability of `tick-by-tick` market streams has enabled both aggressive profiters and also greater transparency into the behavior of the exchange transactions.  This allows for watchdogs to detect fraudulent behavior that would have been missed in traditional systems.  There is also evidence that HFT improves liquidity through tigher bid/ask spreads.

These systems also introduce the need for sophisticated algorithms to mask large institutional purchases, or the asset prices will jump in anticipation.

### Blockchain and Crypto

The distributed ledger provides many strengths such as prevents double spending, mitigates illegitimate transactions, and is tamper proof.  However, it is also unregulated and highly volatile.   The number of BTC transactions is around 1.5-2.0/second compared with PayPal at 125tps and Visa 4000tps.

### Text Analytics

There are many open problems of extracting meaning from freeform text and deriving financial relevance.  For instance, presidential tweets can often rock a specific company or sector.  If automation can determine the correlation there is a first mover advantage that allows the organization to profit.  One study found that sentimate analysis could predict the direction of the Dow with 87% accuracy using only tweets (Bollen, Mao, Zeng 2011).

Other studies have found correlation between the file size of financial reports and the performance of the business, and others have used linguistic measurements to translate language into a proxy for internal controls.  Afterall if they are loose with the official public reports, what does that tell you about the part they internalize?
