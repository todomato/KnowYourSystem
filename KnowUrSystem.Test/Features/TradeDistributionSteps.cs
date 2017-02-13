﻿using KnowUrSystem.Model;
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
        private IFinanceCalulator target;

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
            var expectancy = this.target.GetExpectancy();
            ScenarioContext.Current.Set<double>(expectancy, "expectancy");

        }

        [When(@"我計算 Standard Deviation")]
        public void When我計算StandardDeviation()
        {
            var std = this.target.GetStandardDeviation();
            ScenarioContext.Current.Set<double>(std, "std");

        }

        [When(@"我計算 Win Rate")]
        public void When我計算WinRate()
        {
            var winRate = this.target.GetWinRate();
            ScenarioContext.Current.Set<double>(winRate, "winRate");
        }

        [When(@"我計算 Avg Win/Loss Ratio")]
        public void When我計算WinLossRatio()
        {
            var winLossRatio = this.target.GetWinLossRatio();
            ScenarioContext.Current.Set<double>(winLossRatio, "winLossRatio");
        }

        [When(@"我計算 \#Trades")]
        public void When我計算Trades()
        {
            var trades = this.target.GetTrades();
            ScenarioContext.Current.Set<int>(trades, "trades");
        }

        [Then(@"Expectancy is (.*)")]
        public void ThenExpectancyIs(double expectancy)
        {
            var actual = ScenarioContext.Current.Get<double>("expectancy");
            Assert.AreEqual(expectancy, actual);
        }

        [Then(@"Standard Deviation is (.*)")]
        public void ThenStandardDeviationIs(double std)
        {
            var actual = ScenarioContext.Current.Get<double>("std");
            Assert.AreEqual(std, actual);
        }

        [Then(@"Win% is (.*)")]
        public void ThenWinIs(double winRate)
        {
            var actual = ScenarioContext.Current.Get<double>("winRate");
            Assert.AreEqual(winRate, actual);
        }

        [Then(@"Avg Win/Loss Ratio is (.*)")]
        public void ThenWinLossRatioIs(double winlossRatio)
        {
            var actual = ScenarioContext.Current.Get<double>("winLossRatio");
            Assert.AreEqual(winlossRatio, actual);
        }

        [Then(@"\#Trades is (.*)")]
        public void ThenTradesIs(int trades)
        {
            var actual = ScenarioContext.Current.Get<int>("trades");
            Assert.AreEqual(trades, actual);
        }

        [Then(@"SQN is (.*)")]
        public void ThenSQNIs(double sqn)
        {
            var actual = ScenarioContext.Current.Get<double>("sqn");
            actual = Math.Round(actual, 2);
            Assert.AreEqual(sqn, actual);
        }

        [When(@"我計算 SQN")]
        public void When我計算SQN()
        {
            var trades = this.target.GetSQN();
            ScenarioContext.Current.Set<double>(trades, "sqn");
        }


    }
}