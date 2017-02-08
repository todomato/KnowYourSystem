using System;
using System.Collections.Generic;
using System.Linq;

using KnowUrSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ExpectedObjects;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    public class DrawdownsSteps
    {
        private Simulator _target;
        private FinanceCalulator _financeCalulator;

        [Given(@"set stub simulator")]
        public void GivenSetSimulator()
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
        public void GivenDrawdownCalculatorSMaxDDReturn(double maxDD)
        {
            var stub = ScenarioContext.Current.Get<IDrawdownCalculator>();
            stub.GetMaxDD().Returns(maxDD);
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
            _target.TradesPerMonth = trades;
        }

        [When(@"I simulate result")]
        public void WhenISimulateResult()
        {
            _target.Simulate();
        }

        [Then(@"the MaxDDresult should be (.*)")]
        public void ThenTheMaxDDresultShouldBe(double maxDD)
        {
            var actual = _target.GetMaxDD();
            Assert.AreEqual(maxDD, actual);
        }
    }
}
