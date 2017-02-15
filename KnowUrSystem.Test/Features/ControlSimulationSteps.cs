﻿using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using KnowUrSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnowUrSystem.Test.Features
{
    [Binding]
    [Scope(Feature = "ControlSimulation")]

    public class ControlSimulationSteps
    {
        private ISimulator target;

        [BeforeScenario]
        public void BeforeScenario()
        {
            this.target = new Simulator();
        }

        [Given(@"我設定每年交易 (.*) 次")]
        public void When我設定每年交易(int trades)
        {
            this.target.TradesPerYearly = trades;
        }

        [Given(@"我設定模擬 (.*) 次")]
        public void When我設定模擬次(int times)
        {
            this.target.TimesOfSimulation = times;
        }
        
        [Then(@"模擬器顯示每年交易 (.*) 次")]
        public void Then模擬器顯示每年交易次(int trades)
        {
            var actual = this.target.TradesPerYearly;
            Assert.AreEqual(trades, actual);
        }
        
        [Then(@"模擬器顯示模擬 (.*) 次")]
        public void Then模擬器顯示模擬次(int times)
        {
            var actual = this.target.TimesOfSimulation;
            Assert.AreEqual(times, actual);
        }

        [Given(@"我設定模擬最大Risk (.*) %")]
        public void Given我設定模擬最大Risk(double risk)
        {
            this.target.SettingMaxRisk = risk;
        }

        [Given(@"我設定虧損總資產 (.*) % 作為破產")]
        public void Given我設定虧損總資產作為破產(double ruin)
        {
            this.target.SettingRuin = ruin;
        }

        [Given(@"我設定獲利總資產 (.*) % 作為退休")]
        public void Given我設定獲利總資產作為退休(double retirement)
        {
            this.target.SettingRetirement = retirement;

        }

        [Given(@"我設定起始總資產為 (.*)")]
        public void Given我設定起始總資產為(int init)
        {
            this.target.SettingInitEquity = init;

        }

        [Given(@"我設定Risk增幅 (.*) %")]
        public void Given我設定Risk增幅(double size)
        {
            this.target.SettingIncrementSize = size;
        }

        [Then(@"模擬器顯示模擬最大Risk (.*) %")]
        public void Then模擬器顯示模擬最大Risk(double risk)
        {
            var actual = this.target.SettingMaxRisk;
            Assert.AreEqual(risk, actual);
        }

        [Then(@"模擬器顯示虧損總資產 (.*) % 作為破產")]
        public void Then模擬器顯示虧損總資產作為破產(double ruin)
        {
            var actual = this.target.SettingRuin;
            Assert.AreEqual(ruin, actual);
        }

        [Then(@"模擬器顯示獲利總資產 (.*) % 作為退休")]
        public void Then模擬器顯示獲利總資產作為退休(double retirement)
        {
            var actual = this.target.SettingRetirement;
            Assert.AreEqual(retirement, actual);
        }

        [Then(@"模擬器顯示起始總資產為 (.*)")]
        public void Then模擬器顯示起始總資產為(int init)
        {
            var actual = this.target.SettingInitEquity;
            Assert.AreEqual(init, actual);
        }

        [Then(@"模擬器顯示Risk增幅 (.*) %")]
        public void Then模擬器顯示Risk增幅(double size)
        {
            var actual = this.target.SettingIncrementSize;
            Assert.AreEqual(size, actual);
        }

    }
}
