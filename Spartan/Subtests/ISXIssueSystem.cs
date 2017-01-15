using System;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Configuration;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Renci.SshNet;
using NUnit;
using NUnit.Framework;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class ISXIssueSystem
    {
        private static string currentDateTime;
        private static string Timestamps = "";

        public ISXIssueSystem()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
            this.SSHManager = new SSHManager();
            this.ReportingTestSteps = new ReportingTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }
        public SSHManager SSHManager { get; set; }

        public ReportingTestSteps ReportingTestSteps { get; set; }

        [When(@"In ISX01002 I update Issue Parameter Setup as")]
        public void ISX01002UpdateIssueParameterSetup(Table table)
        {

            WinFormsTestSteps.ClickWithinTheSystemMenu("system parameter setups");
            SPS00101.MenuItemIsx.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01002");
            ISX01002.MenuItemIps.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01001");
            ISX01001.Action.SetValue(table.Rows[0]["Action"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01010");
            ISX01010.Action.SetValue(table.Rows[0]["Action1"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01011");
            ISX01010.RepDate.SetValue(table.Rows[0]["RepDate"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ACCPAR01");

            DateTime today = DateTime.Today.AddDays(5);
            var CurrentDate = today.ToString("dd/MM/yyyy");

            ACCPAR01.ActiveDateTO.SetValue(CurrentDate);
            ACCPAR01.RemProcessEndDate.SetValue(CurrentDate);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ACCPAR02");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01045");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01050");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01055");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (formName == "ISX01075")
                WinFormsTestSteps.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01060");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01070");
            ISX01070.OrderNumber.SetValue(table.Rows[0]["OrderNumber"]);
            ISX01070.OpsInitials.SetValue(table.Rows[0]["OpsInitials"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01080");
           
        }

        [When(@"In ISX01001 I continue with Issue Caclulation Process as:")]
        public void ISX01001ContinueWithIssueCaclulationProcess(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
            SPS00101.MenuItemIsx.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00102");
            ISX01002.MenuItemIcp.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01001");
            ISX01001.Action.SetValue(table.Rows[0]["Action"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01004");
            ISX01004.Action.SetValue(table.Rows[0]["Action"]);
        }

        [When(@"In ISX01001 I go to Issue Calculation Process")]
        public void ISX01001GoToIssueCalculationProcess()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("system parameter setups");
            SPS00101.MenuItemIsx.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01002");
            ISX01002.MenuItemIcp.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01001");

        }

        [When(@"In ISX01001 I continue with the following details")]
        public void ISX01001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01001");
            ISX01001.Action.SetValue(table.Rows[0]["Action"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01004");

        }

        [When(@"In ISX01004 I continue with the following details")]
        public void ISX01004ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ISX01004");
            ISX01004.Action.SetValue(table.Rows[0]["Action"]);
            WinFormsTestSteps.Transmit();
            //WinFormsTestSteps.ExpectToBeInTheScreen("ISX01005");
        }

        [When(@"In ISX01005 I continue with the following details")]
        public void ISX01005ContinueWithTheFollowingDetails(Table table)
        {
            var Action = table.Rows[0]["Action"];
            switch (Action)
            {
                case "ICT":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ISX01005");
                    ISX01005.Proceed.SetValue(table.Rows[0]["Proceed"]);
                    WinFormsTestSteps.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
                    break;

                case "ICN":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ISX01006");
                    ReadAuthorisationPasswordfromISXTOT(table);
                    ISX01006.Password.SetValue(Timestamps);
                    WinFormsTestSteps.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");

                    break;

                case "ICB":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ISX01007");
                    //ReadAuthorisationPasswordfromISXTOT(table);
                    ISX01007.Password.SetValue(Timestamps);
                    WinFormsTestSteps.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");

                    break;

            }


        }

        public void ReadAuthorisationPasswordfromISXTOT(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                VMSReadAuthorisationPasswordfromISXTOT(table);
            }
            else
            {
                //LinuxReadAuthorisationPasswordfromISXTOT(table);
            }
            
        }

        public void VMSReadAuthorisationPasswordfromISXTOT(Table table)
        {
            var ReportPrintFileName = "$ISXTOT_ISX"+ table.Rows[0]["ISXDir"] + ".PRN";
            var currentCOY = table.Rows[0]["COY"];
            var ISXDIr = table.Rows[0]["ISXDir"];

            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    char cs = (char)34;

                    String str = "pipe sc " + currentCOY + " && set def [.isx" + ISXDIr + "] && search " + ReportPrintFileName + " " + cs + "authorisation password" + cs+ " /win=(0,1)";
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    Timestamps = output;

                    Timestamps = Timestamps.Replace("*****\r\n***** \u001b[1mAUTHORISATION PASSWORD\u001b[0m **************\r\n", " ");

                    int start = Timestamps.IndexOf("*****\r\n*****") + 14;
                    int end = Timestamps.IndexOf("**************\r\n\r", start);
                    Timestamps = Timestamps.Substring(start, end - start);
                    Timestamps = Timestamps.Trim();
                    Console.WriteLine("Authorisation Password: " + Timestamps);
                    sshClient.Disconnect();
                }
            }
        }









    }
}