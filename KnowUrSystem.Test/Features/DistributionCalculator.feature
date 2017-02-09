Feature: DistributionCalculator



@需求
Scenario: 連玩N次總和賠錢的機率
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2     | 10        |
	| 1     | -5        |
	| 7     | -1        |
	And set trades are 120
	And set simulation times are 10000
	And set playtime are 3
	And set simulator
	When I CalculateDistributionProbability
	Then the lose equity result should be 50% about +- 0.1

@unit
Scenario: 模擬翻銅板,連玩三次總和賠錢的機率 : 50%
	Given 我輸入fake records table
		| Run | Number | RMultiple | CumulativeRMutiple | 
		| 1   | 1      | 1         | 1                  | 
		| 1   | 2      | 1         | 2                  | 
		| 1   | 3      | 1         | 3                  | 
		| 2   | 1      | -1        | -1                 | 
		| 2   | 2      | 1         | 0                  | 
		| 2   | 3      | 1         | 1                  | 
		| 3   | 1      | 1         | 1                  | 
		| 3   | 2      | -1        | 0                  | 
		| 3   | 3      | 1         | 1                  | 
		| 4   | 1      | 1         | 1                  | 
		| 4   | 2      | 1         | 2                  | 
		| 4   | 3      | -1        | 1                  | 
		| 5   | 1      | -1        | -1                 | 
		| 5   | 2      | -1        | -2                 | 
		| 5   | 3      | 1         | -1                 | 
		| 6   | 1      | -1        | -1                 | 
		| 6   | 2      | 1         | 0                  | 
		| 6   | 3      | -1        | -1                 | 
		| 7   | 1      | 1         | 1                  | 
		| 7   | 2      | -1        | 0                  | 
		| 7   | 3      | -1        | -1                 | 
		| 8   | 1      | -1        | -1                 | 
		| 8   | 2      | -1        | -2                 | 
		| 8   | 3      | -1        | -3                 | 
	And set calculator
	And set playtime are 3
	When I CalculateFakeDistributionProbability
	Then the lose equity result should be 50% about +- 0.1

