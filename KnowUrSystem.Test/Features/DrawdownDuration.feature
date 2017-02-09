Feature: DrawdownDuration

@需求
Scenario: 95% 可能創新高所需的交易次數
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the 95% >= Equity Peak's result should be 88 about +- 3


@需求
Scenario: 99% 可能創新高所需的交易次數
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 200
	When I simulate result
	Then the 99% >= Equity Peak's result should be 170 about +- 10


		

