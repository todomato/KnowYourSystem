using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    public class OptimizerSteps
    {
        private ISimulator _target;
        private IFinanceCalulator _financeCalulator;
        private OptParams _param;

        [BeforeScenario]
        public void BeforeScenario()
        {
            this._target = new Simulator();
            this._param = new OptParams();
        }

        [Given(@"我輸入Count vs R mutiple table :")]
        public void Given我輸入CountVsRMutipleTable(Table table)
        {
            var distributions = table.CreateSet<DistributionRawData>();
            this._financeCalulator = new FinanceCalulator(distributions);
            _target = new Simulator(_financeCalulator);
        }

        [Given(@"我設定每年交易 (.*) 次")]
        public void When我設定每年交易(int trades)
        {
            this._target.TradesPerYearly = trades;
        }

        [Given(@"我設定模擬 (.*) 次")]
        public void When我設定模擬次(int times)
        {
            this._target.TimesOfSimulation = times;
        }

        [Then(@"模擬器顯示每年交易 (.*) 次")]
        public void Then模擬器顯示每年交易次(int trades)
        {
            var actual = this._target.TradesPerYearly;
            Assert.AreEqual(trades, actual);
        }

        [Then(@"模擬器顯示模擬 (.*) 次")]
        public void Then模擬器顯示模擬次(int times)
        {
            var actual = this._target.TimesOfSimulation;
            Assert.AreEqual(times, actual);
        }

        [Given(@"我設定模擬最大Risk (.*) %")]
        public void Given我設定模擬最大Risk(decimal risk)
        {
            this._param.MaxRisk = risk;
        }

        [Given(@"我設定虧損總資產 (.*) % 作為破產")]
        public void Given我設定虧損總資產作為破產(decimal ruin)
        {
            this._param.Ruin = ruin;
        }

        [Given(@"我設定獲利總資產 (.*) % 作為退休")]
        public void Given我設定獲利總資產作為退休(decimal retirement)
        {
            this._param.Retirement = retirement;
        }

        [Given(@"我設定起始總資產為 (.*)")]
        public void Given我設定起始總資產為(int init)
        {
            this._param.InitEquity = init;
        }

        [Given(@"我設定Risk增幅 (.*) %")]
        public void Given我設定Risk增幅(decimal size)
        {
            this._param.IncrementSize = size;
        }

        [When(@"我執行模擬最佳化")]
        public void When我執行模擬最佳化()
        {
            OptReport report = this._target.SimulateOpt(_param);
            ScenarioContext.Current.Set<OptReport>(report);
        }

        [Then(@"模擬器參數顯示模擬最大Risk (.*) %")]
        public void Then模擬器顯示模擬最大Risk(decimal risk)
        {
            var actual = this._param.MaxRisk;
            Assert.AreEqual(risk, actual);
        }

        [Then(@"模擬器參數顯示虧損總資產 (.*) % 作為破產")]
        public void Then模擬器顯示虧損總資產作為破產(decimal ruin)
        {
            var actual = this._param.Ruin;
            Assert.AreEqual(ruin, actual);
        }

        [Then(@"模擬器參數顯示獲利總資產 (.*) % 作為退休")]
        public void Then模擬器顯示獲利總資產作為退休(decimal retirement)
        {
            var actual = this._param.Retirement;
            Assert.AreEqual(retirement, actual);
        }

        [Then(@"模擬器參數顯示起始總資產為 (.*)")]
        public void Then模擬器顯示起始總資產為(int init)
        {
            var actual = this._param.InitEquity;
            Assert.AreEqual(init, actual);
        }

        [Then(@"模擬器參數顯示Risk增幅 (.*) %")]
        public void Then模擬器顯示Risk增幅(decimal size)
        {
            var actual = this._param.IncrementSize;
            Assert.AreEqual(size, actual);
        }

        [Then(@"Max Return Bet Size : (.*)% \+- (.*)")]
        public void ThenMaxReturnBetSize(decimal bet, decimal about)
        {
            var report = ScenarioContext.Current.Get<OptReport>();
            var actual = report.MaxReturn.BetSize;

            if (Math.Abs(actual - bet) <= about)
            {
                actual = bet;
            }

            Assert.AreEqual(bet, actual);
        }

        [Then(@"Med Return Bet Size : (.*)% \+- (.*)")]
        public void ThenMedReturnBetSize(decimal bet, decimal about)
        {
            var report = ScenarioContext.Current.Get<OptReport>();
            var actual = report.MedReturn.BetSize;

            if (Math.Abs(actual - bet) <= about)
            {
                actual = bet;
            }
            Assert.AreEqual(bet, actual);
        }

        [Then(@"Opt\.Return Bet Size : (.*)%")]
        public void ThenOpt_ReturnBetSize(decimal bet)
        {
            var report = ScenarioContext.Current.Get<OptReport>();
            var actual = report.OptReturn.BetSize;
            Assert.AreEqual(bet, actual);
        }

        [Then(@"<1% Ruin Bet Size : (.*)% \+- (.*)")]
        public void ThenRuinBetSize(decimal bet, decimal about)
        {
            var report = ScenarioContext.Current.Get<OptReport>();
            var actual = report.LessOneRuin.BetSize;

            if (Math.Abs(actual - bet) <= about)
            {
                actual = bet;
            }
            Assert.AreEqual(bet, actual);
        }

        [Then(@"Retire-Ruin Ruin Bet Size : (.*)%")]
        public void ThenRetire_RuinRuinBetSize(decimal bet)
        {
            var report = ScenarioContext.Current.Get<OptReport>();
            var actual = report.BestRetireRuinRatio.BetSize;
            Assert.AreEqual(bet, actual);
        }

     
    }
}