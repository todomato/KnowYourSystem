using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "TradeDistribution")]
    public class TradeDistributionSteps
    {
        private FinanceCalulator target;

        [Given(@"我輸入Count vs R mutiple table :")]
        public void Given我輸入CountVsRMutipleTable(Table table)
        {
            var distributions = table.CreateSet<DistributionRawData>();
            this.target = new FinanceCalulator(distributions);
            //ScenarioContext.Current.Set<IEnumerable<SettingDistribution>>(distributions);
        }

        [When(@"我計算 Expectancy")]
        public void When我計算Expectancy()
        {
            this.target.CalculateExpectancy();
        }

        [When(@"我計算 Standard Deviation")]
        public void When我計算StandardDeviation()
        {
            this.target.CalculateStandardDeviation();
        }

        [When(@"我計算 Win Rate")]
        public void When我計算WinRate()
        {
            this.target.CalculateWinRate();
        }

        [When(@"我計算 Avg Win/Loss Ratio")]
        public void When我計算WinLossRatio()
        {
            this.target.CalculateWinLossRatio();
        }

        [When(@"我計算 \#Trades")]
        public void When我計算Trades()
        {
            this.target.CalculateTrades();
        }

        [Then(@"Expectancy is (.*)")]
        public void ThenExpectancyIs(Decimal expectancy)
        {
            var actual = this.target.Expectancy;
            Assert.AreEqual(expectancy, actual);
        }

        [Then(@"Standard Deviation is (.*)")]
        public void ThenStandardDeviationIs(Decimal std)
        {
            var actual = this.target.StandardDeviation;
            Assert.AreEqual(std, actual);
        }

        [Then(@"Win% is (.*)")]
        public void ThenWinIs(Decimal winRate)
        {
            var actual = this.target.WinRate;
            Assert.AreEqual(winRate, actual);
        }

        [Then(@"Avg Win/Loss Ratio is (.*)")]
        public void ThenWinLossRatioIs(Decimal winlossRatio)
        {
            var actual = this.target.WinLossRatio;
            Assert.AreEqual(winlossRatio, actual);
        }

        [Then(@"\#Trades is (.*)")]
        public void ThenTradesIs(int trades)
        {
            var actual = this.target.Trades;
            Assert.AreEqual(trades, actual);
        }
    }
}