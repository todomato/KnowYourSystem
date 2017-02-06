using System;
using TechTalk.SpecFlow;
using KnowUrSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    public class ControlSimulationSteps
    {
        private Simulator target;

        [BeforeScenario]
        public void BeforeScenario()
        {
            this.target = new Simulator();
        }

        [Given(@"我設定每月交易 (.*) 次")]
        public void When我設定每月交易次(int trades)
        {
            this.target.TradesPerMonth = trades;
        }

        [Given(@"我設定模擬 (.*) 次")]
        public void When我設定模擬次(int times)
        {
            this.target.TimesOfSimulation = times;
        }
        
        [Then(@"模擬器顯示每月交易 (.*) 次")]
        public void Then模擬器顯示每月交易次(int trades)
        {
            var actual = this.target.TradesPerMonth;
            Assert.AreEqual(trades, actual);
        }
        
        [Then(@"模擬器顯示模擬 (.*) 次")]
        public void Then模擬器顯示模擬次(int times)
        {
            var actual = this.target.TimesOfSimulation;
            Assert.AreEqual(times, actual);
        }
    }
}
