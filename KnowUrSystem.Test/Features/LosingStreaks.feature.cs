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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 1 Run And Get Avg Number Of Consecutive Losses With Win Ratio 100% Shoul" +
            "d Be 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        public virtual void Simulate1RunAndGetAvgNumberOfConsecutiveLossesWithWinRatio100ShouldBe0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 1 Run And Get Avg Number Of Consecutive Losses With Win Ratio 100% Shoul" +
                    "d Be 0", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table1.AddRow(new string[] {
                        "10",
                        "1"});
#line 24
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table1, "Given ");
#line 27
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("the Avg Consecutive Losses result should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 1 Run And Get Max Number Of Consecutive Losses With Win Ratio 0% Should " +
            "Be 120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        public virtual void Simulate1RunAndGetMaxNumberOfConsecutiveLossesWithWinRatio0ShouldBe120()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 1 Run And Get Max Number Of Consecutive Losses With Win Ratio 0% Should " +
                    "Be 120", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table2.AddRow(new string[] {
                        "10",
                        "-1"});
#line 33
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table2, "Given ");
#line 36
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the Max Consecutive Losses result should be 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 2 Run 120 Times Then Total Records Are 240")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        public virtual void Simulate2Run120TimesThenTotalRecordsAre240()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 2 Run 120 Times Then Total Records Are 240", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table3.AddRow(new string[] {
                        "10",
                        "-1"});
#line 42
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table3, "Given ");
#line 45
 testRunner.And("set simulation times are 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
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
#line 51
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table4.AddRow(new string[] {
                        "10",
                        "-1"});
#line 52
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table4, "Given ");
#line 55
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
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
#line 61
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
#line 62
 testRunner.Given("我輸入records table :", ((string)(null)), table5, "Given ");
#line 72
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
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
#line 76
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
#line 77
 testRunner.Given("我輸入records table :", ((string)(null)), table6, "Given ");
#line 87
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("the Consecutive Losses should be \'8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
