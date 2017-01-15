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
namespace SCRIPAU.Automation.Reporting
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UpdateReportRun")]
    public partial class UpdateReportRunFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateReportRun.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateReportRun", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("CPU_URR")]
        [NUnit.Framework.CategoryAttribute("URRNightly")]
        [NUnit.Framework.CategoryAttribute("CPU_URR")]
        [NUnit.Framework.TestCaseAttribute("Test1", "Y", "CPU_URR", "Y", "[.prn_aus]", "Y", "[.prn_nzl]", "prn_aus", "Y", "prn_nzl", "Y", "completion", "3600", "error", "N", null)]
        public virtual void CPU_URR(
                    string reportHeading, 
                    string nightlyRunInd, 
                    string cOY, 
                    string otherFile1, 
                    string fileLocationVMS1, 
                    string otherFile2, 
                    string fileLocationVMS2, 
                    string fileLocationVLnx1, 
                    string otherFileLnx1, 
                    string fileLocationVLnx2, 
                    string otherFileLnx2, 
                    string passCriteria, 
                    string timeout, 
                    string failCriteria, 
                    string onlyCorporateActionFiles, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "URRNightly",
                    "CPU_URR"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CPU_URR", @__tags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.When("In SELCOY01 I select the company: \"CPU_URR\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
  testRunner.And("In MNS00101 I click on: \"reporting system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
  testRunner.And("In RSS00101 I click on: \"schedule transaction reporting run\" within the Reporting" +
                    " System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "NightlyRunInd"});
            table1.AddRow(new string[] {
                        string.Format("{0}", nightlyRunInd)});
#line 71
  testRunner.And("In RSS25010 I Enter URR Parameter as:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "COY"});
            table2.AddRow(new string[] {
                        string.Format("{0}", cOY)});
#line 74
  testRunner.And("I start Capture Rollback process", ((string)(null)), table2, "And ");
#line 77
 testRunner.When("I continue to the report submit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "PassCriteria",
                        "timeout",
                        "FailCriteria"});
            table3.AddRow(new string[] {
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria)});
#line 78
  testRunner.And("In JOBSUB90 I submit the report for VMS and Linux", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "PostURRJob",
                        "PassCriteria",
                        "timeout",
                        "FailCriteria",
                        "COY"});
            table4.AddRow(new string[] {
                        "<PostURRJob>",
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria),
                        string.Format("{0}", cOY)});
#line 81
  testRunner.And("I Submit Post URR Job", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "COY"});
            table5.AddRow(new string[] {
                        string.Format("{0}", cOY)});
#line 84
  testRunner.And("I stop Capture Rollback process", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ReportHeading",
                        "FileName",
                        "OtherFile1",
                        "fileLocationVMS1",
                        "OtherFile2",
                        "fileLocationVMS2",
                        "fileLocationVLnx1",
                        "OtherFileLnx1",
                        "fileLocationVLnx2",
                        "OtherFileLnx2",
                        "OnlyCorporateActionFiles"});
            table6.AddRow(new string[] {
                        string.Format("{0}", reportHeading),
                        "",
                        string.Format("{0}", otherFile1),
                        string.Format("{0}", fileLocationVMS1),
                        string.Format("{0}", otherFile2),
                        string.Format("{0}", fileLocationVMS2),
                        string.Format("{0}", fileLocationVLnx1),
                        string.Format("{0}", otherFileLnx1),
                        string.Format("{0}", fileLocationVLnx2),
                        string.Format("{0}", otherFileLnx2),
                        string.Format("{0}", onlyCorporateActionFiles)});
#line 87
  testRunner.Then("I copy URR files to local", ((string)(null)), table6, "Then ");
