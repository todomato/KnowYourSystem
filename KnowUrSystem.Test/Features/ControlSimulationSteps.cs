using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using KnowUrSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnowUrSystem.Model;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "ControlSimulation")]

    public class ControlSimulationSteps
    {
        private ISimulator _target;
       

        [BeforeScenario]
        public void BeforeScenario()
        {
            this._target = new Simulator();
        }

        [Given(@"我設定每年交易 (.*) 次")]
        public void When我設定每年交易(int trades)
        {
            this._target.TradesPerYearly = trades;
        }

        [Given(@"我設定模擬 (.*) 次")]
        public void When我設定模擬次(int times)
        {
            this._target.TimesOfSimulation = times;
        }
        
        [Then(@"模擬器顯示每年交易 (.*) 次")]
        public void Then模擬器顯示每年交易次(int trades)
        {
            var actual = this._target.TradesPerYearly;
            Assert.AreEqual(trades, actual);
        }
        
        [Then(@"模擬器顯示模擬 (.*) 次")]
        public void Then模擬器顯示模擬次(int times)
        {
            var actual = this._target.TimesOfSimulation;
            Assert.AreEqual(times, actual);
        }


    }
}
