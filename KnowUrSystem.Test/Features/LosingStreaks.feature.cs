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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Avg Number We Meet Cumulative Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void SimulateAvgNumberWeMeetCumulativeConsecutiveLosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Avg Number We Meet Cumulative Consecutive Losses", new string[] {
                        "需求"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table1.AddRow(new string[] {
                        "2",
                        "10"});
            table1.AddRow(new string[] {
                        "1",
                        "-5"});
            table1.AddRow(new string[] {
                        "7",
                        "-1"});
#line 6
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table1, "Given ");
#line 11
 testRunner.And("set simulation times are 10000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the Avg Consecutive Losses result should be 16", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Then("the Avg Consecutive Losses result should greater than 14", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.Then("the Avg Consecutive Losses result should less than 17", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 19
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table2.AddRow(new string[] {
                        "2",
                        "10"});
            table2.AddRow(new string[] {
                        "1",
                        "-5"});
            table2.AddRow(new string[] {
                        "7",
                        "-1"});
#line 20
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table2, "Given ");
#line 25
 testRunner.And("set simulation times are 10000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the Max Consecutive Losses result should greater than 40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("the Max Consecutive Losses result should less than 80", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("(Pending)Simulate Some Probability Of Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void PendingSimulateSomeProbabilityOfNumberOfConsecutiveLosses()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("(Pending)Simulate Some Probability Of Number Of Consecutive Losses", new string[] {
                        "需求"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table3.AddRow(new string[] {
                        "2",
                        "10"});
            table3.AddRow(new string[] {
                        "1",
                        "-5"});
            table3.AddRow(new string[] {
                        "7",
                        "-1"});
#line 34
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table3, "Given ");
#line 39
 testRunner.And("set simulation times are 10000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("the 50 Probability Of Number Of Consecutive Losses result should greater than 40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.Then("the 50 Probability Of Number Of Consecutive Losses result should less than 40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Probability(%) Consecutive Losses List")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void SimulateProbabilityConsecutiveLossesList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Probability(%) Consecutive Losses List", new string[] {
                        "需求"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table4.AddRow(new string[] {
                        "2",
                        "10"});
            table4.AddRow(new string[] {
                        "1",
                        "-5"});
            table4.AddRow(new string[] {
                        "7",
                        "-1"});
#line 48
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table4, "Given ");
#line 53
 testRunner.And("set simulation times are 10000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
 testRunner.Then("the Probability(%) Consecutive Losses List", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Max Number Of Consecutive Losses Stub")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("需求")]
        public virtual void SimulateMaxNumberOfConsecutiveLossesStub()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Max Number Of Consecutive Losses Stub", new string[] {
                        "需求"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
 testRunner.Given("simulator is Stub", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.And("set simulation times are 2500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("simulator\'s Max Consecutive Losses return 52", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("the Max Consecutive Losses result should be 52", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SimulateThenGetMaxNumberOfConsecutiveLosses(string count, string r, string times, string trades, string max, string records, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "整合"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate Then Get Max Number Of Consecutive Losses", @__tags);
#line 69
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table5.AddRow(new string[] {
                        string.Format("{0}", count),
                        string.Format("{0}", r)});
#line 70
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table5, "Given ");
#line 73
 testRunner.And(string.Format("set simulation times are {0}", times), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And(string.Format("set trades are {0}", trades), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then(string.Format("the Max Consecutive Losses result should be {0}", max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then(string.Format("total records should be {0}", records), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "120")]
        public virtual void SimulateThenGetMaxNumberOfConsecutiveLosses_Variant0()
        {
            this.SimulateThenGetMaxNumberOfConsecutiveLosses("10", "1", "1", "120", "0", "120", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "120")]
        public virtual void SimulateThenGetMaxNumberOfConsecutiveLosses_Variant1()
        {
            this.SimulateThenGetMaxNumberOfConsecutiveLosses("10", "-1", "1", "120", "120", "120", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "240")]
        public virtual void SimulateThenGetMaxNumberOfConsecutiveLosses_Variant2()
        {
            this.SimulateThenGetMaxNumberOfConsecutiveLosses("10", "1", "2", "120", "0", "240", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate Then Get Max Number Of Consecutive Losses")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:count", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:r", "-1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:times", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:trades", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:max", "120")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:records", "240")]
        public virtual void SimulateThenGetMaxNumberOfConsecutiveLosses_Variant3()
        {
            this.SimulateThenGetMaxNumberOfConsecutiveLosses("10", "-1", "2", "120", "120", "240", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simulate 1 Run And Get Avg Number We Meet Consecutive Losses With Win Ratio 100% " +
            "Should Be 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("整合")]
        public virtual void Simulate1RunAndGetAvgNumberWeMeetConsecutiveLossesWithWinRatio100ShouldBe0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simulate 1 Run And Get Avg Number We Meet Consecutive Losses With Win Ratio 100% " +
                    "Should Be 0", new string[] {
                        "整合"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table6.AddRow(new string[] {
                        "10",
                        "1"});
#line 87
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table6, "Given ");
#line 90
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
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
#line 96
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table7.AddRow(new string[] {
                        "10",
                        "-1"});
#line 97
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table7, "Given ");
#line 100
 testRunner.And("set simulation times are 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
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
#line 106
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Count",
                        "RMultiple"});
            table8.AddRow(new string[] {
                        "10",
                        "-1"});
#line 107
 testRunner.Given("我輸入Count vs R mutiple table :", ((string)(null)), table8, "Given ");
#line 110
 testRunner.And("set simulation times are 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("set trades are 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.When("I simulate result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
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
#line 116
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "IsWinMoney"});
            table9.AddRow(new string[] {
                        "true"});
            table9.AddRow(new string[] {
                        "false"});
            table9.AddRow(new string[] {
                        "false"});
            table9.AddRow(new string[] {
                        "true"});
            table9.AddRow(new string[] {
                        "true"});
            table9.AddRow(new string[] {
                        "false"});
            table9.AddRow(new string[] {
                        "false"});
            table9.AddRow(new string[] {
                        "false"});
#line 117
 testRunner.Given("我輸入records table :", ((string)(null)), table9, "Given ");
#line 127
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
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
#line 131
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "IsWinMoney"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
            table10.AddRow(new string[] {
                        "false"});
#line 132
 testRunner.Given("我輸入records table :", ((string)(null)), table10, "Given ");
#line 142
 testRunner.When("I Calculate Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.Then("the Consecutive Losses should be \'8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("驗證百分之百會遇到的連續虧損N")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "LosingStreaks")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("unit")]
        public virtual void 驗證百分之百會遇到的連續虧損N()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("驗證百分之百會遇到的連續虧損N", new string[] {
                        "unit"});
#line 147
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "IsWinMoney"});
            table11.AddRow(new string[] {
                        "true"});
            table11.AddRow(new string[] {
                        "false"});
            table11.AddRow(new string[] {
                        "false"});
            table11.AddRow(new string[] {
                        "true"});
            table11.AddRow(new string[] {
                        "true"});
            table11.AddRow(new string[] {
                        "false"});
            table11.AddRow(new string[] {
                        "false"});
            table11.AddRow(new string[] {
                        "false"});
#line 148
 testRunner.Given("我輸入records table :", ((string)(null)), table11, "Given ");
#line 158
 testRunner.When("I Calculate Avg Consecutive Losses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.Then("the Avg Consecutive Losses result should be 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
