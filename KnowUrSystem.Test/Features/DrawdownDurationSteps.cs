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

            var distributions = ScenarioContext.Current.Get<IEnumerable<DistributionRawData>>();
            this._financeCalulator = new FinanceCalulator(distributions);

            _target = new Simulator(_financeCalulator, _drawdownCalculator);
        }

        [Given(@"set simulation times are (.*)")]
        public void GivenSetSimulationTimesAre(int times)
        {
            _target.TimesOfSimulation = times;
        }

        [Given(@"set trades are (.*)")]
        public void GivenSetTradesAre(int trades)
        {
            _target.TradesPerMonth = trades;

        }

        [When(@"I simulate result")]
        public void WhenISimulateResult()
        {
            _target.Simulate();
        }


        [Then(@"the (.*)% >= Equity Peak's result should be (.*)")]
        public void ThenTheEquityPeakSResultShouldBe(int confidence, int number)
        {
            var actual = _target.GetNumberThroughNewPeak(confidence);
            Assert.AreEqual(number, actual);
        }

        [Given(@"我輸入R-mutiple Record table :")]
        public void Given我輸入R_MutipleRecordTable(Table table)
        {
            var records = table.CreateSet<Record>();
            ScenarioContext.Current.Set<IEnumerable<Record>>(records);
        }

        [Given(@"set DrawdownCalculator")]
        public void GivenSetDrawdownCalculator()
        {
            this._drawdownCalculator = new DrawdownCalculator();
        }

        [When(@"I calculate CalculteCumulativeRmutiple")]
        public void WhenICalculteCumulativeRmutiple()
        {
            var records = ScenarioContext.Current.Get<IEnumerable<Record>>();
            var result = this._drawdownCalculator.CalculteCumulativeRmutiple(records.ToList());
            ScenarioContext.Current.Set<List<double>>(result, "tradeResult");
        }

        [Then(@"the CalculteCumulativeRmutiple's No.(.*) result should be (.*)")]
        public void ThenTheCalculteCumulativeRmutipleResultShouldBe(int trade, double prob)
        {
            var actual = ScenarioContext.Current.Get<List<double>>("tradeResult")[trade - 1];
            Assert.AreEqual(prob, actual);
        }

    }
}
