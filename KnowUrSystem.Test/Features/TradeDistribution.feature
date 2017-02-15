Feature: TradeDistribution
	In order to setting Count and R mutiple
	

@需求
Scenario: Set Distribution And Calculate Result
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 #Trades
	When 我計算 Win Rate
	When 我計算 Avg Win/Loss Ratio
	When 我計算 Expectancy
	When 我計算 Standard Deviation
	When 我計算 SQN
	Then #Trades is 10
	Then Win% is 20.0
	Then Avg Win/Loss Ratio is 6.67
	Then Expectancy is 0.8
	Then Standard Deviation is 4.75



Scenario: Calculate #Trades
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 #Trades
	Then #Trades is 10

Scenario: Calculate Win Rate
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 #Trades
	When 我計算 Win Rate
	Then Win% is 20

Scenario: Calculate Win/Loss Ratio
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 Avg Win/Loss Ratio
	Then Avg Win/Loss Ratio is 6.67

Scenario: Calculate mean Expectancy
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 #Trades
	When 我計算 Expectancy
	Then #Trades is 10
	Then Expectancy is 0.8

Scenario: Calculate Standard Deviation
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 #Trades
	When 我計算 Standard Deviation
	Then #Trades is 10
	Then Standard Deviation is 4.75

Scenario: Calculate SQN
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 20     | 10.00     |
	| 10     | -5.00     |
	| 70     | -1.00     |
	When 我計算 SQN
	Then SQN is 1.68