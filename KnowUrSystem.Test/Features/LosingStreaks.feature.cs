﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace KnowUrSystem.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class LosingStreaksFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LosingStreaks.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LosingStreaks", "In order to show reslut", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "LosingStreaks")))
            {
                KnowUrSystem.Test.Features.LosingStreaksFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Avg Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void SimulateAvgNumberOfConsecutiveLosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Avg Number Of Consecutive Losses", new string[] {
                        "需求"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("simulator is Stub", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("set simulation times are 2500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("simulator\'s Avg Consecutive Losses return 16", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the Avg Consecutive Losses result should be 16", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Max Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void SimulateMaxNumberOfConsecutiveLosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Max Number Of Consecutive Losses", new string[] {
                        "需求"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("simulator is Stub", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.And("set simulation times are 2500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("simulator\'s Max Consecutive Losses return 52", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("the Max Consecutive Losses result should be 52", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses(string count, string r, string times, string trades, string max, string avg, string records, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "整合"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Then Get Max And Avg  Number Of Consecutive Losses", @__tags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table1.AddRow(new string[] {
                        string.Format("{0}", count),
                        string.Format("{0}", r)});
#line 26
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table1, "Given ");
#line 29
 testRunner.And(string.Format("set simulation times are {0}", times), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And(string.Format("set trades are {0}", trades), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then(string.Format("the Max Consecutive Losses result should be {0}", max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then(string.Format("the Avg Consecutive Losses result should be {0}", avg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.Then(string.Format("total records should be {0}", records), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max And Avg  Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:avg", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "120")]
        public virtual void SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses_Variant0()
        {
            this.SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses("10", "1", "1", "120", "0", "0", "120", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max And Avg  Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:avg", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "120")]
        public virtual void SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses_Variant1()
        {
            this.SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses("10", "-1", "1", "120", "120", "120", "120", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max And Avg  Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:avg", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "240")]
        public virtual void SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses_Variant2()
        {
            this.SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses("10", "1", "2", "120", "0", "0", "240", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max And Avg  Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:avg", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "240")]
        public virtual void SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses_Variant3()
        {
            this.SimulateThenGetMaxAndAvgNumberOfConsecutiveLosses("10", "-1", "2", "120", "120", "120", "240", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 1 Run And Get Avg Number Of Consecutive Losses With Win Ratio 100% Shoul" +
            "d Be 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        public virtual void Simulate1RunAndGetAvgNumberOfConsecutiveLossesWithWinRatio100ShouldBe0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 1 Run And Get Avg Number Of Consecutive Losses With Win Ratio 100% Shoul" +
                    "d Be 0", new string[] {
                        "整合"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table2.AddRow(new string[] {
                        "10",
                        "1"});
#line 44
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table2, "Given ");
#line 47
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the Avg Consecutive Losses result should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 2 Run 120 Times Then Total Records Are 240")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        public virtual void Simulate2Run120TimesThenTotalRecordsAre240()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 2 Run 120 Times Then Total Records Are 240", new string[] {
                        "整合"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table3.AddRow(new string[] {
                        "10",
                        "-1"});
#line 54
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table3, "Given ");
#line 57
 testRunner.And("set simulation times are 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("total records should be 240", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("驗證模擬的記錄筆數")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("unit")]
        public virtual void 驗證模擬的記錄筆數()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("驗證模擬的記錄筆數", new string[] {
                        "unit"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table4.AddRow(new string[] {
                        "10",
                        "-1"});
#line 64
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table4, "Given ");
#line 67
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("the records result should be 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("計算連續虧損次數")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("unit")]
        public virtual void 計算連續虧損次數()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("計算連續虧損次數", new string[] {
                        "unit"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "IsWinMoney"});
            table5.AddRow(new string[] {
                        "true"});
            table5.AddRow(new string[] {
                        "false"});
            table5.AddRow(new string[] {
                        "false"});
            table5.AddRow(new string[] {
                        "true"});
            table5.AddRow(new string[] {
                        "true"});
            table5.AddRow(new string[] {
                        "false"});
            table5.AddRow(new string[] {
                        "false"});
            table5.AddRow(new string[] {
                        "false"});
#line 74
 testRunner.Given("我輸入records table :", ((string)(null)), table5, "Given ");
#line 84
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("the Consecutive Losses should be \'2,3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("計算連續虧損次數2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("unit")]
        public virtual void 計算連續虧損次數2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("計算連續虧損次數2", new string[] {
                        "unit"});
#line 88
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "IsWinMoney"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
            table6.AddRow(new string[] {
                        "false"});
#line 89
 testRunner.Given("我輸入records table :", ((string)(null)), table6, "Given ");
#line 99
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("the Consecutive Losses should be \'8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion