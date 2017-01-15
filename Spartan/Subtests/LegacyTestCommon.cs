using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using NUnit.Framework;
using Renci.SshNet;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Linq;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class WinFormsTestSteps
    {
        public static string Environment;
        public static string hostEnv;
        public static string Mode;
        public static string PlnAuthorisationRef;
        public static string TradeID;
        public static bool WinformConnected = false;
        private static string COY;
        private static string currentCOY;
        private static string JobNumber;
        private static string Password;
        private static string PasswordBackend;
        private static string ReportDesc;
        private static string ReportJobNumber;
        private static string ReportPrintFileName;
        private static string ReportPRNName;
        private static string RunNumber;
        private static string SessionBackend;
        private static string Username;
        private static string UsernameBackend;

        [Flags]
        public enum ParallelScope
        {
            None,     // the test may not be run in parallel with other tests
            Self,     // the test itself may be run in parallel with other tests
            Children, // child tests may be run in parallel with one another
            Fixtures  // fixtures may be run in parallel with one another
        }

        [AfterScenario]
        public static void CloseWinformsInstance()
        {
            if (WinformConnected ==true)
            {
                Spartan.Core.WinForms.WinFormsDriver.Close();
            }

        }

        public static String GetRunNumber()
        {
            string value = "";
            try
            {
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                value = ENS01060.SystemInfoFree4.GetValue().Trim();
                RunNumber = value.Substring(0, 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail(ex.Message);
            }
            return RunNumber;
        }

        [BeforeScenario]
        public static void InitialiseTestThread()
        {
            TestContext CurrentScenario = new TestContext();
            List<int> PIDs = new List<int>();

            foreach (Process proc in Process.GetProcessesByName("WinForms"))
            {
                PIDs.Add(proc.Id);
            }
            //PIDs.Find();
        }

        [BeforeTestRun]
        public static void KillWF()
        {
            ReportingTestSteps.TradingReport = false;
            foreach (Process proc in Process.GetProcessesByName("WinForms"))
            {
                proc.Kill();
            }
        }

        [When(@"In TNS01102 I Add TFN details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddTFNDetails(string Tran, string ExemptType, string TFN, string ABN, string TFNType, string ABNType)
        {
            ExpectToBeInTheScreen("TNS01102");
            TNS01102.TransNumber.SetValue(Tran);
            TNS01102.HolderExemptInd1.SetValue(ExemptType);
            TNS01102.HolderExemptInd1.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            TNS01102.Tfn1.SetValue(TFN);
            TNS01102.TfnSuffix1.SetValue(TFNType);
            TNS01102.Abn1.SetValue(ABN);
            TNS01102.AbnSuffix1.SetValue(ABNType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In BILCTL99 I Add Trade Control Details as ""(.*)"" ""(.*)""")]
        public void BILCTL99AddTradeControlDetails(string ServiceProvider, string ServiceCode)
        {
            BILCTL99.ServiceProvider.SetValue(ServiceProvider);
            BILCTL99.ServiceCode.SetValue(ServiceCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("TRD24001");
        }

        [When(@"In BLKSCH02 I enter the selection as ""(.*)""")]
        public void BLKSCH02EnterTheSelection(string Selection)
        {
            BLKSCH02.ActionM.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In CFS03000 I continue with the following details:")]
        public void CFS03000ContinueWithTheFollowingDetails(Table table)
        {
            ExpectToBeInTheScreen("CFS03000");

            if (table.Rows[0]["Action"] == "s")
            {
                CFS03000.Action.SetValue(1, table.Rows[0]["Action"]);
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                CFS03000.ReinitiateSearch.SetValue(1, table.Rows[0]["ReinitiateSearch"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            if (table.Rows[0]["Action"] == "f")
            {
                CFS03000.Action.SetValue(1, table.Rows[0]["Action"]);
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In CFS03001 I continue with the following details:")]
        public void CFS03001ContinueWithTheFollowingDetails(Table table)
        {
            ExpectToBeInTheScreen("CFS03001");
            ;
            if (table.Rows[0]["Action"] == "D")
            {
                CFS03001.Action.SetValue(1, table.Rows[0]["Action"]);
                string temp1 = CFS03001.Postcode.GetValue();
                CFS03001.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                CFS03001.Confirm.SetValue(1, table.Rows[0]["Confirm"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                string temp2 = CFS03001.Postcode.GetValue();
                if (temp1 == temp2)
                {
                    throw new Exception("failed to delete postcode");
                }
                else
                {
                    Console.Write("Postcode " + temp1 + " has been deleted successfully");
                }
            }
        }
       
        [When(@"I change Charity Participation Fileds in Company Options as ""(.*)"" ""(.*)""")]
        public void ChangeCharityParticipationFiledsInCompanyOptions(string CharityDollars, string CharityPercentage)
        {
            ClickWithinTheSystemMenu("housekeeping system");
            HKS00101.MenuItemCco.ClickField();
            ExpectToBeInTheScreen("HCC00101");
            HCC00101.MenuItemCtl.ClickField();
            ExpectToBeInTheScreen("HCC00102");
            HCC00102.MenuItemCop.ClickField();
            ExpectToBeInTheScreen("HKS01500");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("HKS01501");

            if (HKS01501.FasterScriplessNbr.Exists()==true)
            {
                string FASTERNumber = HKS01501.SinNumber.GetValue();
                HKS01501.FasterScriplessNbr.SetValue(FASTERNumber);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("HKS01502");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("HKS01503");
            HKS01503.CoyCharityInd.SetValue("Y");
            HKS01503.CoyCharityInd.SetValue(CharityDollars);
            HKS01503.CharityPercentInd.SetValue(CharityPercentage);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("HKS01504");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("HCC00102");
        }

        public void ClickOnWithInTheDividendSystemMenu(string menuOption)
        {
            //ExpectToBeInTheScreen("SPS00102");
            switch (menuOption.ToLower())
            {
                case "dividend payment parameters":
                    SPS00102.MenuItemDpp.ClickField();
                    break;

                case "payment job release monitor":
                    SPS00102.MenuItemPjm.ClickField();
                    break;
            }
        }

        [When(@"In ENS00101 I click on: ""(.*)"" within the Enquiry System Menu")]
        public void ClickOnWithinTheEnquirySystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "holder enquiry system":
                    ENS00101.MenuItemE.ClickField();
                    break;

                case "payment enquiry system":
                    ENS00101.MenuItemPE.ClickField();
                    break;

                case "statistics enquiry":
                    ENS00101.MenuItemSE.ClickField();
                    break;

                case "consolidated extract files":
                    ENS00101.MenuItemCX.ClickField();
                    break;

                case "enquiry print":
                    ENS00101.MenuItemEP.ClickField();
                    break;

                case "issued capital report":
                    ENS00101.MenuItemIR.ClickField();
                    break;

                case "holder request print":
                    ENS00101.MenuItemHR.ClickField();
                    break;

                case "sponsorship statement print":
                    ENS00101.MenuItemSP.ClickField();
                    break;

                case "exit enquiry":
                    ENS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In TNS05001 I click on: ""(.*)"" within the IRS Tax Processing Menu")]
        public void ClickOnWithinTheIRSTaxProcessingMenu(string menuOption)
        {
            //ExpectToBeInTheScreen("TNS05001");

            switch (menuOption.ToLower())
            {
                case "giin validation reporting":
                    TNS05001.MenuItemGii.ClickField();
                    break;

                case "change in circumstance reporting":
                    TNS05001.MenuItemCic.ClickField();
                    break;

                case "exit irs processing":
                    TNS05001.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLS00101 I Click on: ""(.*)"" with in the online data entry system menu")]
        public void ClickOnWithInTheOnlineDataEnterySystemMenu(string OLMenuoption)
        {
            //ExpectToBeInTheScreen("OLS00101");
            switch (OLMenuoption.ToLower())
            {
                case "static detail":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    OLS00101.MenuItemSdm.ClickField();
                    break;

                case "standard transactions":
                    OLS00101.MenuItemStd.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "dividend plan maintenance":
                    OLS00101.MenuItemDpm.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "merge holders transaction":
                    OLS00101.MenuItemMer.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "payment transactions":
                    OLS00101.MenuItemPat.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("OLS15001");
                    break;

                case "uncertificated transactions":
                    OLS00101.MenuItemUnc.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "special transaction":
                    OLS00101.MenuItemSpt.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "housekeeping transactions":
                    OLS00101.MenuItemHkt.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "acceptance transactions":
                    OLS00101.MenuItemAct.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SELTRN20");
                    break;

                case "exit menu":
                    OLS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLS01120 I Click on: ""(.*)"" with in the static detail update menu")]
        public void ClickOnWithInTheStaticDetailUpdatemMenu(string OLMenuoption)
        {
            //ExpectToBeInTheScreen("OLS01120");
            switch (OLMenuoption.ToLower())
            {
                case "add holder":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    OLS01120.MenuItemAH.ClickField();
                    break;

                case "name and address changes":
                    OLS01120.MenuItemNA.ClickField();
                    break;

                case "holder extra details":
                    OLS01120.MenuItemHE.ClickField();
                    break;

                case "payee instructions":
                    OLS01120.MenuItemPI.ClickField();
                    break;

                case "overseas wire instructions":
                    OLS01120.MenuItemWR.ClickField();
                    break;

                case "employee details":
                    OLS01120.MenuItemED.ClickField();
                    break;

                default:
                    break;
            }
        }

        public void ClickOnWithinTheSystemSetupUpdateMenu(string menuOption)
        {
            //ExpectToBeInTheScreen("SPS00101");
            switch (menuOption.ToLower())
            {
                case "dividend payment parameters":
                    SPS00101.MenuItemDiv.ClickField();
                    break;

                case "issue/reconstruction parameters":
                    SPS00101.MenuItemIss.ClickField();
                    break;
            }
        }

        [When(@"In TNS00103 I click on: ""(.*)"" within the Tax File Number Online Processing Menu")]
        public void ClickOnWithinTheTaxFileNumberOnlineProcessingMenu(string menuOption)
        {
            //ExpectToBeInTheScreen("TNS00103");
            switch (menuOption.ToLower())
            {
                case "tax file number updating":
                    TNS00103.MenuItemTfnup.ClickField();

                    break;

                case "tax file number notice request":
                    TNS00103.MenuItemTfnrq.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In TNS00101 I click on: ""(.*)"" within the Tax Processing Menu")]
        public void ClickOnWithinTheTaxProcessingMenu(string menuOption)
        {
            //ExpectToBeInTheScreen("TNS00101");
            switch (menuOption.ToLower())
            {
                case "tax file number online data entry":
                    TNS00101.MenuItemTol.ClickField();
                    break;

                case "tax file number reporting system":
                    TNS00101.MenuItemTrs.ClickField();
                    break;

                case "irs reporting system":
                    TNS00101.MenuItemIrs.ClickField();
                    break;

                case "exit tax processing":
                    TNS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [Given(@"In RSS13000 I click on: ""(.*)"" within the Control Reporting Menu")]
        [When(@"In RSS13000 I click on: ""(.*)"" within the Control Reporting Menu")]
        public void ClickWithinTheControlReportingmMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "print master codes":
                    RSS13000.MenuItemMC.ClickField();
                    break;

                case "print control codes":
                    RSS13000.MenuItemCC.ClickField();
                    break;

                case "broker code labels":
                    RSS13000.MenuItemBL.ClickField();
                    break;

                case "new zealand annual report":
                    RSS13000.MenuItemNZ.ClickField();
                    break;

                case "pending holder communications":
                    RSS13000.MenuItemPC.ClickField();
                    break;

                case "print update reporting control parameters":
                    RSS13000.MenuItemUC.ClickField();
                    break;

                case "trading system reporting":
                    RSS13000.MenuItemTR.ClickField();
                    ExpectToBeInTheScreen("TRDRSP00");
                    break;

                case "audit method report":
                    RSS13000.MenuItemAM.ClickField();
                    break;

                case "bank code exception report":
                    RSS13000.MenuItemBC.ClickField();
                    break;

                case "domicile postcode exception report":
                    RSS13000.MenuItemDP.ClickField();
                    break;

                case "broker codes exception report":
                    RSS13000.MenuItemBE.ClickField();
                    break;

                case "transaction summary reporting":
                    RSS13000.MenuItemTS.ClickField();
                    break;

                case "scrip formats":
                    RSS13000.MenuItemSF.ClickField();
                    break;

                case "direct credit test tape":
                    RSS13000.MenuItemDC.ClickField();
                    break;

                case "transaction activity reporting":
                    RSS13000.MenuItemTA.ClickField();
                    break;

                case "copy billing groups":
                    RSS13000.MenuItemBG.ClickField();
                    break;

                case "reporting statistics":
                    RSS13000.MenuItemRS.ClickField();
                    break;

                case "custodian holder detail extract":
                    RSS13000.MenuItemCD.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In HOSTFN01 I click on: ""(.*)"" within the Host Functions Menu")]
        public void ClickWithinTheHostFunctionsMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "printing options":
                    HOSTFN01.MenuItemPrt.ClickField();
                    break;

                case "control printers":
                    HOSTFN01.MenuItemCpr.ClickField();
                    break;

                case "check on job queue":
                    HOSTFN01.MenuItemJob.ClickField();
                    break;

                case "job parameter file options":
                    HOSTFN01.MenuItemRsp.ClickField();
                    break;

                case "file transfer":
                    HOSTFN01.MenuItemFtp.ClickField();
                    break;

                case "exit host function system":
                    HOSTFN01.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"in hks00101 i click on: ""(.*)"" within the housekeeping menu")]
        public void clickwithinthehousekeepingmenu(string menuoption)
        {
            switch (menuoption.ToLower())
            {
                case "control code options":
                    HKS00101.MenuItemCco.ClickField();
                    break;

                case "initialize online data entry":
                    HKS00101.MenuItemInt.ClickField();
                    break;

                case "reissue stale markings":
                    HKS00101.MenuItemRsm.ClickField();
                    break;

                case "adhoc transaction reporting run":
                    HKS00101.MenuItemAtr.ClickField();
                    break;

                case "transfer journal report":
                    HKS00101.MenuItemTJ.ClickField();
                    break;

                case "exit housekeeping":
                    HKS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In RSS15000 I click on: ""(.*)"" within the Merge Holders Reporting Menu")]
        public void ClickWithinTheMergeHoldersReportingMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "exit merge holders":
                    RSS15000.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [Given(@"In RSS00101 I click on: ""(.*)"" within the Reporting System Menu")]
        [When(@"In RSS00101 I click on: ""(.*)"" within the Reporting System Menu")]
        public void ClickWithinTheReportingSystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "schedule transaction reporting run":
                    RSS00101.MenuItemRun.ClickField();
                    ExpectToBeInTheScreen("RSS25010");
                    break;

                case "end of month statistics":
                    RSS00101.MenuItemEM.ClickField();
                    break;

                case "stamp duty report":
                    RSS00101.MenuItemSD.ClickField();
                    break;

                case "cheque extract reporting":
                    RSS00101.MenuItemCE.ClickField();
                    break;

                case "control reporting":
                    RSS00101.MenuItemCR.ClickField();
                    ExpectToBeInTheScreen("RSS13000");
                    break;

                case "shareholder movement reporting":
                    RSS00101.MenuItemSM.ClickField();
                    break;

                case "uncertificated reporting":
                    RSS00101.MenuItemUR.ClickField();
                    break;

                case "employee scheme reporting":
                    RSS00101.MenuItemEC.ClickField();
                    break;

                case "ess reporting":
                    RSS00101.MenuItemES.ClickField();
                    break;

                case "extract reporting":
                    RSS00101.MenuItemER.ClickField();
                    break;

                case "top holders list":
                    RSS00101.MenuItemTH.ClickField();
                    break;

                case "like holders summary":
                    RSS00101.MenuItemLH.ClickField();
                    break;

                case "summary reporting":
                    RSS00101.MenuItemSR.ClickField();
                    break;

                case "plan reporting":
                    RSS00101.MenuItemPL.ClickField();
                    break;

                case "broker reporting":
                    RSS00101.MenuItemBR.ClickField();
                    break;

                case "merge holder reporting":
                    RSS00101.MenuItemMH.ClickField();
                    break;

                case "sundry reporting":
                    RSS00101.MenuItemSU.ClickField();
                    break;

                case "unclaimed monies":
                    RSS00101.MenuItemUM.ClickField();
                    break;

                case "exit reporting system":
                    RSS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [Given(@"In RSS01010 I click on: ""(.*)"" within the Summary Reporting Menu")]
        [When(@"In RSS01010 I click on: ""(.*)"" within the Summary Reporting Menu")]
        public void ClickWithinTheSummaryReportingSystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "holder type summary":
                    RSS01010.MenuItemHS.ClickField();
                    break;

                case "local domicile summary":
                    RSS01010.MenuItemDS.ClickField();
                    break;

                case "range of units summary":
                    RSS01010.MenuItemRU.ClickField();
                    break;

                case "spread of holders address summary":
                    RSS01010.MenuItemSA.ClickField();
                    break;

                case "holder subscriptions summary":
                    RSS01010.MenuItemSS.ClickField();
                    break;

                case "payment elections summary":
                    RSS01010.MenuItemPE.ClickField();
                    break;

                default:
                    break;
            }
        }

        [Given(@"In MNS00101 I click on: ""(.*)"" within the System Menu")]
        [When(@"In MNS00101 I click on: ""(.*)"" within the System Menu")]
        public void ClickWithinTheSystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "enquiry system":
                    MNS00101.EnquirySystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "housekeeping system":
                    MNS00101.HousekeepingSystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "host functions":
                    MNS00101.HostFunctions.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;
                //case "tax file number processing":
                //    MNS00101.MenuItemTN.ClickField();
                //    break;
                case "trading system":
                    MNS00101.TradingSystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "online proxy system":
                    MNS00101.OnlineProxySystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "online data entry system":
                    MNS00101.OnlineDataEntrySystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "reporting system":
                    MNS00101.ReportingSystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "employee plan processing":
                    MNS00101.EmployeeSchemeProcessing.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "system parameter setups":
                    MNS00101.SystemParameterSetups.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SPS00101");
                    break;

                case "exit from system":
                    MNS00101.ExitfromSystem.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "file processing":
                    MNS00101.FileProcessing.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SPS00101");
                    break;

                default:
                    break;
            }
        }

        [AfterScenario]
        [Then(@"I close Winforms")]
        public void CloseWinforms()
        {
            if (WinformConnected == true)
            {
                Spartan.Core.WinForms.WinFormsDriver.Close();
            }
        }

        [When(@"In TNS01102 I delete TFN from selected holder")]
        public void DeleteTFNFromSelectedHolder()
        {
            Random r = new Random();
            int randomNo = r.Next(1, 999999);
            string tranId = randomNo.ToString();

            TNS01102.TransNumber.SetValue(tranId);
            TNS01102.DeleteInd.SetValue("Y");

            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.Transmit(); //second transmit to confirm deletion
        }

        [When(@"In DIVX1001 I enter Dividend Control Update Details as ""(.*)"" ""(.*)""")]
        public void DIVX1001EnterDividendControlUpdateDetails(string PreLoad, string DividendCode)
        {
            ExpectToBeInTheScreen("DIVX1001");
            DIVX1001.Preload.SetValue(PreLoad);
            DIVX1001.DividendCode.SetValue(DividendCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1005 I enter payment control setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1005EnterPaymentControlsetup(string DivDesc, string CorporateActionType, string EmpPayment, string MultiplePayments, string EnableAutoJob)
        {
            ExpectToBeInTheScreen("DIVX1005");
            DIVX1005.DividendDescription.SetValue(DivDesc);
            DIVX1005.CorporateAction.SetValue(CorporateActionType);
            DIVX1005.EmployeeDividend.SetValue(EmpPayment);
            DIVX1005.MultiplePayments.SetValue(MultiplePayments);
            DIVX1005.AutomatedJobRelease.SetValue(EnableAutoJob);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1008 I enter Sub Payment Code setup as ""(.*)"" ""(.*)""")]
        public void DIVX1008EnterSubPaymentCodesetup(string SubPayCode, string PaymentType)
        {
            ExpectToBeInTheScreen("DIVX1008");
            DIVX1008.SubPay1.SetValue(SubPayCode);
            DIVX1008.PayTyp1.SetValue(PaymentType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1010 I enter Payment Control setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1010EnterPaymentControlsetup(string PaymentDate, string ListingDate, string BooksCloseDate, string PaidToDate)
        {
            ExpectToBeInTheScreen("DIVX1010");
            DIVX1010.PaymentDate.SetValue(PaymentDate);
            DIVX1010.ListDate.SetValue(ListingDate);
            DIVX1010.BooksCloseDate.SetValue(BooksCloseDate);
            DIVX1010.PaidTODate.SetValue(PaidToDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1012 I enter Payment Control setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1012EnterPaymentControlSetup(string ATOEFT, string DivSourceApply, string DivPlanApply, string Class1, string Class2, string PrintHolderID)
        {
            ExpectToBeInTheScreen("DIVX1012");
            DIVX1012.AtoEftLgePayApply.SetValue(ATOEFT);
            DIVX1012.DividendSourceApply.SetValue(DivSourceApply);
            DIVX1012.DividendPlanApply.SetValue(DivPlanApply);
            DIVX1012.Selcls.SetValue(1, Class1);
            DIVX1012.Selcls.SetValue(1, Class2);
            DIVX1012.HidTOPrint.SetValue(PrintHolderID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1020 I enter Payment Source Options as ""(.*)""")]
        public void DIVX1020EnterPaymentSourceOptions(string Option)
        {
            ExpectToBeInTheScreen("DIVX1020");
            DIVX1020.Option.SetValue(Option);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1022 I enter Payment Source Output Parameters as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1022entErPaymentSourceOutputParameters(string PaymentListingHead, string PaymentListing, string PaymentListingSeq)
        {
            ExpectToBeInTheScreen("DIVX1022");
            DIVX1022.PaymentListingHead.SetValue(PaymentListingHead);
            DIVX1022.PaymentSequence.SetValue(PaymentListing);
            DIVX1022.ChequeAdviceSeq.SetValue(PaymentListingSeq);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1024 I enter Payment Source Tax Holder Control as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1024entErPaymentSourceTaxHolderControl(string TaxCountry, string TaxHolder, string ApplySpecialTax)
        {
            ExpectToBeInTheScreen("DIVX1024");
            DIVX1024.TaxCtryCode.SetValue(TaxCountry);
            DIVX1024.TaxHolderIdentifier.SetValue(TaxHolder);
            DIVX1024.FundDistTaxInd.SetValue(ApplySpecialTax);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1033 I enter Payment Source Overall Sub Payment Rates as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1033EnterPaymentSourceOverallSubPaymentRates(string PaymentRateDesc, string PaymentRate, string AdditionalRate, string ReportableRate, string CompBreakDown)
        {
            ExpectToBeInTheScreen("DIVX1033");
            DIVX1033.PaymentRateDesc1.SetValue(PaymentRateDesc);
            DIVX1033.PaymentRate1.SetValue(PaymentRate);
            DIVX1033.AdditionalRate1.SetValue(AdditionalRate);
            DIVX1033.ReportableRate1.SetValue(ReportableRate);
            DIVX1033.CompBrkdwnMethod.SetValue(CompBreakDown);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1034 I select Payment Source Nominate Sub Pay Code Components as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1033SelectPaymentSourceNominateSubPayCodeComponents(string Component1, string Component2, string Component3, string Component4, string Component5, string Component6)
        {
            ExpectToBeInTheScreen("DIVX1034");
            DIVX1034.Rn1.SetValue(Component1);
            DIVX1034.Rn2.SetValue(Component2);
            DIVX1034.Rn3.SetValue(Component3);
            DIVX1034.Rn4.SetValue(Component4);
            DIVX1034.Rn5.SetValue(Component5);
            DIVX1034.Rn6.SetValue(Component6);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1035 I enter Payment Source Summary of Payment Components Rates as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1035EnterPaymentSourceSummaryOfPaymentComponentsRates(string ComponentRate1, string ComponentRate2, string Group1, string Group2)
        {
            ExpectToBeInTheScreen("DIVX1035");
            DIVX1035.ComponentRate1.SetValue(ComponentRate1);
            DIVX1035.ComponentRate2.SetValue(ComponentRate2);
            DIVX1035.Group1.SetValue(Group1);
            DIVX1035.Group2.SetValue(Group2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1040 I enter Payment Source Procedure Update details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DIVX1040EnterPaymentSourceProcedureUpdateDetails(string BaseCurrency, string PIApply, string DCRequired, string ForeignChequesApply, string CompanyNamePrint, string ChqStartRefNo)
        {
            ExpectToBeInTheScreen("DIVX1040");
            DIVX1040.BaseCurrency.SetValue(BaseCurrency);
            DIVX1040.DIDCApply.SetValue(PIApply);
            DIVX1040.DcrProcessInd.SetValue(DCRequired);
            DIVX1040.FgnChqApplyInd.SetValue(ForeignChequesApply);
            DIVX1040.CoyNamePrint.SetValue(CompanyNamePrint);
            DIVX1040.ChequesStartRef.SetValue(ChqStartRefNo);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1060 I enter Payment account details as ""(.*)""")]
        public void DIVX1060EnterPaymentAccountDetails(string AddPaymentDetails)
        {
            ExpectToBeInTheScreen("DIVX1060");
            DIVX1060.BuildRequired.SetValue(AddPaymentDetails);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1062 I enter Payment account details as ""(.*)""")]
        public void DIVX1062EnterPaymentAccountDetailsAs(string ReconPaymentAccount)
        {
            ExpectToBeInTheScreen("DIVX1062");
            DIVX1062.ReconAccount.SetValue(ReconPaymentAccount);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In DIVX1082 I enter Dividend Job Details as ""(.*)"" ""(.*)""")]
        public void DIVX1082EnterDividendJobDetailsAs(string OrderNbr, string OperatorInitials)
        {
            ExpectToBeInTheScreen("DIVX1082");
            DIVX1082.OrderNumber.SetValue(OrderNbr);
            DIVX1082.OpsInitials.SetValue(OperatorInitials);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter Fin Password")]
        public void EnterFinPassword()
        {
            ENS01090.Password.SetValue("TEST");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter Fin Password as ""(.*)""")]
        public void EnterFinPassword(string Password)
        {
            ENS01090.Password.SetValue(Password);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter following details in Service Level Reporting Details:")]
        public void EnterfollowingDetailsInServiceLevelReportingDetails(Table data)
        {
            string ServiceProvide = data.GetData("ServiceProvide");
            string ServiceCode = data.GetData("ServiceCode");

            MNS00101.SelectServiceLevel.ClickField();
            MNS00101.ServiceProvider.SetValue(ServiceProvide);
            MNS00101.ServiceCode.SetValue(ServiceCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In JOBSUB03 I enter Job Identification details as below:")]
        public void EnterJobIdentificationDetails(Table data)
        {
            string OrderNbr = data.GetData("OrderNbr");
            string OperatorInitials = data.GetData("OperatorInitials");

            JOBSUB03.OrderNO.SetValue(OrderNbr);
            JOBSUB03.Ident.SetValue(OperatorInitials);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In TNS01102 I enter new TFN value as: ""(.*)""")]
        public void EnterNewTFNValueAs(string TFNValue)
        {
            TNS01102.HolderExemptInd1.SetValue("T");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            TNS01102.Tfn1.ClickField();
            TNS01102.Tfn1.SetValue(TFNValue);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            TNS01102.TfnSuffix1.ClickField();
            TNS01102.TfnSuffix1.SetValue("I"); //TFN for Individual

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit(); //second transmit to confirm TFN even if validation algorithm failed
            Spartan.Core.WinForms.WinFormsDriver.Transmit(); //third transmit to submit new TFN
        }

        [When(@"In TNS00100 I enter OPS initials as ""(.*)""")]
        public void EnterOPSInitialsAs(string opsInitials)
        {
            TNS00100.OpsInitials.SetValue(opsInitials);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In JOBSUB05 I enter Output Options as below:")]
        public void EnterOutputOptions(Table data)
        {
            string PrintOption = data.GetData("PrintOption");
            JOBSUB05.AutoSpool.SetValue(PrintOption);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter following details in Service Level Reporting Details as ""(.*)"" ""(.*)""")]
        public void EnterServiceLevelReportingDetails(string ServiceProvide, string ServiceCode)
        {
            MNS00101.SelectServiceLevel.ClickField();
            MNS00101.ServiceProvider.SetValue(ServiceProvide);
            MNS00101.ServiceCode.SetValue(ServiceCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In CFS00002 I click on the ""(.*)"" menu option")]
        public void EnterSystemControlUpdateOption(string menuoption)
        {
            ExpectToBeInTheScreen("CFS00002");
            switch (menuoption.ToLower())
            {
                case "pst":
                    CFS00002.MenuItemPst.ClickField();
                    break;

                case "sdc":
                    CFS00002.MenuItemSdc.ClickField();
                    break;

                case "scs":
                    CFS00002.MenuItemScs.ClickField();
                    break;

                case "kwd":
                    CFS00002.MenuItemKwd.ClickField();
                    break;

                case "stx":
                    CFS00002.MenuItemStx.ClickField();
                    break;

                case "smg":
                    CFS00002.MenuItemSmg.ClickField();
                    break;

                case "smr":
                    CFS00002.MenuItemSmr.ClickField();
                    break;

                case "sce":
                    CFS00002.MenuItemSce.ClickField();
                    break;

                case "sbd":
                    CFS00002.MenuItemSbd.ClickField();
                    break;

                case "stc":
                    CFS00002.MenuItemStc.ClickField();
                    break;

                case "shc":
                    CFS00002.MenuItemShc.ClickField();
                    break;

                case "src":
                    CFS00002.MenuItemSrc.ClickField();
                    break;

                case "com":
                    CFS00002.MenuItemCom.ClickField();
                    break;

                case "cjr":
                    CFS00002.MenuItemCjr.ClickField();
                    break;

                case "uhf":
                    CFS00002.MenuItemUhf.ClickField();
                    break;

                case "cur":
                    CFS00002.MenuItemCur.ClickField();
                    break;

                case "srv":
                    CFS00002.MenuItemSrv.ClickField();
                    break;

                case "psp":
                    CFS00002.MenuItemPsp.ClickField();
                    break;

                case "sgc":
                    CFS00002.MenuItemSgc.ClickField();
                    break;

                case "sor":
                    CFS00002.MenuItemSor.ClickField();
                    break;

                case "ssf":
                    CFS00002.MenuItemSsf.ClickField();
                    break;

                case "sde":
                    CFS00002.MenuItemSde.ClickField();
                    break;

                case "sbn":
                    CFS00002.MenuItemSbn.ClickField();
                    break;

                case "wtt":
                    CFS00002.MenuItemWtt.ClickField();
                    break;

                case "pss":
                    CFS00002.MenuItemPss.ClickField();
                    break;

                case "ecm":
                    CFS00002.MenuItemEcm.ClickField();
                    break;

                case "fsm":
                    CFS00002.MenuItemFsm.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In SELCOY01 I Enter the following details as the company selection """"(.*)""(.*)""")]
        public void EnterTheFollowingDetailsAsTheCompanySelection(string CoyID, string CoyFilter)
        {
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "ICENFY01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            MNS00101.SelectCompany.ClickField();
            SELCOY01.SelUfd.SetValue(CoyID);
            SELCOY01.CoynameFilter.SetValue(CoyFilter);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "CLOSED01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
        }

        [When(@"In SELVWP00 I enter VWAP details as ""(.*)"" ""(.*)""")]
        public void EnterVWAPDetails(string Class, string Date)
        {
            SELVWP00.InputClassCode.SetValue(Class);
            SELVWP00.InputDate.SetValue(Date);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ERS00100 I click on: ""(.*)"" within the ESS Reporting Menu")]
        public void ERS00100ClickOnWithinTheESSReportingMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "contribution file report":
                    ERS00100.MenuItemCF.ClickField();
                    break;

                case "employee extract report":
                    ERS00100.MenuItemEF.ClickField();
                    break;

                case "purchase reconciliation report":
                    ERS00100.MenuItemER.ClickField();
                    break;

                case "loan report":
                    ERS00100.MenuItemLR.ClickField();
                    break;

                case "transaction movement report":
                    ERS00100.MenuItemTM.ClickField();
                    break;

                case "unprocessed leaver report":
                    ERS00100.MenuItemLV.ClickField();
                    break;

                case "grant report":
                    ERS00100.MenuItemGR.ClickField();
                    break;

                case "vesting report":
                    ERS00100.MenuItemVO.ClickField();
                    break;

                case "exercise report":
                    ERS00100.MenuItemXR.ClickField();
                    break;

                case "cancellation expiry report":
                    ERS00100.MenuItemCE.ClickField();
                    break;

                case "plan contributions purchases allocations report":
                    ERS00100.MenuItemEC.ClickField();
                    break;

                case "plan withdrawals report":
                    ERS00100.MenuItemEW.ClickField();
                    break;

                case "dividend report":
                    ERS00100.MenuItemED.ClickField();
                    break;

                case "unallocated reconciliation report":
                    ERS00100.MenuItemEU.ClickField();
                    break;

                case "trustee reconciliation report":
                    ERS00100.MenuItemTR.ClickField();
                    break;

                case "ess tax reporting":
                    ERS00100.MenuItemTX.ClickField();
                    break;

                case "static withholding details report":
                    ERS00100.MenuItemWD.ClickField();
                    break;

                case "withholding assessment report":
                    ERS00100.MenuItemWA.ClickField();
                    break;

                case "event notification report":
                    ERS00100.MenuItemVN.ClickField();
                    break;

                case "event reconciliation report":
                    ERS00100.MenuItemVR.ClickField();
                    break;

                case "vwap report":
                    ERS00100.MenuItemEV.ClickField();
                    break;

                case "ess housekeeping report":
                    ERS00100.MenuItemHK.ClickField();
                    break;

                case "company client ess housekeeping report":
                    ERS00100.MenuItemHC.ClickField();
                    break;

                case "employee loan plan statement":
                    ERS00100.MenuItemEL.ClickField();
                    break;

                case "employee aess plan statement":
                    ERS00100.MenuItemEM.ClickField();
                    break;

                case "employee option plan statement":
                    ERS00100.MenuItemEE.ClickField();
                    break;

                case "pre 2010 employee tax statements":
                    ERS00100.MenuItemOT.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In ERS00110 I click on: ""(.*)"" within the ESS Tax Reporting Menu")]
        public void ERS00110ClickOnWithinTheESSTaxReportingMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "employee tax statements(standard)":
                    ERS00110.MenuItemET.ClickField();
                    break;

                case "ess ato reporting(non standard)":
                    ERS00110.MenuItemEA.ClickField();
                    break;

                case "ess tax reporting status report":
                    ERS00110.MenuItemTS.ClickField();
                    break;

                case "ess ato provider report":
                    ERS00110.MenuItemPV.ClickField();
                    break;

                case "ess tfn withholding report":
                    ERS00110.MenuItemWH.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"EscapeFromCurrentScreen")]
        [Then(@"I escape from current screen")]
        public void EscapeFromCurrentScreen()
        {
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"I expect to be in the ""(.*)"" Screen")]
        public void ExpectToBeInTheScreen(string screenName)
        {
            //Spartan.Core.WinForms.WinFormsDriver.HardWait(3);

            string currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (currentScreenName.ToLower() != screenName.ToLower() && sw.ElapsedMilliseconds <= 20000)
            {
                currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                System.Threading.Thread.Sleep(100);
            }
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName().ToLower() != screenName.ToLower())
                throw new Exception("Not in the expected screen: " + screenName + "Current screen name is: " + currentScreenName);

        }

        ///<summary>
        ///Set privileges
        ///</summary>
        [When(@"In VMS I expect to see the following:")]
        [Then(@"In VMS I expect to see the following:")]
        public void ExpectToSeeTheFollowing(Table data)
        {
            List<string> exclusions = new List<string>();
            List<string> passCriteria = new List<string>();

            string timeOutString = data.GetData("Timeout", 0);
            TimeSpan timeOut = timeOutString.ConvertToTimeSpan();

            for (int i = 0; i <= data.RowCount - 1; i++)
            {
                string value = data.GetData("Pass Criteria", i);
                passCriteria.Add(value);
            }

            if (data.ContainsColumn("Exclusions"))
            {
                //Run with exclusions
                for (int i = 0; i <= data.RowCount - 1; i++)
                {
                    string value = data.GetData("Exclusions", i);
                    exclusions.Add(value);
                }
                Spartan.Core.Terminal.TerminalDriver.ValidateShellResults(passCriteria, exclusions, timeOut);
            }
            else
            {
                //Run without exclusions
                Spartan.Core.Terminal.TerminalDriver.ValidateShellResults(passCriteria, timeOut);
            }
        }

        [Then(@"In TNS01102 I expect Winforms to show Holder details including ID: ""(.*)"" and TFN Desc: ""(.*)""")]
        public void ExpectWinformsToShowHolderDetailsIncludingIDAndTFNDesc(string holderId, string tfnDesc)
        {
            TNS01102.TfnDesc.ValidateFieldValue(tfnDesc);

            if (holderId.Trim() != TNS01102.HolderIdentifier.GetValue() || tfnDesc.Trim() != TNS01102.TfnDesc.GetValue())
            {
                Console.WriteLine("Expected and actual values do not match. HolderID:" + holderId + " and TFN Desc: " + tfnDesc);
            }
        }

        public void GetCoyFromForm()
        {
            COY = (currentCOY.Substring(currentCOY.Length - 8));
        }

        [When(@"I go to Dividend Payment Parameters setup")]
        public void GoToDividendPaymentParametersSetup()
        {
            ClickWithinTheSystemMenu("system parameter setups");
            ExpectToBeInTheScreen("SPS00101");
            ClickOnWithinTheSystemSetupUpdateMenu("dividend payment parameters");
            ExpectToBeInTheScreen("SPS00102");
            ClickOnWithInTheDividendSystemMenu("dividend payment parameters");
            ExpectToBeInTheScreen("DIVX1001");
        }

        [When(@"I Go to Dividend Plan Maintenance Menu")]
        public void GoToDividendPlanMaintenanceMenu()
        {
            ClickWithinTheSystemMenu("online data entry system");
            ClickOnWithInTheOnlineDataEnterySystemMenu("dividend plan maintenance");
        }

        [When(@"I Go to Merge Holder Transaction Menu")]
        public void GoToMergeHolderTransactionMenu()
        {
            ClickWithinTheSystemMenu("online data entry system");
            ClickOnWithInTheOnlineDataEnterySystemMenu("merge holders transaction");
        }

        [When(@"I go to Payment Enquiry System")]
        public void GoToPaymentEnquirySystem()
        {
            ClickWithinTheSystemMenu("enquiry system");
            ClickOnWithinTheEnquirySystemMenu("payment enquiry system");
        }

        [When(@"I go to Payment Job Release Monitor Menu")]
        public void GoToPaymentJobReleaseMonitorMenu()
        {
            ClickWithinTheSystemMenu("system parameter setups");
            ExpectToBeInTheScreen("SPS00101");
            ClickOnWithinTheSystemSetupUpdateMenu("dividend payment parameters");
            ExpectToBeInTheScreen("SPS00102");
            ClickOnWithInTheDividendSystemMenu("payment job release monitor");
            ExpectToBeInTheScreen("DIS05010");
        }

        [When(@"I go to Reporting System")]
        public void GoToReportingSystem()
        {
            ClickWithinTheSystemMenu("reporting system");
        }

        [When(@"I go to ""(.*)"" in Reporting System")]
        public void GoToReportingSystemSubMenu(string ReportingMenu)
        {
            ClickWithinTheSystemMenu("reporting system");

            switch (ReportingMenu.ToLower())
            {
                case "ess reporting menu":

                    RSS00101.MenuItemES.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"I go to SCRIP main menu from the trading system")]
        public void GoToSCRIPMainMenuFromTheTradingSystem()
        {
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [When(@"I go to Service Level Reporting Details")]
        public void GoToServiceLevelReportingDetails()
        {
            MNS00101.SelectServiceLevel.ClickField();
        }

        [When(@"I go to Statistics Enquiry System")]
        public void GoToStatisticsEnquirySystem()
        {
            ClickWithinTheSystemMenu("enquiry system");
            ClickOnWithinTheEnquirySystemMenu("statistics enquiry");
        }

        [When(@"I go to the Fixups system")]
        public void GoToTheFixupsSystem()
        {
            //Need to Add this in the new Spatan Framework
            //Spartan.Core.WinForms.WinFormsDriver.PressCtlF7();
            ExpectToBeInTheScreen("MSG01000");
            MSG01000.Action.SetValue("FIX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I go to ""(.*)"" Control Code Menu")]
        public void IGoToControlCodeMenu(string Selection)
        {
            ClickWithinTheSystemMenu("housekeeping system");
            ExpectToBeInTheScreen("HKS00101");
            HKS00101.MenuItemCco.ClickField();
            ExpectToBeInTheScreen("HCC00101");
            HCC00101.MenuItemCtl.ClickField();
            ExpectToBeInTheScreen("HCC00102");

            switch (Selection.ToLower())
            {
                case "trading control codes":
                    HCC00102.Selection.SetValue("TCC");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    ExpectToBeInTheScreen("TRD24000");
                    break;

                case "company options":
                    HCC00102.Selection.SetValue("COP");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    ExpectToBeInTheScreen("HKS01500");
                    break;

                case "company notice":
                    HCC00102.Selection.SetValue("NOT");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    ExpectToBeInTheScreen("HKS01900");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    ExpectToBeInTheScreen("HKS01901");
                    break;


                default:
                    break;
            }
        }

        [Given(@"In SELCOY01 I select the company: ""(.*)""")]
        [When(@"In SELCOY01 I select the company: ""(.*)""")]
        public void ISelectTheCompany(string company)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            currentCOY = company;
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "ICENFY01" || formname == "ICENFY02")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            string revVersion = MNS00101.SystemInfoFree3.GetValue();
            Console.WriteLine("Rev Version:{0}", revVersion);
            ExpectToBeInTheScreen("MNS00101");
            MNS00101.Selection.SetValue("SC");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ExpectToBeInTheScreen("SELCOY01");
            SELCOY01.SelUfd.SetValue(company);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "CLOSED01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
        }

        [When(@"In JOBSUB90 I submit the report")]
        public void JOBSUB90SubmitTheReport(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.HardWait(10);
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ExpectToBeInTheScreen("JOBSUB90");
            ReportDesc = JOBSUB90.Desc.GetValue();
            ReportJobNumber = JOBSUB90.JobNODec.GetValue();
            ReportPRNName = JOBSUB90.ParameterID.GetValue();
            ReportPrintFileName = JOBSUB90.PrintID.GetValue();
            currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
            GetCoyFromForm();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if ((table.Rows[0]["DivJobName"]) == "")
            {
                WaitForJobNumber(table);
            }
            else
            {
                WaitForDividendJobNumber(table);
            }
        }

        [When(@"In JOBSUB90 I submit URR report for Dividend Job")]
        public void JOBSUB90SubmitURRReportForDividendJob(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.HardWait(10);
            ExpectToBeInTheScreen("JOBSUB90");
            ReportDesc = JOBSUB90.Desc.GetValue();
            ReportJobNumber = JOBSUB90.JobNODec.GetValue();
            ReportPRNName = JOBSUB90.ParameterID.GetValue();
            ReportPrintFileName = JOBSUB90.PrintID.GetValue();
            currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
            GetCoyFromForm();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            if (ReportPrintFileName.Contains("UR"))
            {
                RSS00101.MenuItemEX.ClickField();
                MNS00101.Selection.SetValue("EX");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                ExpectToBeInTheScreen("MNSEXT");
                //Spartan.Core.WinForms.WinFormsDriver.Transmit();
                //proc = Process.GetProcessesByName("WinForms");
                //if (proc.Length != 0)
                //{
                //    try
                //    {
                //        proc[0].CloseMainWindow();
                //        proc[0].Kill();

                //    }
                //    catch (System.ComponentModel.Win32Exception ex)
                //    {
                //        throw ex;
                //    }
                //}
                Spartan.Core.WinForms.WinFormsDriver.Close();
                WaitForDividendJobNumber(table);
            }
            else
            {
                //Do nothing for now
            }
        }

        [When(@"In HLDADD00 I locate holder as ""(.*)""")]
        public void LocateHolder(string HIN)
        {
            ExpectToBeInTheScreen("FIXUPS");
            FIXUPS.MenuItemHldadd.ClickField();
            ExpectToBeInTheScreen("HLDADD00");
            HLDADD00.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            HLDADD00.ReinitiateSearch.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        //static Winforms_Automation.ConsoleLogger TerminalLogger = new Winforms_Automation.ConsoleLogger();
        ///// <summary>
        ///// Open and logs into backend
        ///// </summary>
        [When(@"I have connected to the Backend")]
        [Given(@"I have connected to the Backend")]
        public void LoginToBackend()
        {
            UsernameBackend = ConfigurationManager.AppSettings["Username"];
            PasswordBackend = ConfigurationManager.AppSettings["Password"];
            SessionBackend = ConfigurationManager.AppSettings["Session"];

            // TerminalLogger.Show();
            // TerminalLogger.Activate();
            // TerminalLogger.BringToFront();
            //  TerminalLogger.ConsolePrint("Attempting to connect to Backend.... This may take a few seconds");
            Spartan.Core.Terminal.TerminalDriver.Connect(UsernameBackend, PasswordBackend, SessionBackend);
        }

        [Given(@"I have connected to WinForms")]
        [When(@"I have connected to WinForms")]
        public void LogInToWinForms()
        {
            WinformConnected = true;

            Username = ConfigurationManager.AppSettings["WinformsUsername"];
            Password = ConfigurationManager.AppSettings["WinformsPassword"];

            Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            if (Environment == null)
            {
                Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            Mode = ConfigurationManager.AppSettings["Mode"];
            if (Mode == null && Environment == "CSSHYC")
            {
                Mode = "RECORD";
            }
            else if (Mode == null && Environment != "CSSHYC")
                Mode = "TEST";

            //Dushan Added this until Peter fix his changes
             KillWF();

            int nProcessID = Spartan.Core.WinForms.WinFormsDriver.Open();
            Spartan.Core.WinForms.WinFormsDriver.Connect(Environment, Username, Password);
            Spartan.Core.WinForms.WinFormsDriver.GetWinformsSlot();
        }

        [Given(@"I have connected to WinForms on ""(.*)""")]
        public void LogInToWinFormsOn(string platform)
        {
            WinformConnected = true;
            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            /*if (platform.ToUpper().Equals("VMS"))
            {
                LogInToWinForms();
            }
            if (platform.ToUpper().Equals("LINUX"))
            {
                Username = ConfigurationManager.AppSettings["LinuxUser"];
                Password = ConfigurationManager.AppSettings["LinuxPassword"];

                Environment = System.Environment.GetEnvironmentVariable("VMHOST");
                if (Environment == null)
                {
                    Environment = ConfigurationManager.AppSettings["LinuxNode"];
                }

                Spartan.Core.WinForms.WinFormsDriver.Open();
                Spartan.Core.WinForms.WinFormsDriver.Connect(Environment, Username, Password);
            }*/

            if (platform.ToUpper().Equals("VMS"))
            {
                hostEnv = "VMS";
                Username = ConfigurationManager.AppSettings["VMSUser"];
                Password = ConfigurationManager.AppSettings["VMSPassword"];

                Environment = ConfigurationManager.AppSettings["VMSNode"];

                Spartan.Core.WinForms.WinFormsDriver.Open();
                Spartan.Core.WinForms.WinFormsDriver.Connect(Environment, Username, Password);
            }
            else if (platform.ToUpper().Equals("LINUX"))
            {
                hostEnv = "LINUX";
                Username = ConfigurationManager.AppSettings["LinuxUser"];
                Password = ConfigurationManager.AppSettings["LinuxPassword"];

                Environment = System.Environment.GetEnvironmentVariable("VMHOST");
                if (Environment == null || Environment.Trim().Equals(""))
                {
                    Environment = ConfigurationManager.AppSettings["LinuxNode"];
                }

                Spartan.Core.WinForms.WinFormsDriver.Open();
                Spartan.Core.WinForms.WinFormsDriver.Connect(Environment, Username, Password);
                Spartan.Core.WinForms.WinFormsDriver.GetWinformsSlot();

            }
        }

        [When(@"I PressESC")]
        public void PressESC()
        {
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
        }

        [When(@"I PressTAB")]
        public void PressTAB()
        {
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
        }

        [When(@"In TNS01001 I search for holder ""(.*)""")]
        public void SearchForHolder(string holderId)
        {
            TNS01001.SearchHolder.SetValue(holderId);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In SELCHA01 I Enter Charity Code as ""(.*)""")]
        public void SELCHA01IEnterCharityCode(string CharityCode)
        {
            ExpectToBeInTheScreen("SELCHA01");
            SELCHA01.Selection.SetValue(CharityCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [Then(@"In SELCOY20 I should see company UFD as:")]
        public void SELCOY20ShouldSeeCompanyUFD(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.HardWait(10);
            ExpectToBeInTheScreen("SELCOY20");
            SELCOY20.Ufd.ValidateFieldValue(1, table.Rows[0]["Ufd1"]);
            SELCOY20.Ufd.ValidateFieldValue(2, table.Rows[0]["Ufd2"]);
            SELCOY20.Ufd.ValidateFieldValue(3, table.Rows[0]["Ufd3"]);
            SELCOY20.Ufd.ValidateFieldValue(4, table.Rows[0]["Ufd4"]);
            SELCOY20.Ufd.ValidateFieldValue(5, table.Rows[0]["Ufd5"]);
        }

        [When(@"In SELCOY01 I select the company as ""(.*)""")]
        public void SelectTheCompany(string company)
        {
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "ICENFY01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            MNS00101.Selection.SetValue("SC");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            SELCOY01.SelUfd.SetValue(company);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "CLOSED01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
        }

        [When(@"I select ""(.*)"" Transaction")]
        public void SelectTransaction(string divTransaction)
        {
            SELTRN20.SelCode.SetValue(divTransaction);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"I should not see Dividend Plan Intentions")]
        public void ShouldNotSeeDividendPlanIntentions()
        {
            ThenIExpectToSeeErrorWithText("No Dividend Plan Intentions exist for this holder");
            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In SELCHA01 I should see Select Charity codes as below:")]
        public void ShouldSeeSelectCharityCodes(Table data)
        {
            string CharityCode1 = data.GetData("CharityCode1");
            string Code1Desc = data.GetData("Code1Desc");
            string CharityCode2 = data.GetData("CharityCode2");
            string Code2Desc = data.GetData("Code2Desc");
            string CharityCode3 = data.GetData("CharityCode3");
            string Code3Desc = data.GetData("Code3Desc");
            string CharityCode4 = data.GetData("CharityCode4");
            string Code4Desc = data.GetData("Code4Desc");
            string CharityCode5 = data.GetData("CharityCode5");
            string Code5Desc = data.GetData("Code5Desc");
            string CharityCode6 = data.GetData("CharityCode6");
            string Code6Desc = data.GetData("Code6Desc");
            string CharityCode7 = data.GetData("CharityCode7");
            string Code7Desc = data.GetData("Code7Desc");
            string CharityCode8 = data.GetData("CharityCode8");
            string Code8Desc = data.GetData("Code8Desc");
            string CharityCode9 = data.GetData("CharityCode9");
            string Code9Desc = data.GetData("Code9Desc");
            string CharityCode10 = data.GetData("CharityCode10");
            string Code10Desc = data.GetData("Code10Desc");

            SELCHA01.CharityCode.ValidateFieldValue(1, CharityCode1);
            SELCHA01.CharityDesc.ValidateFieldValue(1, Code1Desc);
            SELCHA01.CharityCode.ValidateFieldValue(2, CharityCode2);
            SELCHA01.CharityDesc.ValidateFieldValue(2, Code2Desc);
            SELCHA01.CharityCode.ValidateFieldValue(3, CharityCode3);
            SELCHA01.CharityDesc.ValidateFieldValue(3, Code3Desc);
            SELCHA01.CharityCode.ValidateFieldValue(4, CharityCode4);
            SELCHA01.CharityDesc.ValidateFieldValue(4, Code4Desc);
            SELCHA01.CharityCode.ValidateFieldValue(5, CharityCode5);
            SELCHA01.CharityDesc.ValidateFieldValue(5, Code5Desc);
            SELCHA01.CharityCode.ValidateFieldValue(6, CharityCode6);
            SELCHA01.CharityDesc.ValidateFieldValue(6, Code6Desc);
            SELCHA01.CharityCode.ValidateFieldValue(7, CharityCode7);
            SELCHA01.CharityDesc.ValidateFieldValue(7, Code7Desc);
            SELCHA01.CharityCode.ValidateFieldValue(8, CharityCode8);
            SELCHA01.CharityDesc.ValidateFieldValue(8, Code8Desc);
            SELCHA01.CharityCode.ValidateFieldValue(9, CharityCode9);
            SELCHA01.CharityDesc.ValidateFieldValue(9, Code9Desc);
            SELCHA01.CharityCode.ValidateFieldValue(10, CharityCode10);
            SELCHA01.CharityDesc.ValidateFieldValue(10, Code10Desc);
        }

        [Then(@"In SELPRV01 I should see Select Service Provide details as below:")]
        public void ShouldSeeSelectServiceProvideDetails(Table data)
        {
            string Provider1 = data.GetData("Provider1");
            string Provider1Desc = data.GetData("Provider1Desc");
            string Provider2 = data.GetData("Provider2");
            string Provider2Desc = data.GetData("Provider2Desc");
            string Provider3 = data.GetData("Provider3");
            string Provider3Desc = data.GetData("Provider3Desc");
            string Provider4 = data.GetData("Provider4");
            string Provider4Desc = data.GetData("Provider4Desc");
            string Provider5 = data.GetData("Provider5");
            string Provider5Desc = data.GetData("Provider5Desc");
            string Provider6 = data.GetData("Provider6");
            string Provider6Desc = data.GetData("Provider6Desc");
            string Provider7 = data.GetData("Provider7");
            string Provider7Desc = data.GetData("Provider7Desc");

            ExpectToBeInTheScreen("SELPRV01");
            SELPRV01.Provider.ValidateFieldValue(1, Provider1);
            SELPRV01.Desc.ValidateFieldValue(1, Provider1Desc);
            SELPRV01.Provider.ValidateFieldValue(2, Provider2);
            SELPRV01.Desc.ValidateFieldValue(2, Provider2Desc);
            SELPRV01.Provider.ValidateFieldValue(3, Provider3);
            SELPRV01.Desc.ValidateFieldValue(3, Provider3Desc);
            SELPRV01.Provider.ValidateFieldValue(4, Provider4);
            SELPRV01.Desc.ValidateFieldValue(4, Provider4Desc);
            SELPRV01.Provider.ValidateFieldValue(5, Provider5);
            SELPRV01.Desc.ValidateFieldValue(5, Provider5Desc);
            SELPRV01.Provider.ValidateFieldValue(6, Provider6);
            SELPRV01.Desc.ValidateFieldValue(6, Provider6Desc);
            SELPRV01.Provider.ValidateFieldValue(7, Provider7);
            SELPRV01.Desc.ValidateFieldValue(7, Provider7Desc);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In SELVWP01 I should see VWAP details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeVWAPDetails(string Class, string ISIN, string Exchange, string Currency, string Date, string OneDayVWAP, string MultiDayVWAP, string OneDayVolume, string ClosingPrice)
        {
            ExpectToBeInTheScreen("SELVWP01");
            SELVWP01.FinalSecurity.ValidateFieldValue(Class);
            SELVWP01.IsinNumber.ValidateFieldValue(ISIN);
            SELVWP01.ExchangeCode.ValidateFieldValue(Exchange);
            SELVWP01.CurrencyCode.ValidateFieldValue(Currency);
            SELVWP01.VwapDate.ValidateFieldValue(Date);
            SELVWP01.day1Vwap.ValidateFieldValue(OneDayVWAP);
            SELVWP01.MultiDayVwap.ValidateFieldValue(MultiDayVWAP);
            SELVWP01.day1TradeVolume.ValidateFieldValue(OneDayVolume);
            SELVWP01.ClosingPrice.ValidateFieldValue(ClosingPrice);
        }

        [Then(@"I expect WinForms to show im ICED to: ""(.*)""")]
        public void ShowICE(string environment)
        {
            ICENFY01.SearchRule.ValidateFieldValue(environment);
            Spartan.Core.WinForms.WinFormsDriver.Transmit(); //get rid of the splash screen
        }

        [When(@"In SPS00101 I click on: ""(.*)"" within the system Menu")]
        public void SPS00101clickOnWithinTheSystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "dividend payment parameters":
                    SPS00101.MenuItemDiv.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SPS00102");
                    break;

                case "TKO. takeover system parameters":
                    SPS00101.MenuItemTko.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("SPS00104");
                    break;

                case "allotment system parameters":
                    SPS00101.MenuItemAlt.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("ALS01001");
                    break;

                default:
                    break;
            }
        }

        [When(@"In SPS00102 I click on: ""(.*)"" within the system Menu")]
        public void SPS00102clickOnWithinTheSystemMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "dividend payment parameters":
                    SPS00102.MenuItemDpp.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("DIVX1001");
                    break;

                case "payment job release monitor":
                    SPS00102.MenuItemPjm.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("DIS05010");
                    break;

                case "define enquire on payment account":
                    SPS00102.MenuItemDfa.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    ExpectToBeInTheScreen("PAS01000");
                    break;

                default:
                    break;
            }
        }

        [Then(@"I expect to see error with text ""(.*)""")]
        public void ThenIExpectToSeeErrorWithText(string errorText)
        {
            Spartan.Core.WinForms.WinFormsDriver.HardWait(5);
            if (!Spartan.Core.WinForms.WinFormsDriver.CheckForError(errorText))
            {
                //Spartan.Core.WinForms.WinFormsDriver.GetScreenLines();
                throw new Exception("Expected error with text: " + errorText + " has not been found");
            }
            else
            {
                Spartan.Core.WinForms.WinFormsDriver.PressEnter();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(3);
            }
        }

        [Then(@"In HLDADD01 I should see FIN details as ""(.*)""")]
        public void ThenInHLDADDIShouldSeeFINDetailsAs(string PinNumber)
        {
            ExpectToBeInTheScreen("HLDADD01");
            HLDADD01.PinNumber.ValidateFieldValue(PinNumber);
        }

        [Then(@"In SELSRV01 I should see Select Service Provide details as below:")]
        public void ThenInSELSRVIShouldSeeSelectServiceProvideDetailsAsBelow(Table data)
        {
            string Service1 = data.GetData("Service1");
            string Service1Desc = data.GetData("Service1Desc");
            string Service2 = data.GetData("Service2");
            string Service2Desc = data.GetData("Service2Desc");

            ExpectToBeInTheScreen("SELSRV01");
            SELSRV01.Code.ValidateFieldValue(1, Service1);
            SELSRV01.Desc.ValidateFieldValue(1, Service1Desc);
            SELSRV01.Code.ValidateFieldValue(2, Service2);
            SELSRV01.Desc.ValidateFieldValue(2, Service2Desc);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"I should see the below ErrorMessage ""(.*)""")]
        public void ThenIShouldSeeTheBelowErrorMessage(string ErrorMsg)
        {
            Spartan.Core.WinForms.WinFormsDriver.HardWait(3);
            Spartan.Core.WinForms.WinFormsDriver.CheckForError(ErrorMsg);
            //ThenIExpectToSeeErrorWithText(ErrorMsg);
        }

        [When(@"I Transmit")]
        public void Transmit()
        {
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"Wait For Dividend Job Number")]
        public void WaitForDividendJobNumber(Table table)
        {
            string host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            //var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = "CSSHYC";
            }
            if (host == "CSSHYC")
            {
                using (var sshClient = new SshClient(host, "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    var cmd = sshClient.RunCommand("sh ent " + ReportJobNumber);
                    var output = cmd.Result;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                    {
                        cmd = sshClient.RunCommand("sh ent  " + ReportJobNumber);
                        output = cmd.Result;
                    }
                    sw.Stop();

                    if (!output.Contains(table.Rows[0]["PassCriteria"]))
                    {
                        throw new Exception("Report Timeout or failed criteria was found" + output);
                    }

                    if (table.Rows[0]["DivJobName"].Contains("DIV_END_CALC") || table.Rows[0]["DivJobName"].Contains("DIV_DIVLST"))
                    {
                        //Cannot find the job number table.Rows[0]["DivJobName"] as there will be multiple jobswith the same name.

                        if (table.Rows[0]["DivJobName1"].Contains("DIV_PLNALT"))
                        {
                            DateTime thisDay = DateTime.Now;
                            PlnAuthorisationRef = thisDay.ToString("HHmmdd");
                        }
                        cmd = sshClient.RunCommand("sh ent " + table.Rows[0]["DivJobName"] + " /BY_JOB_STATUS=Pending");
                        output = cmd.Result;
                        string outputEdit = output.Substring(0, output.IndexOf(table.Rows[0]["DivJobName"]));
                        outputEdit = outputEdit.Substring(outputEdit.LastIndexOf("\r\n") + 2);
                        sw.Start();

                        while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                        {
                            cmd = sshClient.RunCommand("sh ent " + outputEdit);
                            output = cmd.Result;
                        }
                        //DateTime thisDay = DateTime.Now;
                        //PlnAuthorisationRef = thisDay.ToString("HHmmdd");
                        sw.Stop();

                        if (!output.Contains(table.Rows[0]["PassCriteria"]))
                        {
                            throw new Exception("Dividend job timeout or failed criteria was found" + outputEdit);
                        }
                    }
                    if (table.Rows[0]["DivJobName"].Contains("DIV_PAY_COMBINE"))
                    {
                        //Cannot find the job number table.Rows[0]["DivJobName"] as there will be multiple jobswith the same name.
                        cmd = sshClient.RunCommand("sh ent " + table.Rows[0]["DivJobName"] + " /BY_JOB_STATUS=executing");
                        output = cmd.Result;
                        string outputEdit = output.Substring(0, output.IndexOf(table.Rows[0]["DivJobName"]));
                        outputEdit = outputEdit.Substring(outputEdit.LastIndexOf("\r\n") + 2);
                        sw.Start();

                        while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                        {
                            cmd = sshClient.RunCommand("sh ent " + outputEdit);
                            output = cmd.Result;
                        }
                        sw.Stop();

                        if (!output.Contains(table.Rows[0]["PassCriteria"]))
                        {
                            throw new Exception("Dividend job timeout or failed criteria was found" + outputEdit);
                        }
                    }
                }
            }
            else
            {
                using (var sshClient = new SshClient(host, "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    var cmd = sshClient.RunCommand("job show  " + JobNumber);
                    var output = cmd.Result;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteriaLNX"]) && !output.Contains(table.Rows[0]["FailCriteriaLNX"]))
                    {
                        cmd = sshClient.RunCommand("job show  " + JobNumber);
                        output = cmd.Result;
                    }
                    sw.Stop();

                    if (!output.Contains(table.Rows[0]["PassCriteriaLNX"]))
                    {
                        throw new Exception("Report Timeout or failed criteria was found" + output);
                    }
                }
            }
        }

        /// <param name="table">data table</param>
        [When(@"I wait for  GenerateOutput job to complete")]
        public void WaitForGenerateOutputJobToComplete(Table table)
        {
            WaitForJobNumber(table);
        }

        /// <param name="table">data table</param>
        [When(@"Wait For Job Number")]
        public void WaitForJobNumber(Table table)
        {
            //string host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            var host = System.Environment.GetEnvironmentVariable("VMHOST");

            //temporarry done to debug the code
            if (host == null)
            {
                if (hostEnv == "VMS" || hostEnv == "")
                {
                    host = "CSSHYC";
                }
                else
                {
                    host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
                }
            }

            if (host == "CSSHYC")
            {
                using (var sshClient = new SshClient(host, "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    var cmd = sshClient.RunCommand("sh ent " + ReportingTestSteps.ReportJobNumber);
                    var output = cmd.Result;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                    {
                        cmd = sshClient.RunCommand("sh ent  " + ReportingTestSteps.ReportJobNumber);
                        output = cmd.Result;
                    }
                    sw.Stop();

                    if (!output.Contains(table.Rows[0]["PassCriteria"]))
                    {
                        throw new Exception("Report Timeout or failed criteria was found" + output);
                    }
                }
            }
            else
            {
                using (var sshClient = new SshClient(host, "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    var cmd = sshClient.RunCommand("job show  " + ReportingTestSteps.ReportJobNumber);
                    var output = cmd.Result;
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteriaLNX"]) && !output.Contains(table.Rows[0]["FailCriteriaLNX"]))
                    {
                        cmd = sshClient.RunCommand("job show  " + ReportingTestSteps.ReportJobNumber);
                        output = cmd.Result;
                    }
                    sw.Stop();

                    if (!output.Contains(table.Rows[0]["PassCriteriaLNX"]))
                    {
                        throw new Exception("Report Timeout or failed criteria was found" + output);
                    }
                }
            }
        }

        [When(@"I merge holder as below:")]
        public void WhenIMergeHolder(Table data)
        {
            string TranNo = data.GetData("Tran No");
            string FromHIN = data.GetData("From Holder");
            string ToHIN = data.GetData("To Holder");

            OLS03301.TranNumber.SetValue(TranNo);
            OLS03301.FromNameKey.SetValue(FromHIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ExpectToBeInTheScreen("OLS03302");

            OLS03302.TONameKey.SetValue(ToHIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("OLS03303");
            OLS03303.FromHolderID.ValidateFieldValue(FromHIN);
            OLS03303.TOHolderID.ValidateFieldValue(ToHIN);
            OLS03303.Action.SetValue("UPDATE");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(120);
            ExpectToBeInTheScreen("OLS03301");

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.MenuItemEX.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(5);
        }

        [When(@"In DIVX1013 I enter Payment Control setup as ""(.*)""")]
        public void WhenInDIVXIEnterPaymentControlSetupAs(string ClassDesc)
        {
            ExpectToBeInTheScreen("DIVX1013");
            DIVX1013.ClsDsc1.SetValue(ClassDesc);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In VMS I run command ""(.*)""")]
        public void WhenInVMSIRunCommand(string command)
        {
            Spartan.Core.Terminal.TerminalDriver.SendShellCommand(command);
        }

        [When(@"In TRDRSP00 I click on: ""(.*)"" with in the Trading System Reporting Menu")]
        public void TRDRSP00IClickOnWithInTheTradingSystemReportingMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "trade order transaction report":
                    TRDRSP00.MenuItemTtr.ClickField();
                    ExpectToBeInTheScreen("TRDRSP11");
                    break;

                case "company trade order report":
                    TRDRSP00.MenuItemCor.ClickField();
                    ExpectToBeInTheScreen("TRDRSP01");
                    break;

                case "trade control housekeeping report":
                    TRDRSP00.MenuItemTch.ClickField();
                    ExpectToBeInTheScreen("TRDRSP12");
                    break;

                case "company trade control housekeeping report":
                    TRDRSP00.MenuItemTcc.ClickField();
                    ExpectToBeInTheScreen("TRDRSP12");
                    break;

                case "commission code housekeeping report":
                    TRDRSP00.MenuItemCch.ClickField();
                    ExpectToBeInTheScreen("TRDRSP13");
                    break;

                case "company commission code housekeeping report":
                    TRDRSP00.MenuItemCcc.ClickField();
                    ExpectToBeInTheScreen("TRDRSP13");
                    break;
                default:
                    TRDRSP00.MenuItemEX.ClickField();
                    ExpectToBeInTheScreen("RSS00101");
                    break;

            }
        }

        [When(@"I Escape to the Main Menu from Employee Processing")]
        public void EscapeToTheMainMenuFromEmployeeProcessing()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("EOL00126"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            }
            TRDMNU01.MenuItemEX.ClickField();
            ExpectToBeInTheScreen("MNS00101");
        }

        [When(@"I go to the Bulk Processing System and select Bulk code as:")]
        public void GoToTheBulkProcessingSystemAndSelectBulkCode(Table table)
        {
            ExpectToBeInTheScreen("MNS00101");
            MNS00101.Selection.SetValue("BP");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("BLK00101");
            BLK00101.Selection.SetValue("BLK");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("OLSBLK01");

            while (!OLSBLK01.BulkCode.GetValue().ToUpper().Split('\r', '\n').Contains(table.Rows[0]["BulkCode"]))
            {
                OLSBLK01.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                ExpectToBeInTheScreen("OLSBLK01");
            }

            OLSBLK01.Selection.SetValue(1, table.Rows[0]["BulkCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("OLSBLK02");

        }

        [When(@"I Escape to the Main Menu from Bulk Processing")]
        public void EscapeToTheMainMenuFromBulkProcessing()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("BLK00101"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            }
            TRDMNU01.MenuItemEX.ClickField();
            ExpectToBeInTheScreen("MNS00101");
        }


        [When(@"I Exit from Winforms from Reporting Menu")]
        public void ExitFromWinformsFromReportingMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("RSS00101"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            }
            RSS00101.MenuItemEX.ClickField();
            ExpectToBeInTheScreen("MNS00101");

            MNS00101.Selection.SetValue("EX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("MNSEXT");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"I Exit from System Setup Menu")]
        public void ExitFromSystemSetupMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("SPS00101"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
            SPS00101.MenuItemEX.ClickField();
            ExpectToBeInTheScreen("MNS00101");

            MNS00101.Selection.SetValue("EX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ExpectToBeInTheScreen("MNSEXT");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"I Go to the Mainmenu from System Setup Menu")]
        public void GoToTheMainmenuFromSystemSetupMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("SPS00101"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
            SPS00101.MenuItemEX.ClickField();
            ExpectToBeInTheScreen("MNS00101");
        }

        [When(@"wait")]
        public void Wait(Table table)
        {
            int waitTime = Int32.Parse(table.Rows[0]["seconds"]);
            Spartan.Core.WinForms.WinFormsDriver.HardWait(waitTime);

        }


        [When(@"In CFS00001 I continue as:")]
        public void WhenInCFSIContinueAs(Table table)
        {

            string ReinitiateSearch = table.Rows[0]["SearchUfdsel"];
            string[] thisArray = ReinitiateSearch.Split(',');
            List<string> myList = new List<string>();
            myList.AddRange(thisArray);

            for (var i = 0; i < myList.Count; i++)
            {

                ExpectToBeInTheScreen("CFS00001");
                CFS00001.MenuItemScc.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                CFS00400.Action.SetValue("S");
                CFS00400.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                CFS00401.SearchUfdsel.SetValue(myList[i]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                ExpectToBeInTheScreen("CFS00401");
                CFS00401.Action.SetValue("C");
                CFS00401.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                ExpectToBeInTheScreen("CFS00402");


                if (CFS00402.CosmosUploadInd.Exists()== true)
                {
                    var _CosmosUploadInd = CFS00402.CosmosUploadInd.GetValue();

                    if (_CosmosUploadInd.ToLower() == "n" )
                    {
                        CFS00402.CosmosUploadInd.SetValue("Y");
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        var _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                        if (_formName == "CFS00409")
                        {
                            CFS00409.Action.SetValue("Y");
                            Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        }
                        ExpectToBeInTheScreen("CFS00401");
                        Spartan.Core.WinForms.WinFormsDriver.PressESC();
                        Spartan.Core.WinForms.WinFormsDriver.PressESC();
                        ExpectToBeInTheScreen("CFS00001");
                    }
                    else
                    {
                        Spartan.Core.WinForms.WinFormsDriver.PressESC();
                        Spartan.Core.WinForms.WinFormsDriver.PressESC();
                        Spartan.Core.WinForms.WinFormsDriver.PressESC();
                        ExpectToBeInTheScreen("CFS00001");
                    }

                }
                else
                {
                    Spartan.Core.WinForms.WinFormsDriver.PressESC();
                    Spartan.Core.WinForms.WinFormsDriver.PressESC();
                    Spartan.Core.WinForms.WinFormsDriver.PressESC();
                    ExpectToBeInTheScreen("CFS00001");
                }


            }

        }

        [Then(@"I exit to main from online system")]
        [When(@"I exit to main from online system")]
        public void IExitToMainFromOnlineSystem()
        {
            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            while (formName != "OLS00101")
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            ExpectToBeInTheScreen("OLS00101");
            OLS00101.MenuItemEX.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ExpectToBeInTheScreen("MNS00101");


        }

        [Then(@"I exit to main from enquiry system")]
        public void IExitToMainFromEnquirySystem()
        {
            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            while (formName != "ENS00101")
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            ExpectToBeInTheScreen("ENS00101");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ENS00101.MenuItemEX.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            ExpectToBeInTheScreen("MNS00101");
        }


    }
}