﻿Feature: ControlSimulation
	In order to set times

@需求
Scenario: Set Trades Per Month
	Given 我設定每月交易 10 次
	Then 模擬器顯示每月交易 10 次
	
@需求
Scenario: Set Simulation Times
	Given 我設定模擬 10000 次
	Then 模擬器顯示模擬 10000 次

#Scenario: Limit Simulation Times Min Are 2500
#	Given 我設定模擬 2000 次
#	Then 模擬器顯示模擬 2500 次

Scenario: Limit Simulation Times Max Are 10000
	Given 我設定模擬 11000 次
	Then 模擬器顯示模擬 10000 次