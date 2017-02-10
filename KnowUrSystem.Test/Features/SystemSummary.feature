Feature: SystemSummary

@mytag
Scenario: 取得系統模擬結果
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then win% should be 0.7 +- 0.1
	Then win/loss ratio should be 6.67 += 0.1
	Then expectancy should be 0.8 +- 0.1
	Then lossing streaks should be 16 
	Then drawdown R should be -29.3 +- 1
	Then ending gain R should be 95.6 +- 1
	Then #Trades for break even (95%) should be 88
	Then 95% drawdown duraiton Months should be 8.8
	Then yearly gain R should be 96
	Then Avg yearly gain / avg drawdown should be 3.3 +- 0.1


