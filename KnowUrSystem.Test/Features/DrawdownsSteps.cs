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
    [Scope(Feature = "Drawdowns")]

    public class DrawdownsSteps
    {
        private Simulator _target;
        private IFinanceCalulator _financeCalulator;
        private IDrawdownCalculator _drawdownCalculator;

        [Given(@"set simulator")]
        public void GivenSetSimulator()
        {
            this._drawdownCalculator = new DrawdownCalculator();

            var distributions = ScenarioContext.Current.Get<IEnumerable<DistributionRawData>>();
            this._financeCalulator = new FinanceCalulator(distributions);

            _target = new Simulator(_financeCalulator, _drawdownCalculator);
        }


        [Given(@"set stub simulator")]
        public void GivenSetStubSimulator()
        {
            var ddStub = ScenarioContext.Current.Get<IDrawdownCalculator>();
            var distributions = ScenarioContext.Current.Get<IEnumerable<DistributionRawData>>();

            this._financeCalulator = new FinanceCalulator(distributions);
            _target = new Simulator(_financeCalulator, ddStub);
        }


        [Given(@"DrawdownCalculator is Stub")]
        public void GivenDrawdownCalculatorIsStub()
        {
            var stub = Substitute.For<IDrawdownCalculator>();
            ScenarioContext.Current.Set<IDrawdownCalculator>(stub);

        }

        [Given(@"DrawdownCalculator's MaxDD return (.*)")]
        public void GivenDrawdownCalculatorSMaxDDReturn(decimal maxDD)
        {
            var stub = ScenarioContext.Current.Get<IDrawdownCalculator>();
            stub.GetMaxDD(new List<List<Record>>()).ReturnsForAnyArgs(maxDD);
            ScenarioContext.Current.Set<IDrawdownCalculator>(stub);
        }


        [Given(@"我輸入Count vs R mutiple table :")]
        public void Given我輸入CountVsRMutipleTable(Table table)
        {
            var distributions = table.CreateSet<DistributionRawData>();
            ScenarioContext.Current.Set<IEnumerable<DistributionRawData>>(distributions);

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

        [Then(@"the MaxDD result should be (.*) about \+- (.*)")]
        public void ThenTheMaxDDresultShouldBe(decimal maxDD, decimal about)
        {
            var actual = this._target.GetMaxDD();
            if (Math.Abs(maxDD - actual) <= about)
            {
                actual = maxDD;
            }

            Assert.AreEqual(maxDD, actual);
        }


        [Then(@"the AvgDD result should be (.*) about \+- (.*)")]
        public void ThenTheAvgDDResultShouldBeAbout_(decimal avgDD, decimal about)
        {
            var actual = this._target.GetAvgDD();
            if (Math.Abs(avgDD - actual) <= about)
            {
                actual = avgDD;
            }

            Assert.AreEqual(avgDD, actual);
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

        [When(@"I calculate MaxDD")]
        public void WhenICalculateMaxDD()
        {
            var records = ScenarioContext.Current.Get<IEnumerable<Record>>();
            var result = this._drawdownCalculator.GetMaxDD(records);
            ScenarioContext.Current.Set<decimal>(result, "MaxDD");
        }

        [Then(@"the DrawdownCalculator's MaxDD should be (.*)")]
        public void ThenTheDrawdownCalculatorSMaxDDShouldBe(decimal maxDD)
        {
            var actual = ScenarioContext.Current.Get<decimal>("MaxDD");
            Assert.AreEqual(maxDD, actual);
        }

        [Then(@"the random R mutiple should less than (.*)")]
        public void ThenTheRandomRMutipleShouldLessThan(decimal num)
        {
            var actual = _target.Runs[0][0].RMultiple < num;
            Assert.AreEqual(true, actual);
        }

        [Then(@"the random R mutiple should greather than (.*)")]
        public void ThenTheRandomRMutipleShouldGreatherThan(decimal num)
        {
            var actual = _target.Runs[0][0].RMultiple > num;
            Assert.AreEqual(true, actual);
        }

    }
}
