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
        private IFinanceCalulator _financeCalulator;

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

        [Then(@"the (.*) Probability Of Number Of Consecutive Losses result should greater than (.*)")]
        public void ThenTheProbabilityOfNumberOfConsecutiveLossesResultShouldGreaterThan(int probability, int number)
        {
            ScenarioContext.Current.Pending();

            var actual = _target.ProbabilityConsecutiveLossesList;
            Assert.AreEqual(number, actual);
        }

        [Then(@"the (.*) Probability Of Number Of Consecutive Losses result should less than (.*)")]
        public void ThenTheProbabilityOfNumberOfConsecutiveLossesResultShouldLessThan(int probability, int number)
        {
            ScenarioContext.Current.Pending();

            var actual = _target.ProbabilityConsecutiveLossesList;
            Assert.AreEqual(number, actual);
        }



        [Then(@"the Max Consecutive Losses result should be (.*)")]
        public void ThenTheMaxCLResultShouldBe(int number)
        {
            var actual = _target.MaxNumOfConsecutiveLosses;
            Assert.AreEqual(number, actual);
        }

        [Then(@"the Max Consecutive Losses result should greater than (.*)")]
        public void ThenTheMaxConsecutiveLossesResultShouldGreaterThan(int number)
        {
            var max = _target.MaxNumOfConsecutiveLosses;
            var actual = number < max;
            Assert.AreEqual(true, actual);
        }

        [Then(@"the Max Consecutive Losses result should less than (.*)")]
        public void ThenTheMaxConsecutiveLossesResultShouldLessThan(int number)
        {
            var max = _target.MaxNumOfConsecutiveLosses;
            var actual = number > max;
            Assert.AreEqual(true, actual);
        }

        [Then(@"the Avg Consecutive Losses result should greater than (.*)")]
        public void ThenTheAvgConsecutiveLossesResultShouldGreaterThan(int number)
        {
            var avg = _target.AvgNumWeMeetConsecutiveLosses;
            var actual = number < avg;
            Assert.AreEqual(true, actual);
        }

        [Then(@"the Avg Consecutive Losses result should less than (.*)")]
        public void ThenTheAvgConsecutiveLossesResultShouldLessThan(int number)
        {
            var avg = _target.AvgNumWeMeetConsecutiveLosses;
            var actual = number > avg;
            Assert.AreEqual(true, actual);
        }


        [Then(@"the Avg Consecutive Losses result should be (.*)")]
        public void ThenTheAvgCLResultShouldBe(int number)
        {
            var actual = _target.AvgNumWeMeetConsecutiveLosses;
            Assert.AreEqual(number, actual);
        }

        [Then(@"the Probability\(%\) Consecutive Losses List")]
        public void ThenTheProbabilityConsecutiveLossesList()
        {
            var expect = 100.0;
            var actual = _target.CumulativeProbabilityConsecutiveLossesList;
            Assert.AreEqual(expect, actual[0]);
        }


        [Given(@"simulator's Avg Consecutive Losses return (.*)")]
        public void GivenSimulatorSAvgConsecutiveLossesReturn(int number)
        {
            _target.AvgNumWeMeetConsecutiveLosses.Returns(number);
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

        [When(@"I Calculate Avg Consecutive Losses")]
        public void WhenICalculateAvgConsecutiveLosses()
        {
            var records = ScenarioContext.Current.Get<List<Record>>();
            _target.Runs = new List<List<Record>>() { records };

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