Feature: Optimizer
	In order to 最佳化


@需求
Scenario: Set Optimizer Control
	Given 我設定每年交易 120 次
	Given 我設定模擬最大Risk 20.00 %
	Given 我設定虧損總資產 -20.00 % 作為破產
	Given 我設定獲利總資產 50.00 % 作為退休
	Given 我設定起始總資產為 100000
	Given 我設定Risk增幅 0.2 %
	Given 我設定模擬 10000 次
	Then 模擬器顯示每年交易 120 次
	Then 模擬器參數顯示模擬最大Risk 20.00 %
	Then 模擬器參數顯示虧損總資產 -20.00 % 作為破產
	Then 模擬器參數顯示獲利總資產 50.00 % 作為退休
	Then 模擬器參數顯示起始總資產為 100000
	Then 模擬器參數顯示Risk增幅 0.2 %
	Then 模擬器顯示模擬 10000 次


@需求
Scenario: Calculate Optimization
	Given 我輸入Count vs R mutiple table :
	| Count | RMultiple |
	| 2 | 10       |
	| 1 | -5       |
	| 7 | -1       |
	Given 我設定每年交易 30 次
	Given 我設定模擬最大Risk 20.00 %
	Given 我設定虧損總資產 -20.00 % 作為破產
	Given 我設定獲利總資產 50.00 % 作為退休
	Given 我設定起始總資產為 100000
	Given 我設定Risk增幅 0.2 %
	Given 我設定模擬 10000 次
	When 我執行模擬最佳化
	Then Max Return Bet Size : 19.8% +- 2
	Then Med Return Bet Size : 1.8% +- 0.2
	Then Opt.Return Bet Size : 2.6% 
	Then <1% Ruin Bet Size : 0.4% +- 0.2
	Then Retire-Ruin Ruin Bet Size : 1.2%

