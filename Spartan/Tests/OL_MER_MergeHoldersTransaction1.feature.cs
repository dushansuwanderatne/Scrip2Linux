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
    [NUnit.Framework.DescriptionAttribute("OL_MER_MergeHoldersTransaction")]
    public partial class OL_MER_MergeHoldersTransactionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OL_MER_MergeHoldersTransaction.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "OL_MER_MergeHoldersTransaction", "Ensure MER. Merge Holders Transaction functionality covered", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Holder Merge")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.CategoryAttribute("CPU_AUTO")]
        [NUnit.Framework.CategoryAttribute("MergeHolder")]
        [NUnit.Framework.CategoryAttribute("FullSmokeTest")]
        public virtual void HolderMerge()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Holder Merge", new string[] {
                        "winformsTest",
                        "OL_Online",
                        "OL_MER_MergeHoldersTransaction",
                        "CPU_AUTO",
                        "MergeHolder",
                        "FullSmokeTest"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("In SELCOY01 I select the company: \"CPU_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.And("I Go to Merge Holder Transaction Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("I select \"MERGE\" Transaction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Tran No",
                        "158"});
            table1.AddRow(new string[] {
                        "From Holder",
                        "I0100007592"});
            table1.AddRow(new string[] {
                        "To Holder",
                        "I0100007690"});
#line 16
 testRunner.When("I merge holder as below:", ((string)(null)), table1, "When ");
#line 21
 testRunner.When("I go to the Enquiry system for \"I0100007690\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Transaction Code",
                        "MRGTO"});
            table2.AddRow(new string[] {
                        "Transaction Desc",
                        "MERGED HOLDER TO"});
            table2.AddRow(new string[] {
                        "Reference",
                        "I0100007592"});
            table2.AddRow(new string[] {
                        "Source",
                        "WINFRM"});
#line 22
 testRunner.Then("In ENS01034 I should see Static History for holder \"I0100007690\" as below:", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Action",
                        "S"});
            table3.AddRow(new string[] {
                        "Locate Argument",
                        "I0100007592"});
#line 28
 testRunner.When("I enter the following details as the Locate action:", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "From HIN",
                        "I0100007592"});
            table4.AddRow(new string[] {
                        "Note",
                        "<* Merged on 22 Apr 2015    *>"});
#line 32
 testRunner.Then("In ENS01001 I should see the holder Details as below:", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Action",
                        "PD"});
            table5.AddRow(new string[] {
                        "Locate Argument",
                        ""});
#line 36
 testRunner.When("I enter the following details as the Locate action:", ((string)(null)), table5, "When ");
#line 40
  testRunner.Then("I expect to see error with text \"There are no payment details for this holder.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TestCase21617_MergeHolders_ErrorValidation")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("ANZ_AUTO")]
        [NUnit.Framework.CategoryAttribute("21617")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.TestCaseAttribute("Test1", "MERGE", "42409", "I0010448603", "", "I0010455774", "Tax File Numbers/ABNs or Codes DIFFERENT.", null)]
        [NUnit.Framework.TestCaseAttribute("Test2", "MERGE", "42409", "I0010041121", "", "I0010058813", "Holders Vesting differ - merge cannot proceed", null)]
        public virtual void TestCase21617_MergeHolders_ErrorValidation(string test, string selCode, string tranNumber, string fromNameKey, string fromCertID, string tONameKey, string errorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "winformsTest",
                    "OL_Online",
                    "ANZ_AUTO",
                    "21617",
                    "OL_MER_MergeHoldersTransaction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestCase21617_MergeHolders_ErrorValidation", @__tags);
#line 47
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
  testRunner.And("In MNS00101 I click on: \"online data entry system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("In OLS00101 I Click on: \"merge holders transaction\" with in the online data entry" +
                    " system menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelCode"});
            table6.AddRow(new string[] {
                        string.Format("{0}", selCode)});
#line 53
  testRunner.And("In SELTRN20 I continue with the following details:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "TranNumber",
                        "FromNameKey",
                        "FromCertID"});
            table7.AddRow(new string[] {
                        string.Format("{0}", tranNumber),
                        string.Format("{0}", fromNameKey),
                        string.Format("{0}", fromCertID)});
#line 56
  testRunner.And("In OLS03301 I continue with the following details:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "TONameKey"});
            table8.AddRow(new string[] {
                        string.Format("{0}", tONameKey)});
#line 59
  testRunner.And("In OLS03302 I continue with the following details:", ((string)(null)), table8, "And ");
#line 62
 testRunner.Then(string.Format("I should see the below ErrorMessage \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TestCase21717_MergeHolder_Transaction")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("ANZ_AUTO")]
        [NUnit.Framework.CategoryAttribute("21717")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.TestCaseAttribute("Test1", "MERGE", "42410", "I0060155119", "", "I0013820082", "S", "", ">", "", null)]
        public virtual void TestCase21717_MergeHolder_Transaction(string test, string selCode, string tranNumber, string fromNameKey, string fromCertID, string tONameKey, string action, string action1, string action2, string locateArgument, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "winformsTest",
                    "OL_Online",
                    "ANZ_AUTO",
                    "21717",
                    "OL_MER_MergeHoldersTransaction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestCase21717_MergeHolder_Transaction", @__tags);
#line 122
this.ScenarioSetup(scenarioInfo);
#line 124
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 125
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
  testRunner.And("In MNS00101 I click on: \"online data entry system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
  testRunner.And("In OLS00101 I Click on: \"merge holders transaction\" with in the online data entry" +
                    " system menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelCode"});
            table9.AddRow(new string[] {
                        string.Format("{0}", selCode)});
#line 128
  testRunner.And("In SELTRN20 I continue with the following details:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "TranNumber",
                        "FromNameKey",
                        "FromCertID"});
            table10.AddRow(new string[] {
                        string.Format("{0}", tranNumber),
                        string.Format("{0}", fromNameKey),
                        string.Format("{0}", fromCertID)});
