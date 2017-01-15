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
namespace SCRIPAU.Automation.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OL_DPM_DividendPlanMaintenance")]
    public partial class OL_DPM_DividendPlanMaintenanceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OL_DPM_DividendPlanMaintenance.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OL_DPM_DividendPlanMaintenance", "Ensure DPM. Dividend Plan Maintenance functionality covered", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Dividend Intention -Partial")]
        [NUnit.Framework.CategoryAttribute("CPU_AUTO")]
        [NUnit.Framework.CategoryAttribute("OL_DPM_DividendPlanMaintenance")]
        public virtual void AddDividendIntention_Partial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Dividend Intention -Partial", new string[] {
                        "CPU_AUTO",
                        "OL_DPM_DividendPlanMaintenance"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("In SELCOY01 I select the company: \"CPU_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I Go to Dividend Plan Maintenance Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("I select \"DIVIT\" Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "HIN",
                        "I0100007762"});
            table1.AddRow(new string[] {
                        "Tran No",
                        "156"});
            table1.AddRow(new string[] {
                        "Tran Date",
                        "13/04/15"});
            table1.AddRow(new string[] {
                        "DRP Option",
                        "P"});
            table1.AddRow(new string[] {
                        "DRP Level",
                        "100"});
#line 12
 testRunner.When("I update the \"partial\" Dividend Intention as below:", ((string)(null)), table1, "When ");
#line 19
  testRunner.And("I go to the Enquiry system for \"I0100007762\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Action",
                        "DI"});
            table2.AddRow(new string[] {
                        "Locate Argument",
                        ""});
#line 20
  testRunner.And("I enter the following details as the Locate action:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "HIN",
                        "I0100007762"});
            table3.AddRow(new string[] {
                        "DRP Intention",
                        "DRP5  5   FP DRP       13/04/15            4402       156    P        100  N"});
#line 24
  testRunner.Then("In ENS01060 I should see holder Dividend Intention Details as below:", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Dividend Intention -Full")]
        [NUnit.Framework.CategoryAttribute("CPU_AUTO")]
        [NUnit.Framework.CategoryAttribute("OL_DPM_DividendPlanMaintenance")]
        public virtual void AddDividendIntention_Full()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Dividend Intention -Full", new string[] {
                        "CPU_AUTO",
                        "OL_DPM_DividendPlanMaintenance"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("In SELCOY01 I select the company: \"CPU_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
  testRunner.And("I Go to Dividend Plan Maintenance Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.And("I select \"DIVIT\" Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "HIN",
                        "I0100007754"});
            table4.AddRow(new string[] {
                        "Tran No",
                        "157"});
            table4.AddRow(new string[] {
                        "Tran Date",
                        "13/04/15"});
            table4.AddRow(new string[] {
                        "DRP Option",
                        "F"});
#line 36
 testRunner.When("I update the \"full\" Dividend Intention as below:", ((string)(null)), table4, "When ");
#line 42
  testRunner.And("I go to the Enquiry system for \"I0100007754\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Action",
                        "DI"});
            table5.AddRow(new string[] {
                        "Locate Argument",
                        ""});
#line 43
  testRunner.And("I enter the following details as the Locate action:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "HIN",
                        "I0100007754"});
            table6.AddRow(new string[] {
                        "DRP Intention",
                        "DRP5  5   FP DRP       13/04/15            4402       157    F             N"});
#line 47
  testRunner.Then("In ENS01060 I should see holder Dividend Intention Details as below:", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
