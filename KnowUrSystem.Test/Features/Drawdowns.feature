Feature: Drawdowns
	In order to get drawdowns

@需求
Scenario: Simulate Then Get MaxDD
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the MaxDD result should be -119.0

@需求
Scenario: Simulate Then Get AvgDD
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the AvgDD result should be -29 about +- 1

@Stub
Scenario: Stub Simulate Then Get MaxDD
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
	Then the MaxDD result should be -119.0


@unit
Scenario: 計算MaxDD Part1
	Given 我輸入R-mutiple Record table :
	| IsWinMoney | RMultiple |
	| true       | 10        |
	| false      | -5        |
	| false      | -1        |
	| true       | 1         |
	And set DrawdownCalculator
	When I calculate MaxDD
	Then the DrawdownCalculator's MaxDD should be -6

@unit
Scenario: 計算MaxDD Part2
	Given 我輸入R-mutiple Record table :
	| IsWinMoney | RMultiple |
	| true       | 10        |
	| false      | -5        |
	| true       | 1         |
	| false      | -5        |
	| false      | -1        |
	And set DrawdownCalculator
	When I calculate MaxDD
	Then the DrawdownCalculator's MaxDD should be -10

@unit
Scenario: 計算MaxDD Part3
	Given 我輸入R-mutiple Record table :
	| IsWinMoney | RMultiple |
	| false      | -5        |
	| true       | 10        |
	| true       | 1         |
	| false      | -5        |
	| false      | -1        |
	| true       | 20        |
	And set DrawdownCalculator
	When I calculate MaxDD
	Then the DrawdownCalculator's MaxDD should be -6

@unit
Scenario: 計算隨機取得R倍數
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 1
	And set trades are 10
	When I simulate result
	Then the random R mutiple should less than 11
	Then the random R mutiple should greather than -2