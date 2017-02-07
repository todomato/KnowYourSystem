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
    [Scope(Feature = "LosingStreaks")]
    public class LosingStreaksSteps
    {
        private ISimulator _target;
        private FinanceCalulator _financeCalulator;

        [Given(@"simulator is Stub")]
        public void GivenSimulatorIsStub()
        {
            var stub = Substitute.For<ISimulator>();
            this._target = stub;
        }

        [Given(@"set simulation times are (.*)")]
        public void GivenSimulationTimesAre(int times)
        {
            _target.TimesOfSimulation = times;
        }
        [Given(@"我輸入Count vs R mutiple table :")]
        public void Given我輸入CountVsRMutipleTable(Table table)
        {
            var distributions = table.CreateSet<DistributionRawData>();
            this._financeCalulator = new FinanceCalulator(distributions);
            _target = new Simulator(_financeCalulator);
        }


        [Given(@"set trades are (.*)")]
        public void GivenTradesAre(int trades)
        {
            _target.TradesPerMonth = trades;
        }

        [When(@"I simulate result")]
        public void WhenISimulateResult()
        {
            _target.Simulate();
        }

        [Then(@"the Max Consecutive Losses result should be (.*)")]
        public void ThenTheMaxCLResultShouldBe(int number)
        {
            var actual = _target.MaxNumOfConsecutiveLosses;
            Assert.AreEqual(number, actual);
        }

        [Then(@"the Avg Consecutive Losses result should be (.*)")]
        public void ThenTheAvgCLResultShouldBe(int number)
        {
            var actual = _target.AvgNumOfConsecutiveLosses;
            Assert.AreEqual(number, actual);
        }

        [Given(@"simulator's Avg Consecutive Losses return (.*)")]
        public void GivenSimulatorSAvgConsecutiveLossesReturn(int number)
        {
            _target.AvgNumOfConsecutiveLosses.Returns(number);
        }

        [Given(@"simulator's Max Consecutive Losses return (.*)")]
        public void GivenSimulatorSMaxConsecutiveLossesReturn(int number)
        {
            _target.MaxNumOfConsecutiveLosses.Returns(number);
        }

        [Then(@"the records result should be (.*)")]
        public void ThenTheRecordsResultShouldBe(int number)
        {
            var actual = _target.Runs.Sum(x => x.Count);
            Assert.AreEqual(number, actual);
        }

        [Given(@"我輸入records table :")]
        public void Given我輸入RecordsTable(Table table)
        {
            var records = table.CreateSet<Record>();
            ScenarioContext.Current.Set<List<Record>>(records.ToList());
            _target = new Simulator();

        }

        [When(@"I Calculate Consecutive Losses")]
        public void WhenICalculateConsecutiveLosses()
        {
            var records = ScenarioContext.Current.Get<List<Record>>();
            var cls = _target.CalculateConsecutiveLosses(records);

            ScenarioContext.Current.Set<List<int>>(cls, "cls");
        }

        [Then(@"the Consecutive Losses should be '(.*)'")]
        public void ThenTheConsecutiveLossesShouldBe(string str)
        {
            var expect = str.Split(',').Select(c => int.Parse(c)).ToList();
            var actual = ScenarioContext.Current.Get<List<int>>("cls");
            expect.ToExpectedObject().ShouldEqual(actual);
        }

        [Then(@"total records should be (.*)")]
        public void ThenTotalRecordsShouldBe(int number)
        {
            var actual = _target.Runs.Sum(x => x.Count);
            Assert.AreEqual(number, actual);
        }


    }
}