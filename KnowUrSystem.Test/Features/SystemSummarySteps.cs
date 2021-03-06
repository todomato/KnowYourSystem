﻿using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "SystemSummary")]
    public class SystemSummarySteps
    {
        private Simulator _target;
        private IDistributionCalulator _distributionCalulator;
        private IFinanceCalulator _financeCalulator;
        private IDrawdownCalculator _drawdownCalculator;

        [Given(@"我輸入Count vs R mutiple table :")]
        public void Given我輸入CountVsRMutipleTable(Table table)
        {
            var distributions = table.CreateSet<DistributionRawData>();
            ScenarioContext.Current.Set<IEnumerable<DistributionRawData>>(distributions);
        }

        [Given(@"set simulator")]
        public void GivenSetSimulator()
        {
            this._drawdownCalculator = new DrawdownCalculator();
            this._distributionCalulator = new DistributionCalulator();

            var distributions = ScenarioContext.Current.Get<IEnumerable<DistributionRawData>>();
            this._financeCalulator = new FinanceCalulator(distributions);

            _target = new Simulator(_financeCalulator, _drawdownCalculator, _distributionCalulator);
        }

        [Given(@"set simulation times are (.*)")]
        public void GivenSetSimulationTimesAre(int times)
        {
            _target.TimesOfSimulation = times;
        }

        [Given(@"set trades are (.*)")]
        public void GivenSetTradesAre(int trades)
        {
            _target.TradesPerYearly = trades;
        }

        [When(@"I simulate result")]
        public void WhenISimulateResult()
        {
            _target.Simulate();
        }


        [Then(@"win% should be (.*) \+- (.*) and STD should be (.*)")]
        public void ThenWinShouldBe_(decimal win, decimal about, decimal std)
        {
            var summary =_target.GetSimulateResult();
            if (Math.Abs(summary.WinRatio - win) <= about)
            {
                summary.WinRatio = win;
            }

            Assert.AreEqual(win, summary.WinRatio);
        }

        [Then(@"win/loss ratio should be (.*)")]
        public void ThenWinLossRatioShouldBe(decimal ratio)
        {
            var summary = _target.GetSimulateResult();
         
            Assert.AreEqual(ratio, summary.WinLossRatio);
        }


        [Then(@"expectancy should be (.*) \+- (.*) and STD should be (.*)")]
        public void ThenExpectancyShouldBe_(decimal expectancy, decimal about, decimal std)
        {
            var summary = _target.GetSimulateResult();
            if (Math.Abs(summary.Expectancy - expectancy) <= about)
            {
                summary.Expectancy = expectancy;
            }

            Assert.AreEqual(expectancy, summary.Expectancy);
        }

        [Then(@"lossing streaks should be (.*)")]
        public void ThenLossingStreaksShouldBe(int lossingStreaks)
        {
            var summary = _target.GetSimulateResult();

            Assert.AreEqual(lossingStreaks, summary.LossingStreaks);
        }

        [Then(@"drawdown R should be (.*) \+- (.*) and STD should be (.*)")]
        public void ThenDrawdownRShouldBe_(decimal dd, int about, decimal std)
        {
            var summary = _target.GetSimulateResult();
            if (Math.Abs(summary.AvgDrawdown - dd) <= about)
            {
                summary.AvgDrawdown = dd;
            }

            Assert.AreEqual(dd, summary.AvgDrawdown);
        }

        [Then(@"ending gain R should be (.*) \+- (.*) and STD should be (.*)")]
        public void ThenEndingGainRShouldBe_(decimal endingGain, int about, decimal std)
        {
            var summary = _target.GetSimulateResult();
            if (Math.Abs(summary.EndingGain - endingGain) <= about)
            {
                summary.EndingGain = endingGain;
            }

            Assert.AreEqual(endingGain, summary.EndingGain);
        }

        [Then(@"\#Trades for break even \((.*)%\) should be (.*) \+- (.*)")]
        public void ThenTradesForBreakEvenShouldBe(int confidence, int expect, int about)
        {
            var summary = _target.GetSimulateResult(confidence);
            if (Math.Abs(summary.BreakEvenTrades - expect) <= about)
            {
                summary.BreakEvenTrades = expect;
            }

            Assert.AreEqual(expect, summary.BreakEvenTrades);
        }

        [Then(@"(.*)% drawdown duraiton Months should be (.*) \+- (.*)")]
        public void ThenDrawdownDuraitonMonthsShouldBe(int ddM, decimal expect, decimal about)
        {
            var summary = _target.GetSimulateResult(ddM);
            var ddmonth = summary.BreakEvenTrades / (_target.TradesPerYearly / 12.0m);
            if (Math.Abs(ddmonth - expect) <= about)
            {
                ddmonth = expect;
            }

            Assert.AreEqual(expect, ddmonth);
        }

        [Then(@"yearly gain R should be (.*)")]
        public void ThenYearlyGainRShouldBe(decimal yearlyGain)
        {
            var summary = _target.GetSimulateResult();

            Assert.AreEqual(yearlyGain, summary.YearlyGain);
        }

        [Then(@"Avg yearly gain / avg drawdown should be (.*) \+- (.*)")]
        public void ThenAvgYearlyGainAvgDrawdownShouldBe_(decimal ratio, decimal about)
        {
            var summary = _target.GetSimulateResult();
            if (Math.Abs(summary.GainDrawdownRatio - ratio) <= about)
            {
                summary.GainDrawdownRatio = ratio;
            }

            Assert.AreEqual(ratio, summary.GainDrawdownRatio);
        }

        [Then(@"(.*) RMutiple's probability should be (.*)% \+- (.*)")]
        public void ThenRMutipleSProbabilityShouldBe_(decimal r, decimal probability, decimal about)
        {
            //取得所有模擬次數
            var runs = _target.Runs;
            var container = new List<Record>();
            foreach (var records in runs)
            {
                foreach (var record in records)
                {
                    container.Add(record);
                }
            }

            var data = container.Where(c => c.RMultiple == r).Count();
            var actual = (decimal)data / container.Count * 100;

            if (Math.Abs(probability - actual) <= about)
            {
                actual = probability;
            }

            Assert.AreEqual(probability, actual);
        }

    }
}