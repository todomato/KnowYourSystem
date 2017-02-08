Feature: Drawdowns
	In order to get drawdowns


@需求
Scenario: Simulate Then Get MaxDD
		Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And DrawdownCalculator is Stub
	And DrawdownCalculator's MaxDD return -119.0
	And set stub simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the MaxDDresult should be -119.0
