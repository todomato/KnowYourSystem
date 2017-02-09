using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "Expectancy")]
    public class ExpectancySteps
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

        [Then(@"the Max Expectancy result should be (.*) about \+- (.*)")]
        public void ThenTheMaxExpectancyResultShouldBeAbout_(double num, double about)
        {
            var actual = _target.GetMaxExpectancy();
            if (actual - num < about)
            {
                actual = num;
            }

            Assert.AreEqual(num, actual);
        }

        [Then(@"the Avg Expectancy result should be (.*) about \+- (.*)")]
        public void ThenTheAvgExpectancyResultShouldBeAbout_(double num, double about)
        {
            var actual = _target.GetAvgExpectancy();
            if (actual - num < about)
            {
                actual = num;
            }

            Assert.AreEqual(num, actual);
        }

        [Then(@"the (.*)% can get Expectancy result should be (.*) about \+- (.*)")]
        public void ThenTheCanGetExpectancyResultShouldBeAbout_(double probability, double num, double about)
        {
            var actual = _target.GetExpectancy(probability);
            if (actual - num < about)
            {
                actual = num;
            }

            Assert.AreEqual(num, actual);
        }

    }
}