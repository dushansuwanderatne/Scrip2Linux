using System;
using System.Configuration;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class AllotmentSubtests
    {
        private static string currentDateTime;

        public AllotmentSubtests()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
            this.SSHManager = new SSHManager();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }
        public SSHManager SSHManager { get; set; }


        [When(@"In ALS01001 I continue with the following details:")]
        public void ALS01001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01001");
            ALS01001.AllotmentNum.SetValue(1, table.Rows[0]["AllotmentNum"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In ALS01010 I continue with the following details:")]
        public void ALS01010ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01010");
            ALS01010.RepDate.SetValue(1, table.Rows[0]["RepDate"]);
            ALS01010.PrintHolderID.SetValue(1, table.Rows[0]["PrintHolderID"]);
            ALS01010.BCRunNumber.SetValue(1, table.Rows[0]["BCRunNumber"]);
            ALS01010.XtrFilname.SetValue(1, table.Rows[0]["XtrFilname"]);
            ALS01010.AllotmentType.SetValue(1, table.Rows[0]["AllotmentType"]);
            ALS01010.ProcessType.SetValue(1, table.Rows[0]["ProcessType"]);
            ALS01010.ReturnMail.SetValue(1, table.Rows[0]["ReturnMail"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In ALS01025 I continue with the following details:")]
        public void ALS01025ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01025");
            ALS01025.ScripSeq.SetValue(1, table.Rows[0]["ScripSeq"]);
            ALS01025.ScripComment40.SetValue(1, table.Rows[0]["ScripComment40A"]);
            ALS01025.ScripComment40.SetValue(2, table.Rows[0]["ScripComment40B"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In ALS01028 I continue with the following details:")]
        public void ALS01028ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01028");
            ALS01028.CNAllotmentDate.SetValue(1, table.Rows[0]["CNAllotmentDate"]);
            ALS01028.BuildDeferDate.SetValue(1, table.Rows[0]["BuildDeferDate"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In ALS01030 I continue with the following details:")]
        public void ALS01030ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01030");
            ALS01030.OrderNumber.SetValue(1, table.Rows[0]["OrderNumber"]);
            ALS01030.OpsInitials.SetValue(1, table.Rows[0]["OpsInitials"]);
            ALS01030.Description.SetValue(1, table.Rows[0]["Description"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In BILCTL99 I continue with the following details:")]
        public void BILCTL99ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BILCTL99");
            BILCTL99.ServiceProvider.SetValue(1, table.Rows[0]["ServiceProvider"]);
            BILCTL99.ServiceCode.SetValue(1, table.Rows[0]["ServiceCode"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [Then(@"In ALS01040 I verify the following details:")]
        public void ALS01040VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01040");
            ALS01040.FirstAltClass.ValidateFieldValue(1, table.Rows[0]["FirstAltClass"]);
            ALS01040.FirstAltClassDesc.ValidateFieldValue(1, table.Rows[0]["FirstAltClassDesc"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01050");
            WinFormsTestSteps.PressESC();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
        }

        [When(@"In ALS01020 I continue with the following details:")]
        public void ALS01020ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ALS01020");
            ALS01020.Selcls.SetValue(1, table.Rows[0]["Selcls1"]);
            ALS01020.Selcls.SetValue(2, table.Rows[0]["Selcls2"]);
            ALS01020.Selreg01.SetValue(1, table.Rows[0]["Selreg01"]);
            ALS01020.Selreg02.SetValue(1, table.Rows[0]["Selreg02"]);
            ALS01020.DeductSelcls.SetValue(1, table.Rows[0]["DeductSelcls"]);
            ALS01020.ScripReq.SetValue(1, table.Rows[0]["ScripReq"]);
            ALS01020.FirstAltClass.SetValue(1, table.Rows[0]["FirstAltClass"]);
            ALS01020.SecondAltClass.SetValue(1, table.Rows[0]["SecondAltClass"]);
            ALS01020.TranTypeCode.SetValue(1, table.Rows[0]["TranTypeCode"]);
            ALS01020.CertInd.SetValue(1, table.Rows[0]["CertInd"]);
            ALS01020.AllotmentRegister.SetValue(1, table.Rows[0]["AllotmentRegister"]);
            ALS01020.NspRequiredInd.SetValue(1, table.Rows[0]["NspRequiredInd"]);
            ALS01020.EomSelectionCode.SetValue(1, table.Rows[0]["EomSelectionCode"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"I continue with the following details for Allotments in nhk_menu:")]
        public void ContinueWithTheFollowingDetailsForAllotmentsInNhk_Menu(Table table)
        {

            if (WinFormsTestSteps.Environment == "CSSHYC")
                BuildAllotmentsNhk_MenuVMS(table);
            else
                BuildAllotmentsNhk_MenuLinux(table);

        }


        [When(@"I release Allotment jobs:")]
        public void ReleaseAllotmentJobs(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
                ReleaseAllotmentJobsVMS(table);
            else
                ReleaseAllotmentJobsLinux(table);


        }
        public void BuildAllotmentsNhk_MenuVMS(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);


            SSHManager.SendShellCommand("sc " + currentCOY, host, new List<String>(), new List<String>());

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("nhk_menu", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("ops", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sstp", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("alt", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria5"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("n", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.Disconnect();
        }

        public void BuildAllotmentsNhk_MenuLinux(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);


            SSHManager.SendShellCommand("sc " + currentCOY, host, new List<String>(), new List<String>());

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaLnx1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("nhk", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaLnx2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("opsm", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaLnx3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sstp", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("alt", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria5"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.Disconnect();

        }


        public void ReleaseAllotmentJobsVMS(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sc " + currentCOY, host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sd " + table.Rows[0]["AllotmentName"], host, passCriteria, failCriteria);


            //releasing ALT1_CALC_QBE_AUTO.COM job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["JobName1"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());

            //releasing ALT1_CHESS_NOTICE_QBE_AUTO.COM job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria6"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["JobName2"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());

            //releasing ALT1_COMBINE_QBE_AUTO.COM job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria7"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["JobName3"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


            SSHManager.Disconnect();

        }


        public void ReleaseAllotmentJobsLinux(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sc " + currentCOY, host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            SSHManager.SendShellCommand("cd " + table.Rows[0]["AllotmentName"], host, new List<String>(), new List<String>());

            //releasing ALT1_CALC_QBE_AUTO.COM job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaJobLnx1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + table.Rows[0]["JobNameLnx1"], host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


            //releasing alt1_chess_notice_qbe_auto.sh job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaJobLnx1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + table.Rows[0]["JobNameLnx2"], host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


            //releasing alt1_combine_qbe_auto.sh job
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["passCriteriaJobLnx1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + table.Rows[0]["JobNameLnx3"], host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());


        }



    }
}