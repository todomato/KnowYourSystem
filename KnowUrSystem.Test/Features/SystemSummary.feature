Feature: SystemSummary

@需求
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
	Then win/loss ratio should be 6.67
	Then expectancy should be 0.8 +- 0.1 and STD should be 0.43
	#Then win% should be 0.7 +- 0.1 and STD should be 0.37
	Then lossing streaks should be 16 
	Then drawdown R should be -29.3 +- 1  and STD should be 11.2
	Then ending gain R should be 95.6 +- 1 and STD should be 51.8
	Then #Trades for break even (95%) should be 88 +- 3
	Then 95% drawdown duraiton Months should be 8.8 +- 1
	Then yearly gain R should be 96
	Then Avg yearly gain / avg drawdown should be 3.3 +- 0.1

@整合
Scenario: 取得系統模擬結果 : 期望值、系統勝率?
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then win/loss ratio should be 6.67
	Then expectancy should be 0.8 +- 0.1 and STD should be 0.43
	#Then win% should be 0.7 +- 0.1 and STD should be 0.37
	
	

@整合
Scenario: 取得系統模擬結果：Drawdown
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then lossing streaks should be 16 
	Then drawdown R should be -29.3 +- 1  and STD should be 11.2
	Then ending gain R should be 95.6 +- 1 and STD should be 51.8
	

@整合
Scenario: 取得系統模擬結果 : 95%信心區間
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then #Trades for break even (95%) should be 88 +- 5
	Then 95% drawdown duraiton Months should be 8.8 +- 1

@整合
Scenario: 取得系統模擬結果 : 平均End Gain / 平均DD
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then yearly gain R should be 96
	Then Avg yearly gain / avg drawdown should be 3.3 +- 0.1