#line 131
  testRunner.And("In OLS03301 I continue with the following details:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "TONameKey",
                        "Action"});
            table11.AddRow(new string[] {
                        string.Format("{0}", tONameKey),
                        string.Format("{0}", action)});
#line 134
  testRunner.And("In OLS03302 I continue with the following details:", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Action1"});
            table12.AddRow(new string[] {
                        string.Format("{0}", action1)});
#line 137
  testRunner.And("In OLS03303 I continue with the following details:", ((string)(null)), table12, "And ");
#line 140
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 141
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
  testRunner.And(string.Format("I go to the Enquiry system and Search {0}", fromNameKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.And(string.Format("I enter the following details as the Locate action \"{0}\" \"{1}\"", action2, locateArgument), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "HolderTO"});
            table13.AddRow(new string[] {
                        string.Format("{0}", tONameKey)});
#line 144
 testRunner.Then("In ENS01052 I verify the merge details:", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TestCase21718_MergeHolder_Transaction")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("ANZ_AUTO")]
        [NUnit.Framework.CategoryAttribute("21718")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.TestCaseAttribute("Test1", "MERGE", "42411", "I0011877672", "80334317", "I0011071856", "S", "UPDATE", ">", "", null)]
        [NUnit.Framework.TestCaseAttribute("Test2", "MERGE", "42412", "C0923981274", "", "C9856465789", "S", "UPDATE", ">", "", null)]
        public virtual void TestCase21718_MergeHolder_Transaction(string test, string selCode, string tranNumber, string fromNameKey, string fromCertID, string tONameKey, string action, string action1, string action2, string locateArgument, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "winformsTest",
                    "OL_Online",
                    "ANZ_AUTO",
                    "21718",
                    "OL_MER_MergeHoldersTransaction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestCase21718_MergeHolder_Transaction", @__tags);
#line 157
this.ScenarioSetup(scenarioInfo);
#line 160
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 161
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
  testRunner.And("In MNS00101 I click on: \"online data entry system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
  testRunner.And("In OLS00101 I Click on: \"merge holders transaction\" with in the online data entry" +
                    " system menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelCode"});
            table14.AddRow(new string[] {
                        string.Format("{0}", selCode)});
#line 164
  testRunner.And("In SELTRN20 I continue with the following details:", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "TranNumber",
                        "FromNameKey",
                        "FromCertID"});
            table15.AddRow(new string[] {
                        string.Format("{0}", tranNumber),
                        string.Format("{0}", fromNameKey),
                        string.Format("{0}", fromCertID)});
#line 167
  testRunner.And("In OLS03301 I continue with the following details:", ((string)(null)), table15, "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "TONameKey",
                        "Action"});
            table16.AddRow(new string[] {
                        string.Format("{0}", tONameKey),
                        string.Format("{0}", action)});
#line 170
  testRunner.And("In OLS03302 I continue with the following details:", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Action1"});
            table17.AddRow(new string[] {
                        string.Format("{0}", action1)});
#line 173
  testRunner.And("In OLS03303 I continue with the following details:", ((string)(null)), table17, "And ");
#line 176
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 177
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 178
  testRunner.And(string.Format("I go to the Enquiry system and Search {0}", fromNameKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
  testRunner.And(string.Format("I enter the following details as the Locate action \"{0}\" \"{1}\"", action2, locateArgument), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "HolderTO"});
            table18.AddRow(new string[] {
                        string.Format("{0}", tONameKey)});
#line 180
 testRunner.Then("In ENS01052 I verify the merge details:", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TestCase24960_MergeHolders_ErrorValidation")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("ANZ_AUTO")]
        [NUnit.Framework.CategoryAttribute("24960")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.TestCaseAttribute("Test1", "MERGE", "42413", "I0000000892", "", "I0010455774", "Holder \"I0000000892\" is currently participating in dividend LNX2", null)]
        public virtual void TestCase24960_MergeHolders_ErrorValidation(string test, string selCode, string tranNumber, string fromNameKey, string fromCertID, string tONameKey, string errorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "winformsTest",
                    "OL_Online",
                    "ANZ_AUTO",
                    "24960",
                    "OL_MER_MergeHoldersTransaction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestCase24960_MergeHolders_ErrorValidation", @__tags);
#line 194
this.ScenarioSetup(scenarioInfo);
#line 196
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 197
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 198
  testRunner.And("In MNS00101 I click on: \"online data entry system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
  testRunner.And("In OLS00101 I Click on: \"merge holders transaction\" with in the online data entry" +
                    " system menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelCode"});
            table19.AddRow(new string[] {
                        string.Format("{0}", selCode)});
#line 200
  testRunner.And("In SELTRN20 I continue with the following details:", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "TranNumber",
                        "FromNameKey",
                        "FromCertID"});
            table20.AddRow(new string[] {
                        string.Format("{0}", tranNumber),
                        string.Format("{0}", fromNameKey),
                        string.Format("{0}", fromCertID)});
#line 203
  testRunner.And("In OLS03301 I continue with the following details:", ((string)(null)), table20, "And ");
#line 206
 testRunner.Then(string.Format("I should see the below ErrorMessage \"{0}\"", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TestCase25223_MergeHolder_Transaction")]
        [NUnit.Framework.CategoryAttribute("winformsTest")]
        [NUnit.Framework.CategoryAttribute("OL_Online")]
        [NUnit.Framework.CategoryAttribute("ANZ_AUTO")]
        [NUnit.Framework.CategoryAttribute("25223")]
        [NUnit.Framework.CategoryAttribute("OL_MER_MergeHoldersTransaction")]
        [NUnit.Framework.CategoryAttribute("FullSmokeTest")]
        [NUnit.Framework.TestCaseAttribute("Test1", "MERGE", "42414", "I0010269512", "", "I0010315573", "S", "UPDATE", "ESOT", "/DSI", "12J EE  12/11/12     VC8  P11  HK Def        1100  01/01   12/11/14        1100  " +
            "         0           0           0        1100", "", "", "", "", "", "", "", "", "", null)]
        public virtual void TestCase25223_MergeHolder_Transaction(
                    string test, 
                    string selCode, 
                    string tranNumber, 
                    string fromNameKey, 
                    string fromCertID, 
                    string tONameKey, 
                    string action, 
                    string action1, 
                    string action2, 
                    string locateArgument, 
                    string detailLine1, 
                    string detailLine2, 
                    string detailLine3, 
                    string detailLine4, 
                    string detailLine5, 
                    string detailLine6, 
                    string detailLine7, 
                    string detailLine8, 
                    string detailLine9, 
                    string detailLine10, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "winformsTest",
                    "OL_Online",
                    "ANZ_AUTO",
                    "25223",
                    "OL_MER_MergeHoldersTransaction",
                    "FullSmokeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TestCase25223_MergeHolder_Transaction", @__tags);
#line 218
this.ScenarioSetup(scenarioInfo);
#line 220
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 221
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 222
  testRunner.And("In MNS00101 I click on: \"online data entry system\" within the System Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
  testRunner.And("In OLS00101 I Click on: \"merge holders transaction\" with in the online data entry" +
                    " system menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "SelCode"});
            table21.AddRow(new string[] {
                        string.Format("{0}", selCode)});
#line 224
  testRunner.And("In SELTRN20 I continue with the following details:", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "TranNumber",
                        "FromNameKey",
                        "FromCertID"});
            table22.AddRow(new string[] {
                        string.Format("{0}", tranNumber),
                        string.Format("{0}", fromNameKey),
                        string.Format("{0}", fromCertID)});
#line 227
  testRunner.And("In OLS03301 I continue with the following details:", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "TONameKey",
                        "Action"});
            table23.AddRow(new string[] {
                        string.Format("{0}", tONameKey),
                        string.Format("{0}", action)});
#line 230
  testRunner.And("In OLS03302 I continue with the following details:", ((string)(null)), table23, "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Action1"});
            table24.AddRow(new string[] {
                        string.Format("{0}", action1)});
#line 233
  testRunner.And("In OLS03303 I continue with the following details:", ((string)(null)), table24, "And ");
#line 236
 testRunner.Given("I have connected to WinForms", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 237
 testRunner.When("In SELCOY01 I select the company: \"ANZ_AUTO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 238
  testRunner.And(string.Format("I go to the Enquiry system and Search {0}", tONameKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 239
  testRunner.And(string.Format("I enter the following details as the Locate action \"{0}\" \"{1}\"", action2, locateArgument), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "DetailLine1",
                        "DetailLine2",
                        "DetailLine3",
                        "DetailLine4",
                        "DetailLine5",
                        "DetailLine6",
                        "DetailLine7",
                        "DetailLine8",
                        "DetailLine9",
                        "DetailLine10"});
            table25.AddRow(new string[] {
                        string.Format("{0}", detailLine1),
                        string.Format("{0}", detailLine2),
                        string.Format("{0}", detailLine3),
                        string.Format("{0}", detailLine4),
                        string.Format("{0}", detailLine5),
                        string.Format("{0}", detailLine6),
                        string.Format("{0}", detailLine7),
                        string.Format("{0}", detailLine8),
                        string.Format("{0}", detailLine9),
                        string.Format("{0}", detailLine10)});
#line 240
 testRunner.Then("In ENSESS25 I verify the following details:", ((string)(null)), table25, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
