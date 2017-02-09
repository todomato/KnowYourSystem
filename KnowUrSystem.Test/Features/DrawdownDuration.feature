Feature: DrawdownDuration

@需求
Scenario: 99% 可能創新高所需的交易次數
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	And set simulator
	And set simulation times are 100000
	And set trades are 120
	When I simulate result
	Then the 99% >= Equity Peak's result should be 197


	
@unit
Scenario: 計算累計R倍數
	Given 我輸入R-mutiple Record table :
	| IsWinMoney | RMultiple |
	| true       | 1         |
	| false       | -6         |
	| true       | 1         |
	| true       | 1         |
	| true       | 3         |
	And set DrawdownCalculator
	When I calculate CalculteCumulativeRmutiple
	Then the CalculteCumulativeRmutiple's No.1 result should be 1
	Then the CalculteCumulativeRmutiple's No.2 result should be -5
