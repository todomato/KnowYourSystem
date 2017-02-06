Feature: TradeDistribution
	In order to setting Count and R mutiple
	

@mytag
Scenario: Set Distribution And Calculate Result
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10.00     |
	| 1     | -5.00     |
	| 7     | -1.00     |
	When 我計算 Expectancy
	When 我計算 Standard Deviation
	When 我計算 Win Rate
	When 我計算 Win/Loss Ratio
	When 我計算 #Trades
	Then Expectancy is 0.8
	Then Standard Deviation is 4.82
	Then Win% is 20.0
	Then Win/Loss Ratio is 6.67
	Then #Trades is 10
