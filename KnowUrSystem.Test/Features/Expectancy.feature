Feature: Expectancy


@需求
Scenario: Max Expectancy
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the Max Expectancy result should be 2.62 about +- 0.5

@需求
Scenario: Avg Expectancy
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the Avg Expectancy result should be 0.8 about +- 0.1

@需求
Scenario: Get 50% Expectancy
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the 50% can get Expectancy result should be 0.8 about +- 0.01


@需求
Scenario: Get Avg EndGain
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the Avg EndGain should be 95.6 about +- 2

@需求
Scenario: Get Max EndGain
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 10000
	And set trades are 120
	When I simulate result
	Then the Max EndGain should be 314 about +- 20