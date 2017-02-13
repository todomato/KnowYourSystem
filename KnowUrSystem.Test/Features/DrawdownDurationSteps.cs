using System;
using System.Collections.Generic;
using System.Linq;

using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ExpectedObjects;
using KnowUrSystem;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "DrawdownDuration")]

    public class DrawdownDurationSteps
    {
        private Simulator _target;
        private IFinanceCalulator _financeCalulator;
        private IDrawdownCalculator _drawdownCalculator;
        private IDistributionCalulator _distributionCalulator;

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


        [Then(@"the (.*)% >= Equity Peak's result should be (.*) about \+- (.*)")]
        public void ThenTheEquityPeakSResultShouldBe(double prob, int trades, int about)
        {
            var actual = _target.GetNumberOfTradesForConfidence(prob);
            if (Math.Abs(trades - actual) <= about)
            {
                actual = trades;
            }

            Assert.AreEqual(trades, actual);
        }

    }
}
