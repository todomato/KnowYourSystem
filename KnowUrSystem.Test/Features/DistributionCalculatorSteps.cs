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
    public class DistributionCalculatorSteps
    {
        private IDistributionCalulator _target;
        private Simulator simulator;
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
            var times = ScenarioContext.Current.Get<int>("times");
            var trades = ScenarioContext.Current.Get<int>("trades");
            simulator = new Simulator(_financeCalulator, _drawdownCalculator);
            simulator.TimesOfSimulation = times;
            simulator.TradesPerMonth = trades;

            _target = new DistributionCalulator(times, trades);

        }

        [Given(@"set simulation times are (.*)")]
        public void GivenSetSimulationTimesAre(int times)
        {
            ScenarioContext.Current.Set<int>(times,"times");

        }

        [Given(@"set trades are (.*)")]
        public void GivenSetTradesAre(int trades)
        {
            ScenarioContext.Current.Set<int>(trades,"trades");
        }

        [Given(@"set playtime are (.*)")]
        public void GivenSetPlaytimeAre(int playtimes)
        {
            ScenarioContext.Current.Set<int>(playtimes, "playtimes");
        }

        [When(@"I CalculateDistributionProbability")]
        public void WhenISimulateResult()
        {
            simulator.Simulate();
            var result = _target.CalculateLossDistributionProbability(simulator.Runs);
            ScenarioContext.Current.Set<List<double>>(result, "result");

        }


        [Then(@"the lose equity result should be (.*)% about \+- (.*)")]
        public void ThenTheLoseEquityResultShouldBeAbout_(double expect, double about)
        {
            var data = ScenarioContext.Current.Get<List<double>>("result");
            var playtime = ScenarioContext.Current.Get<int>("playtimes");
            var actual = data[playtime - 1];
            if (Math.Abs(actual - expect / 100) <= about)
            {
                actual = expect;
            }

            Assert.AreEqual(expect, actual);
        }

        [Given(@"set calculator")]
        public void GivenSetCalculator()
        {
            _target = new DistributionCalulator();
        }


        [When(@"I CalculateFakeDistributionProbability")]
        public void WhenICalculateCoinDistributionProbability()
        {
            var records = ScenarioContext.Current.Get<List<List<Record>>>();
            var result = _target.CalculateLossDistributionProbability(records);
            ScenarioContext.Current.Set<List<double>>(result, "result");
        }

        [Given(@"我輸入fake records table")]
        public void Given我輸入FakeRecordsTable(Table table)
        {
             var records = table.CreateSet<Record>();
             var query = records.GroupBy(x => x.Run).ToList();

             var runs = new List<List<Record>>();
             foreach (var item in query)
             {
                 runs.Add(item.ToList());
             }
             ScenarioContext.Current.Set<List<List<Record>>>(runs);
        }

      

    }
}
