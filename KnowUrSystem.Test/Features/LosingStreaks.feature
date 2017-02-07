﻿Feature: LosingStreaks
	In order to show reslut


@需求
Scenario: Simulate Avg Number Of Consecutive Losses
	Given simulator is Stub
	And set simulation times are 2500
	And set trades are 120
	And simulator's Avg Consecutive Losses return 16
	When I simulate result
	Then the Avg Consecutive Losses result should be 16

@需求
Scenario: Simulate Max Number Of Consecutive Losses
	Given simulator is Stub
	And set simulation times are 2500
	And set trades are 120
	And simulator's Max Consecutive Losses return 52
	When I simulate result
	Then the Max Consecutive Losses result should be 52


@整合
Scenario Outline: Simulate Then Get Max And Avg  Number Of Consecutive Losses
	Given 我輸入Count vs R mutiple table :
	| Count   | RMultiple |
	| <count> | <r>       |
	And set simulation times are <times>
	And set trades are <trades>
	When I simulate result
	Then the Max Consecutive Losses result should be <max>
	Then the Avg Consecutive Losses result should be <avg>
	Then total records should be <records>
	Examples: 
	| count | r  | times | trades | max | avg | records |
	| 10    | 1  | 1     | 120    | 0   | 0   | 120     |
	| 10    | -1 | 1     | 120    | 120 | 120 | 120     |
	| 10    | 1  | 2     | 120    | 0   | 0   | 240     |
	| 10    | -1 | 2     | 120    | 120 | 120 | 240     |

@整合
Scenario: Simulate 1 Run And Get Avg Number Of Consecutive Losses With Win Ratio 100% Should Be 0
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 10    | 1         |
	And set simulation times are 1
	And set trades are 120
	When I simulate result
	Then the Avg Consecutive Losses result should be 0

@整合
Scenario: Simulate 2 Run 120 Times Then Total Records Are 240
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 10    | -1        |
	And set simulation times are 2
	And set trades are 120
	When I simulate result
	Then total records should be 240

@unit
Scenario: 驗證模擬的記錄筆數
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 10    | -1        |
	And set simulation times are 1
	And set trades are 120
	When I simulate result
	Then the records result should be 120

@unit
Scenario: 計算連續虧損次數
	Given 我輸入records table :
	| IsWinMoney |
	| true       |
	| false      |
	| false      |
	| true       |
	| true       |
	| false      |
	| false      |
	| false      |
	When I Calculate Consecutive Losses
	Then the Consecutive Losses should be '2,3'

@unit
Scenario: 計算連續虧損次數2
	Given 我輸入records table :
	| IsWinMoney |
	| false      |
	| false      |
	| false      |
	| false      |
	| false      |
	| false      |
	| false      |
	| false      |
	When I Calculate Consecutive Losses
	Then the Consecutive Losses should be '8'