#line 90
  testRunner.And("I parse the files from VMS or Linux", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.And("I compare the files from VMS and Linux goldcopy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("URR_WES_Full")]
        [NUnit.Framework.CategoryAttribute("URRNightly")]
        [NUnit.Framework.CategoryAttribute("URRGold")]
        [NUnit.Framework.CategoryAttribute("WES_URR")]
        [NUnit.Framework.TestCaseAttribute("Test1", "Y", "WES_URR", "3600", "completion", "error", "N", null)]
        public virtual void URR_WES_Full(string reportHeading, string nightlyRunInd, string cOY, string timeout, string passCriteria, string failCriteria, string onlyCorporateActionFiles, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "URRNightly",
                    "URRGold",
                    "WES_URR"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("URR_WES_Full", @__tags);
#line 102
this.ScenarioSetup(scenarioInfo);
#line 103
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
 testRunner.When("In SELCOY01 I select the company: \"WES_URR\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
  testRunner.And("In MNS00101 I click on: \"reporting system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
  testRunner.And("In RSS00101 I click on: \"schedule transaction reporting run\" within the Reporting" +
                    " System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "NightlyRunInd"});
            table7.AddRow(new string[] {
                        string.Format("{0}", nightlyRunInd)});
#line 107
  testRunner.And("In RSS25010 I Enter URR Parameter as:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "COY"});
            table8.AddRow(new string[] {
                        string.Format("{0}", cOY)});
#line 110
  testRunner.And("I start Capture Rollback process", ((string)(null)), table8, "And ");
#line 113
 testRunner.When("I continue to the report submit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "PassCriteria",
                        "timeout",
                        "FailCriteria"});
            table9.AddRow(new string[] {
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria)});
#line 114
  testRunner.And("In JOBSUB90 I submit the report for VMS and Linux", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "PostURRJob",
                        "PassCriteria",
                        "timeout",
                        "FailCriteria",
                        "COY"});
            table10.AddRow(new string[] {
                        "<PostURRJob>",
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria),
                        string.Format("{0}", cOY)});
#line 117
  testRunner.And("I Submit Post URR Job", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "COY"});
            table11.AddRow(new string[] {
                        string.Format("{0}", cOY)});
#line 120
  testRunner.And("I stop Capture Rollback process", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ReportHeading",
                        "FileName",
                        "OtherFile1",
                        "fileLocationVMS1",
                        "OtherFile2",
                        "fileLocationVMS2",
                        "fileLocationVLnx1",
                        "OtherFileLnx1",
                        "fileLocationVLnx2",
                        "OtherFileLnx2",
                        "OnlyCorporateActionFiles"});
            table12.AddRow(new string[] {
                        string.Format("{0}", reportHeading),
                        "",
                        "<OtherFile1>",
                        "<fileLocationVMS1>",
                        "<OtherFile2>",
                        "<fileLocationVMS2>",
                        "<fileLocationVLnx1>",
                        "<OtherFileLnx1>",
                        "<fileLocationVLnx2>",
                        "<OtherFileLnx2>",
                        string.Format("{0}", onlyCorporateActionFiles)});
#line 123
  testRunner.Then("I copy URR files to local", ((string)(null)), table12, "Then ");
#line 126
  testRunner.And("I parse the files from VMS or Linux", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.And("I compare the files from VMS and Linux goldcopy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("RunURR")]
        [NUnit.Framework.CategoryAttribute("FullSmokeTest")]
        [NUnit.Framework.CategoryAttribute("SmokeTestFullURR")]
        [NUnit.Framework.TestCaseAttribute("Test1", "Y", "DIV_A", "completion", "3600", "error", null)]
        public virtual void RunURR(string reportHeading, string nightlyRunInd, string cOY, string passCriteria, string timeout, string failCriteria, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "FullSmokeTest",
                    "SmokeTestFullURR"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("RunURR", @__tags);
#line 150
this.ScenarioSetup(scenarioInfo);
#line 151
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 152
 testRunner.When("In SELCOY01 I select the company: \"DIV_A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
  testRunner.And("In MNS00101 I click on: \"reporting system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
  testRunner.And("In RSS00101 I click on: \"schedule transaction reporting run\" within the Reporting" +
                    " System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "NightlyRunInd"});
            table13.AddRow(new string[] {
                        string.Format("{0}", nightlyRunInd)});
#line 155
  testRunner.And("In RSS25010 I Enter URR Parameter as:", ((string)(null)), table13, "And ");
#line 158
 testRunner.When("I continue to the report submit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "PassCriteria",
                        "timeout",
                        "FailCriteria"});
            table14.AddRow(new string[] {
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria)});
#line 159
  testRunner.And("In JOBSUB90 I submit the report for VMS and Linux", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "PostURRJob",
                        "PassCriteria",
                        "timeout",
                        "FailCriteria",
                        "COY"});
            table15.AddRow(new string[] {
                        "<PostURRJob>",
                        string.Format("{0}", passCriteria),
                        string.Format("{0}", timeout),
                        string.Format("{0}", failCriteria),
                        string.Format("{0}", cOY)});
#line 162
  testRunner.And("I Submit Post URR Job", ((string)(null)), table15, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion