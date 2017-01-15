using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Renci.SshNet;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Text;
using System.Collections.Generic;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class ReportingTestSteps
    {
        public static string ReportPrintFileName;
        private static string ReportDesc;
        public static string ReportJobNumber;
        public static string ReportPRNName;
        public static string TempReportPrintFileName = "";
        private static Process[] proc = null;
        private static string currentCOY;
        private static string COY;
        private static string ORDERNUM;
        private static string Report;
        private int vmsFileCount = 0;
        private int linuxFileCount = 0;
        private static string LinuxReportDir;
        private static string VMSReportDir;
        public static bool TradingReport = false;
        public static string Timestamps;
        public int FileCount = 0;
        public int FailCount = 0;

        private SshClient client;
        private ShellStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private String[] resultArray;
        private String strTestCaseFailReason;
        private string host;
        private string username;
        private string pwd;
        public static DateTime ReportRunTime;
        public static string ReportTime;




        enum TestDestination
        {
            VMS = 0,
            LINUX = 1
        }

        public ReportingTestSteps()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
            this.SSHManager = new SSHManager();
        }
        public WinFormsTestSteps WinFormsTestSteps { get; set; }
        public SSHManager SSHManager { get; set; }


    //[BeforeScenario]
    //public void DisconectTerminalLogger()
    //{
    //    proc = Process.GetProcessesByName("Spartan.Core.TerminalLogger");
    //    if (proc.Length != 0)
    //    {
    //        try
    //        {
    //            proc[0].CloseMainWindow();
    //            proc[0].Kill();
    //        }
    //        catch (System.ComponentModel.Win32Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }
    //}

    /// <param name="table">data table</param>
    [Given(@"In RSS02010 I continue with the following details:")]
        [When(@"In RSS02010 I continue with the following details:")]
        public void GivenInRSS02010ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS02010");
            RSS02010.ASATRun.SetValue(1, table.Rows[0]["ASATRun"]);
            RSS02010.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS02020 I continue with the following details:")]
        [When(@"In RSS02020 I continue with the following details:")]
        public void GivenInRSS02020ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS02020");
            RSS02020.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS02020.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS02020.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            RSS02020.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            RSS02020.Cls.SetValue(5, table.Rows[0]["Cls5"]);
            RSS02020.Cls.SetValue(6, table.Rows[0]["Cls6"]);
            RSS02020.Cls.SetValue(7, table.Rows[0]["Cls7"]);
            RSS02020.Cls.SetValue(8, table.Rows[0]["Cls8"]);
            RSS02020.Cls.SetValue(9, table.Rows[0]["Cls9"]);
            RSS02020.Cls.SetValue(10, table.Rows[0]["Cls10"]);
            RSS02020.ClgCon.SetValue(1, table.Rows[0]["ClgCon"]);
            RSS02020.GroupIDX.SetValue(1, table.Rows[0]["GroupIDX"]);
            RSS02020.TopSHLimit.SetValue(1, table.Rows[0]["TopSHLimit"]);
            RSS02020.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            RSS02020.ReportType.ClickField();
            WinFormsTestSteps.PressTAB();
            //RSS02020.ReportRun.SetValue(1, table.Rows[0]["ReportRun1"]);
            //RSS02020.ReportRun.SetValue(2, table.Rows[0]["ReportRun2"]);
            RSS02020.UseGroupCodes.SetValue(1, table.Rows[0]["UseGroupCodes"]);
            //RSS02020.PrintGrpDetails.SetValue(1, table.Rows[0]["PrintGrpDetails"]);
            RSS02020.HolderIDTOPrint.SetValue(1, table.Rows[0]["HolderIDTOPrint"]);
            RSS02020.NameAddressTOPrint.SetValue(1, table.Rows[0]["NameAddressTOPrint"]);
            RSS02020.HtcFlag.SetValue(1, table.Rows[0]["HtcFlag"]);
            //RSS02020.HT.SetValue(1, table.Rows[0]["HT"]);
            //RSS02020.SystemInfoFree6.SetValue(1, table.Rows[0]["SystemInfoFree6"]);
            //RSS02020.SystemInfoFree4.SetValue(1, table.Rows[0]["SystemInfoFree4"]);
            //RSS02020.SystemInfoFree7.SetValue(1, table.Rows[0]["SystemInfoFree7"]);
            //RSS02020.SystemInfoFree5.SetValue(1, table.Rows[0]["SystemInfoFree5"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS10060 I continue with the following details:")]
        [When(@"In RSS10060 I continue with the following details:")]
        public void GivenInRSS10060ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10060");
            RSS10060.ClsgrpOutputOption.SetValue(1, table.Rows[0]["ClsgrpOutputOption"]);

            if (table.Rows[0]["ClsgrpOutputOption"] == "C")
            {
                RSS10060.ClsgrpOutputOption.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10060.ComboDescription.SetValue(1, table.Rows[0]["ComboDescription"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In JOBSUB00 I continue with the following details:")]
        [When(@"In JOBSUB00 I continue with the following details:")]
        public void GivenInJOBSUB00ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB00");
            JOBSUB00.AfterUrr.SetValue(1, table.Rows[0]["AfterUrr"]);
            JOBSUB00.SaveYN.SetValue(1, table.Rows[0]["SaveYN"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In JOBSUB03 I continue with the following details:")]
        [When(@"In JOBSUB03 I continue with the following details:")]
        public void GivenInJOBSUB03ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
            JOBSUB03.Ident.SetValue(1, table.Rows[0]["Ident"]);
            JOBSUB03.OrderNO.SetValue(1, table.Rows[0]["OrderNO"]);
            ORDERNUM = JOBSUB03.OrderNO.GetValue();
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In JOBSUB04 I continue with the following details:")]
        [When(@"In JOBSUB04 I continue with the following details:")]
        public void GivenInJOBSUB04ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB04");
            JOBSUB04.ServiceCode.SetValue(1, table.Rows[0]["ServiceCode"]);
            JOBSUB04.ServiceProvider.SetValue(1, table.Rows[0]["ServiceProvider"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In JOBSUB05 I continue with the following details:")]
        [When(@"In JOBSUB05 I continue with the following details:")]
        public void GivenInJOBSUB05ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB05");
            JOBSUB05.AutoSpool.SetValue(1, table.Rows[0]["AutoSpool"]);
            JOBSUB05.Microfiche.SetValue(1, table.Rows[0]["Microfiche"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In JOBSUB21 I continue with the following details:")]
        [When(@"In JOBSUB21 I continue with the following details:")]
        public void GivenInJOBSUB21ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB21");
            JOBSUB21.Printer.SetValue(1, table.Rows[0]["Printer"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In JOBSUB90 I submit the report for VMS")]
        public void WhenInJOBSUB90ISubmitTheReportVMS(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB90");
            ReportDesc = JOBSUB90.Desc.GetValue();
            ReportJobNumber = JOBSUB90.JobNODec.GetValue();
            ReportPRNName = JOBSUB90.ParameterID.GetValue();
            ReportPrintFileName = JOBSUB90.PrintID.GetValue();
            currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
            GetCoyFromForm();
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //WinFormsTestSteps.ExpectToBeInTheScreen("RSS00101");
            WaitForJobNumberVMS(table);
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01015 I continue with the following details:")]
        [When(@"In RSS01015 I continue with the following details:")]
        public void GivenInRSS01015ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01015");
            RSS01015.Preload.SetValue(1, table.Rows[0]["Preload"]);
            if (table.Rows[0]["Preload"] == "Y")
            {
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("SLRSP001");
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("SELRSP01");
                SELRSP01.FileSelected.SetValue("1");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In JOBSUB90 I submit the report for Linux")]
        public void WhenInJOBSUB90ISubmitTheReportLinux(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB90");
            ReportDesc = JOBSUB90.Desc.GetValue();
            ReportJobNumber = JOBSUB90.JobNODec.GetValue();
            ReportPRNName = JOBSUB90.ParameterID.GetValue();
            ReportPrintFileName = JOBSUB90.PrintID.GetValue();
            currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
            GetCoyFromForm();
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //WinFormsTestSteps.ExpectToBeInTheScreen("RSS00101");
            WaitForJobNumberLinux(table);
        }

        [When(@"I continue to the report submit page")]
        public void WhenIcontinueToTheReportSubmitPage()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "JOBSUB00")
            {
                // #### Health & integrity check creates a timestamps which is use in bulk uploads ####
                //Format is #### 20150422091033 ####
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB00");
                JOBSUB00.AfterUrr.SetValue("N");
                JOBSUB00.SaveYN.SetValue("N");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
                JOBSUB03.Ident.SetValue("NDF");
                JOBSUB03.OrderNO.SetValue("5555");
                ORDERNUM = JOBSUB03.OrderNO.GetValue();
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB04");
                JOBSUB04.ServiceCode.SetValue("******");
                JOBSUB04.ServiceProvider.SetValue("CTS");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB05");
                JOBSUB05.AutoSpool.SetValue("N");
                JOBSUB05.Microfiche.SetValue("N");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "JOBSUB03")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
                JOBSUB03.Ident.SetValue("NDF");
                JOBSUB03.OrderNO.SetValue("5555");
                ORDERNUM = JOBSUB03.OrderNO.GetValue();
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "JOBSUB04")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB04");
                JOBSUB04.ServiceCode.SetValue("******");
                JOBSUB04.ServiceProvider.SetValue("CTS");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "JOBSUB05")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB05");
                JOBSUB05.AutoSpool.SetValue("N");
                JOBSUB05.Microfiche.SetValue("N");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "HKSJOB00")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("HKSJOB00");
                HKSJOB00.Ident.SetValue("NDF");
                HKSJOB00.OrderNO.SetValue("5555");
                ORDERNUM = HKSJOB00.OrderNO.GetValue();
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("HKSJOB01");
                Report = HKSJOB01.ReportName.GetValue();
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "JOBSUB21")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        public void GetCoyFromForm()
        {
            COY = (currentCOY.Substring(currentCOY.Length - 8));
        }

        /// <param name="table">data table</param>
        public void WaitForJobNumberVMS(Table table)
        {
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                var cmd = sshClient.RunCommand("sh ent " + ReportJobNumber);
                var output = cmd.Result;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                {
                    cmd = sshClient.RunCommand("sh ent " + ReportJobNumber);
                    output = cmd.Result;
                }
                sw.Stop();
                sshClient.Disconnect();
                if (!output.Contains(table.Rows[0]["PassCriteria"]))
                {
                    throw new Exception("Report Timeout or failed criteria was found" + output);
                }
            }
        }

        /// <param name="table">data table</param>
        public void WaitForJobNumberLinux(Table table)
        {

            var PassCriteriaLinux = "DONE";
            var FailCriteriaLinux = "EXIT";
            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            host = System.Environment.GetEnvironmentVariable("vmhost");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                var cmd = sshClient.RunCommand("job show  " + ReportJobNumber);
                var output = cmd.Result;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(PassCriteriaLinux) && !output.Contains(FailCriteriaLinux))
                {
                    cmd = sshClient.RunCommand("job show  " + ReportJobNumber);
                    output = cmd.Result;
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(PassCriteriaLinux))
                {
                    throw new Exception("Report Timeout or failed criteria was found" + output);
                }
            }
        }

        /// <param name="table">data table</param>
        [Then(@"I copy VMS output to local")]
        [When(@"I copy VMS output to local")]
        public int CopyVMSOutputToLocal(Table table)
        {
            String localFileName = "";
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;
            if (table.Rows[0]["FileName"] != "")
            {
                ReportPrintFileName = (table.Rows[0]["FileName"]).ToLower();
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }
            int coyindex = currentCOY.IndexOf("/");
            if (coyindex != -1)
            {
                currentCOY = currentCOY.Substring(coyindex + 1);
            }


            if (TempReportPrintFileName.ToLower().Contains("rs_ur"))
            {
                //Timestamps
                TempReportPrintFileName = TempReportPrintFileName.Remove(TempReportPrintFileName.Length - 6);
                TempReportPrintFileName = TempReportPrintFileName.Substring(TempReportPrintFileName.Length - 8);
            }
            else
            {
                if (ReportingTestSteps.TradingReport == false)
                {
                    if (FileNameDerivedFromInput == false)
                    {
                        ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
                        //There are files with different names -only checking the timestamps the get the files
                        ReportPrintFileName = ReportPrintFileName.Substring(6);
                    }
                    if (ReportPrintFileName.StartsWith("$"))
                    {
                        ReportPrintFileName = ReportPrintFileName.Substring(1, ReportPrintFileName.Length - 1);
                    }
                }

            }


            // System.IO.File.AppendAllText(@"c:\\a.txt", "ReportPrintFileName = " + ReportPrintFileName);

            /* VMS Download */
            var sshFTP = new SftpClient(ConfigurationManager.AppSettings["VMSNode"], ConfigurationManager.AppSettings["VMSUser"], ConfigurationManager.AppSettings["VMSPassword"]);

            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;

            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS") == true && FileCount == 1)
            {
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS", true);
            }
            if (FileCount == 1)
                Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");

            var VMSoutputdir = (localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");
            VMSReportDir = VMSoutputdir;

            //PRN Dir
            string vmsDIR = null;
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {

                    System.Threading.Thread.Sleep(5000);
                    var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.prn] && w");
                    var output = cmd.Result.Replace("/n/r", "").Trim();
                    //this is a temporary fix. need to chnage this later -DS
                    vmsDIR = output;
                    sshClient.Disconnect();
                }

            }


            sshFTP.Connect();
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {
                if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                    remoteFileName = vmsDIR + file.Name;
                    //Add temporary for the URR
                    //localFileName = localFileName.ToLower();

                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }

                //vmsDIR = ConfigurationManager.AppSettings["VMSRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY);
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {

                    System.Threading.Thread.Sleep(5000);
                    var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && w");
                    var output = cmd.Result.Replace("/n/r", "").Trim();
                    //this is a temporary fix. need to chnage this later -DS
                    vmsDIR = output;
                    sshClient.Disconnect();
                }

            }

            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {
                //System.IO.File.AppendAllText(@"c:\\a.txt", "Comparing Server File " + file.Name.ToUpper() + " with local " + ReportPrintFileName.ToUpper() + "\r\n");

                if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()) && (!Path.GetExtension(file.Name).ToLower().Contains(".dir")))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                    remoteFileName = vmsDIR + file.Name;
                    //Add temporary for the URR
                    //localFileName = localFileName.ToLower();

                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }

            //TRD Directory
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {

                    System.Threading.Thread.Sleep(5000);
                    var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.trd] && w");
                    var output = cmd.Result.Replace("/n/r", "").Trim();
                    vmsDIR = output;
                    sshClient.Disconnect();
                }

            }

            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {
                if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");


                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                    remoteFileName = vmsDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }


            //Any other directory from the Specflow table
            //[fileLocation] format [.fileLocation] ex: Allotments, Dividends        
            if (table.Rows[0].ContainsKey("fileLocationVMS"))
            {
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {
                        System.Threading.Thread.Sleep(5000);
                        var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def " + table.Rows[0]["fileLocationVMS"] + " && w");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        vmsDIR = output;
                        sshClient.Disconnect();
                    }

                }

                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                {
                    //System.IO.File.AppendAllText(@"c:\\a.txt", "Comparing Server File " + file.Name.ToUpper() + " with local " + ReportPrintFileName.ToUpper() + "\r\n");
                    if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                    {
                        Console.WriteLine(file);
                        localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                        if (file.Name.ToLower().Contains("rs_ur"))
                            localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                        remoteFileName = vmsDIR + file.Name;
                        //Add temporary for the URR
                        //localFileName = localFileName.ToLower();

                        streamFile = File.OpenWrite(localFileName);
                        sshFTP.DownloadFile(file.FullName, streamFile);
                        streamFile.Close();

                        vmsFileCount++;
                    }
                }

            }



            //Extrnal Files. outside company level    
            if (table.Rows[0].ContainsKey("ExternalFiles"))
            {
                if (table.Rows[0]["ExternalFiles"].ToLower() == "y")
                {
                    using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                    {
                        sshClient.Connect();
                        if (sshClient.IsConnected == true)
                        {
                            System.Threading.Thread.Sleep(5000);
                            var cmd = sshClient.RunCommand("pipe sc " + table.Rows[0]["ExternalFileLocation"] + " && w");
                            var output = cmd.Result.Replace("/n/r", "").Trim();
                            vmsDIR = output;
                            sshClient.Disconnect();
                        }

                    }

                    foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                    {
                        //System.IO.File.AppendAllText(@"c:\\a.txt", "Comparing Server File " + file.Name.ToUpper() + " with local " + ReportPrintFileName.ToUpper() + "\r\n");

                        if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                        {
                            Console.WriteLine(file);
                            localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                            if (file.Name.ToLower().Contains("rs_ur"))
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                            remoteFileName = vmsDIR + file.Name;
                            //Add temporary for the URR
                            //localFileName = localFileName.ToLower();

                            streamFile = File.OpenWrite(localFileName);
                            sshFTP.DownloadFile(file.FullName, streamFile);
                            streamFile.Close();

                            vmsFileCount++;
                        }
                    }

                }
            }


            ReportPrintFileName = "";
            return vmsFileCount;
        }

        /// <param name="table">data table</param>
        [Then(@"I copy Linux output to local")]
        [When(@"I copy Linux output to local")]
        public int CopyLinuxOutputToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;

            if (table.Rows[0]["FileName"] != "")
            {
                ReportPrintFileName = (table.Rows[0]["FileName"]).ToLower();
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["CurrentCOY"];
            }

            int coyindex = currentCOY.IndexOf("/");
            if (coyindex != -1)
            {
                currentCOY = currentCOY.Substring(coyindex + 1);
            }

            if (TempReportPrintFileName.ToLower().Contains("rs_ur"))
            {
                //Timesstams
                TempReportPrintFileName = TempReportPrintFileName.Remove(TempReportPrintFileName.Length - 6);
                TempReportPrintFileName = TempReportPrintFileName.Substring(TempReportPrintFileName.Length - 8);
            }
            else
            {
                if (ReportingTestSteps.TradingReport == false)
                {
                    if (FileNameDerivedFromInput == false)
                        ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
                    ReportPrintFileName = ReportPrintFileName.Substring(6);
                    if (ReportPrintFileName.StartsWith("$"))
                        ReportPrintFileName = ReportPrintFileName.Substring(1, ReportPrintFileName.Length - 1);

                    int dollarIndex = ReportPrintFileName.IndexOf("$");
                    if (dollarIndex != -1)
                    {
                        ReportPrintFileName = ReportPrintFileName.Substring(dollarIndex + 1);
                    }
                }

            }

            /* Linux Download */
            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = WinFormsTestSteps.Environment;
            }
            var sshFTP = new SftpClient(host, ConfigurationManager.AppSettings["LinuxUser"], ConfigurationManager.AppSettings["LinuxPassword"]);
            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];
            string linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderPrn"].Replace("COMPANYCODE", currentCOY.ToLower());

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux") == true && FileCount == 1)
            {
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux", true);
            }
            if (FileCount == 1)
                Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux");


            var Linuxoutputdir = localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux";
            LinuxReportDir = Linuxoutputdir;
            sshFTP.Connect();

            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");

                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                       streamFile.Close();

                    linuxFileCount++;
                }
            }

            linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY.ToLower());

            //Report file names are different in the company level dir (temp and csv)
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");

                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }

            linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderTrd"].Replace("COMPANYCODE", currentCOY.ToLower());

            //sftp TRD directory files
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");

                    if (file.Name.ToLower().Contains("rs_ur"))
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }

            //Any other directory from the Specflow table
            //[fileLocation] format [.fileLocation] ex: Allotments, Dividends        
            if (table.Rows[0].ContainsKey("fileLocationLnx"))
            {
                linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderOther"].Replace("COMPANYCODE", currentCOY.ToLower());
                linuxDIR = linuxDIR.Replace("xxx", table.Rows[0]["fileLocation"]);

                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                {
                    if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                    {
                        Console.WriteLine(file);
                        localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");

                        if (file.Name.ToLower().Contains("rs_ur"))
                            localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                        remoteFileName = linuxDIR + file.Name;
                        streamFile = File.OpenWrite(localFileName);
                        sshFTP.DownloadFile(file.FullName, streamFile);
                        streamFile.Close();

                        linuxFileCount++;
                    }
                }
            }

            //ExternalFileLocation
            if (table.Rows[0].ContainsKey("ExternalFiles"))
            {
                if (table.Rows[0]["ExternalFiles"].ToLower() == "y")
                {
                    //Extrnal Files. outside company level, eg:CPM_DOC
                    linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE",table.Rows[0]["ExternalFileLocation"].ToLower());

                    foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                    {
                        if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                        {
                            Console.WriteLine(file);
                            localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");

                            if (file.Name.ToLower().Contains("rs_ur"))
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                            remoteFileName = linuxDIR + file.Name;
                            streamFile = File.OpenWrite(localFileName);
                            sshFTP.DownloadFile(file.FullName, streamFile);
                            streamFile.Close();

                            linuxFileCount++;
                        }
                    }

                }

            }


                    return linuxFileCount;
        }

        /// <param name="table">data table</param>
        [When(@"I copy VMS Proxy output to local")]
        public int CopyVMSProxyOutputToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;

            int coyindex = currentCOY.IndexOf("/");
            if (coyindex != -1)
            {
                currentCOY = currentCOY.Substring(coyindex + 1);
            }

            //This is only for Proxy Files
            ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
            ReportPrintFileName = ReportPrintFileName.Substring(8, ReportPrintFileName.Length - 8);

            //if (ReportPrintFileName.StartsWith("$"))
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(1, ReportPrintFileName.Length - 1);
            //}

            // System.IO.File.AppendAllText(@"c:\\a.txt", "ReportPrintFileName = " + ReportPrintFileName);

            /* VMS Download */
            var sshFTP = new SftpClient(ConfigurationManager.AppSettings["VMSNode"], ConfigurationManager.AppSettings["VMSUser"], ConfigurationManager.AppSettings["VMSPassword"]);
            string localDIR = ConfigurationManager.AppSettings["DownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS" + table.Rows[0]["ReportType"]);
            var VMSoutputdir = (localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS" + table.Rows[0]["ReportType"]);

            string vmsDIR = ConfigurationManager.AppSettings["VMSRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY);
            //to make the Correct VMS path for Proxy Meetings
            vmsDIR = vmsDIR.Substring(0, vmsDIR.LastIndexOf(']')) + table.Rows[0]["MeetingNumberDirVMS"] + "]";
            sshFTP.Connect();

            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {
                //System.IO.File.AppendAllText(@"c:\\a.txt", "Comparing Server File " + file.Name.ToUpper() + " with local " + ReportPrintFileName.ToUpper() + "\r\n");

                if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                    localFileName = localFileName.ToLower();
                    remoteFileName = vmsDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }

            ReportPrintFileName = "";
            return vmsFileCount;
        }

        /// <param name="table">data table</param>
        [When(@"I copy Linux Proxy output to local")]
        public void CopyLinuxProxyOutputToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;

            if (vmsFileCount == 0)
            {
                Assert.Fail("VMS file count is " + vmsFileCount);
            }

            int coyindex = currentCOY.IndexOf("/");
            if (coyindex != -1)
            {
                currentCOY = currentCOY.Substring(coyindex + 1);
            }

            ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
            ReportPrintFileName = ReportPrintFileName.Substring(8, ReportPrintFileName.Length - 8);

            int dollarIndex = ReportPrintFileName.IndexOf("$");
            if (dollarIndex != -1)
            {
                ReportPrintFileName = ReportPrintFileName.Substring(dollarIndex + 1);
            }

            /* Linux Download */
            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["LinuxNode"];
            }
            var sshFTP = new SftpClient(host, ConfigurationManager.AppSettings["LinuxUser"], ConfigurationManager.AppSettings["LinuxPassword"]);
            string localDIR = ConfigurationManager.AppSettings["DownloadFolder"];
            string linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY.ToLower());

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux" + table.Rows[0]["ReportType"]);
            var Linuxoutputdir = localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux" + table.Rows[0]["ReportType"];
            linuxDIR = linuxDIR + table.Rows[0]["MeetingNumberDirLnx"];
            sshFTP.Connect();
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx");
                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }
        }



        [Then(@"I expect the same number of files returned from VMS and Linux")]
        public void fileCountLinuxAndVMS()
        {
            if (vmsFileCount != linuxFileCount || (vmsFileCount + linuxFileCount == 0))
            {
                Assert.Fail("The number of files returned between VMS and Linux is different." + "VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
            }
            else
                Console.WriteLine("VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
        }

        [Given(@"I parse the files from VMS and Linux")]
        [When(@"I parse the files from VMS and Linux")]
        [Then(@"I parse the files from VMS and Linux")]
        public void parseContentLinuxAndVMS()
        {
            //LinuxReportDir  = @"C:\WebGroup\QA Oceania\Test\SCRIP\LinuxProject\ReportDownloads\Cheque_Extract_Report-Itereation1\LINUX";
            //VMSReportDir = @"C:\WebGroup\QA Oceania\Test\SCRIP\LinuxProject\ReportDownloads\Cheque_Extract_Report-Itereation1\VMS";
            foreach (string filename in Directory.EnumerateFiles(LinuxReportDir, "*.*", SearchOption.AllDirectories))
            {
                if (Path.GetExtension(filename) != ".mask")
                    ParseFile(filename, Path.GetExtension(filename) == ".prn");
            }

            foreach (string filename in Directory.EnumerateFiles(VMSReportDir, "*.*", SearchOption.AllDirectories))
            {
                if (Path.GetExtension(filename) != ".mask")
                    ParseFile(filename, false);
                // set to false because of FTP  processes files differently Removes fortran format)
                //ParseFile(filename, Path.GetExtension(filename) == ".prn");
            }
        }

        // ReadLine() has a problem where it treats \r \n or any combination of these as a new line
        // VMS files for some reason sometimes have \r\r\n in the new line. In this case, ReadLine reads this as two lines and we were getting two new lines instead of one in the masked file
        // This function is replacement for newline where it completely drops any \r then reads to new line (\n)
        private static string ReadTill(StreamReader sr, char splitCharacter)
        {
            char nextChar;
            StringBuilder line = new StringBuilder();
            while (sr.Peek() > 0)
            {
                nextChar = (char)sr.Read();
                if (nextChar == splitCharacter) return line.ToString();

                if (nextChar != '\r')
                    line.Append(nextChar);
            }

            return line.Length == 0 ? null : line.ToString();
        }

        private static void ParseFile(string inFilename, bool fortran = false)
        {
            string outFilename = inFilename + ".mask";

            DateTime thisDay = DateTime.Today;
            string CurrentDate = thisDay.ToString("ddMMyyyy");

            thisDay = DateTime.Today.AddDays(1);
            string CurrentDate1 = thisDay.ToString("dd/MM/yy");

            DateTime dt = DateTime.Now.AddDays(1);

            string suffix = "th";
            if (dt.Day < 10 || dt.Day > 20)
            {
                switch (dt.Day % 10)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }
            }

            string format = "dd"+suffix+" MMMM yyyy";
            string CurrentDate2 = dt.ToString(format);

            MaskRule[] rules;

            if (Path.GetExtension(inFilename).ToLower() == ".xml")
            {
                // Rules for XML files
                rules = new MaskRule[]
                {
                    new MaskRule(@"(?<=\<r:SystemType\>)(?:Development|Production)", "{systemtype}"),
                };
            }

            else
            {
                // Rules for non XML files
                rules = new MaskRule[]
                {
                   new MaskRule(@"\b[A-Za-z_]+\.(sh|COM)\b", "{scriptname}"),
                   new MaskRule(@"(?<=\(.{6}:)\d\d\.\d\d:\d{6}\)", "_{timestamp})"),
                   new MaskRule(@"(?i)_\d+(?=\.temp\b)", "_{timestamp}"),
                   new MaskRule(@"(?i)(?<=Time created:\s+)\d\d:\d\d:\d\d\b", "{timestamp}"),
                   new MaskRule(@"(?i)(?<=\.temp\s+)\b\d{17}", "{timestamp}"),
                   new MaskRule(@"(?i)(?<=\.temp\s+)\b\d{14}", "{timestamp}"),
                   new MaskRule(@"Report name.*_\d{8} ", "Report name _{datestamp}"),
                   new MaskRule(@"(?<!Report date*)\d{2}/\d{2}/\d{4}", "_{datestamp}"),
                   new MaskRule(@"(?i)\d{2}/\d{2}/\d{4}\s{11}A.C.N.", "_{datestamp}"),
                   new MaskRule(@"(?i)\d{8}\s{13}A.C.N.", "_{datestamp}"),
                   new MaskRule(@"(?<!MCODES)\d{2}:\d{2}:\d{6}", "_{datestamp}"),
                   new MaskRule(@"(?<!DOMCDE)\d{2}:\d{2}\s\d{2}/\d{2}/\d{2}", "_{datestamp}"),
                   new MaskRule(@"(?<!SRCCDE)\d{2}:\d{2}:\d{6}", "_{datestamp}"),
                   new MaskRule(@"(?<!TFNXMT)\d{2}:\d{2}\s\d{2}/\d{2}/\d{2}", "_{datestamp}"),
                   new MaskRule(@"(?i)(?<!j_er_lb_5555)\d{8}\sjob", "_{datestamp}"),
                   new MaskRule(@"(?i)j_er_lb", "_{jobname}"),
                   new MaskRule(@"(?i)\d{8}0101200730062008", "_{datestamp}"),
                   new MaskRule(@CurrentDate, "_{datestamp}"),
                   new MaskRule(@"(?<=GRAND TOTALS)\s*", "_{extraspace}"),
                   new MaskRule(@"(?i)(?<=j_es_wh_5555_)\d{8}.(job)", "_{jobname}"),
                   // URR
                   new MaskRule(@"(?i)(?<=Date :)\s\b[A-Za-z]+,\s\b[A-Za-z]+\s\d{2}\s\d{4}", "_{datestamp}"),
                   new MaskRule(@"(?<=Cash Tran Refer)\s\d*", "_{CashTranRefer}"),
                   new MaskRule(@"(?i)(?<=EXP_[A-Za-z]*_URR_\d{4}.TPE\s*)\d{14}", "_{DateTime}"),
                   new MaskRule(@"NCSS[A-Za-z]*\dSCRIPAUPlan", "_{SCRIPNodeName}"),               
                   //Dividend
                   new MaskRule(CurrentDate1, "_{datestamp}"),
                   new MaskRule(CurrentDate2, "_{datestamp}"),

                };
            }

            // Rollback Extract file
            if (inFilename.ToLower().Contains("rollback_extract"))
            {
                rules = new MaskRule[]
                {
                    new MaskRule(@"(?i)\$.*\.prn", "_{filename}"),
                };
            }


            string lineFeed = "";
            using (StreamReader inStm = File.OpenText(inFilename))
            using (StreamWriter outStm = File.CreateText(outFilename))
            {
                int linecount = 0;
                string line;
                while ((line = ReadTill(inStm, '\n')) != null)
                {
                    linecount++;
                    //if (fortran && line.Length > 0)
                    //{
                    //char controlChar = line[0];
                    //if ((!inFilename.ToLower().Contains("cr_cc") && (!inFilename.ToLower().Contains("cr_mc"))))
                    //{
                    //line = line.Substring(1);            //This is fixed in Linux now            
                    //switch (controlChar)
                    //{
                    //    case '0':
                    //        lineFeed = "\n\n";
                    //        break;

                    //    case '1':
                    //        lineFeed = "\x0c";
                    //        break;
                    //}
                    //}
                    //}
                    if (line.Length > 0)
                    {
                        if (WinFormsTestSteps.Environment == "CSSHYC" && linecount > 1)
                        {
                            char controlChar;
                            int index = 0;
                            for (index = 0; index < line.Length; index++)
                            {
                                controlChar = line[index];
                                if (((int)controlChar) == 12)
                                {
                                    //line = line.Insert(index, "\n\n");
                                    line = line.Insert(index, "\n");
                                    index++;
                                    //line = line.Replace(controlChar, '\n');
                                }
                            }
                        }
                    }

                    foreach (MaskRule rule in rules)
                    {
                        line = rule.Pattern.Replace(line, rule.ReplaceText);
                    }

                    outStm.Write(lineFeed + line);

                    lineFeed = "\n";
                }
                //outStm.Write(lineFeed);
            }
        }

        private class MaskRule
        {
            public Regex Pattern;
            public string ReplaceText;

            public MaskRule(string pattern, string replaceText)
            {
                Pattern = new Regex(pattern);
                ReplaceText = replaceText;
            }
        }

        // This method accepts two strings the represent two files to
        // compare. A return value of 0 indicates that the contents of the files
        // are the same. A return value of any other value indicates that the
        // files are not the same.
        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
            fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read);

            // Check the file sizes. If they are not the same, the files
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                Console.WriteLine(fs1 + ": File size is different to: " + fs2);
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is
            // equal to "file2byte" at this point only if the files are
            // the same.
            return ((file1byte - file2byte) == 0);
        }

        [Then(@"I compare the files from VMS and Linux")]
        public void compareContentLinuxAndVMS()
        {
            String vmsFileName;
            String linuxFileName;

            // compare each
            foreach (string filename in Directory.EnumerateFiles(VMSReportDir, "*.*mask", SearchOption.AllDirectories))
            {
                vmsFileName = linuxFileName = filename;
                vmsFileName = linuxFileName.Replace("Linux", "VMS");

                if (FileCompare(vmsFileName, linuxFileName) == false)
                {
                    Assert.Fail("File comparison failed.");
                    return;
                }
            }

            //Assert.Pass("File comparison passed.");
        }

        //[Then(@"If this is a Linux run Perform a File comparison")]
        //public void CompareContentLinuxAndVms()
        //{
        //    if (WinFormsTestSteps.enEnvironmentType.Equals(RunTypes.VMS)) return;

        //    foreach (var filename in Directory.EnumerateFiles(LinuxReportDir, "*.*mask", SearchOption.AllDirectories))
        //    {
        //        var linuxFileName = filename;
        //        var vmsFileName = linuxFileName.Replace("Linux", "VMS", StringComparison.InvariantCultureIgnoreCase);

        //        if (!FileCompare(vmsFileName, linuxFileName))
        //        {
        //            Assert.Fail("Comparing:\t{0}" + Environment.NewLine + "\t \t \t \t \t{1}", vmsFileName, linuxFileName);
        //        }
        //    }
        //}

        /// <param name="table">data table</param>
        [Given(@"In RSS05500 I continue with the following details:")]
        [When(@"In RSS05500 I continue with the following details:")]
        public void GivenInRSS05500ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS05500");
            RSS05500.Selection.SetValue(1, table.Rows[0]["Selection"]);
            RSS05500.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            //RSS05500.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            //RSS05500.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            //RSS05500.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            //RSS05500.Cls.SetValue(5, table.Rows[0]["Cls5"]);
            //RSS05500.Cls.SetValue(6, table.Rows[0]["Cls6"]);
            //RSS05500.Cls.SetValue(7, table.Rows[0]["Cls7"]);
            //RSS05500.Cls.SetValue(8, table.Rows[0]["Cls8"]);
            //RSS05500.Cls.SetValue(9, table.Rows[0]["Cls9"]);
            RSS05500.Match.SetValue(1, table.Rows[0]["Match"]);
            RSS05500.UseInputFile.SetValue(1, table.Rows[0]["UseInputFile"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS18000 I continue with the following details:")]
        [When(@"In RSS18000 I continue with the following details:")]
        public void GivenInRSS18000ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS18000");
            RSS18000.PreloadDefaults.SetValue(1, table.Rows[0]["PreloadDefaults"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS18001 I continue with the following details:")]
        [When(@"In RSS18001 I continue with the following details:")]
        public void GivenInRSS18001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS18001");
            RSS18001.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            //RSS18001.ClgCon.SetValue(1, table.Rows[0]["ClgCon"]);
            RSS18001.NadTOPrint.SetValue(1, table.Rows[0]["NadTOPrint"]);
            RSS18001.MovementLevel.SetValue(1, table.Rows[0]["MovementLevel"]);
            RSS18001.HolderLimit.SetValue(1, table.Rows[0]["HolderLimit"]);
            RSS18001.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            //RSS18001.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            //RSS18001.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            //RSS18001.SystemInfoFree6.SetValue(1, table.Rows[0]["SystemInfoFree6"]);
            //RSS18001.SystemInfoFree7.SetValue(1, table.Rows[0]["SystemInfoFree7"]);
            //RSS18001.SystemInfoFree4.SetValue(1, table.Rows[0]["SystemInfoFree4"]);
            //RSS18001.SystemInfoFree5.SetValue(1, table.Rows[0]["SystemInfoFree5"]);
            RSS18001.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS18001.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS18001.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            //RSS18001.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            //RSS18001.Cls.SetValue(5, table.Rows[0]["Cls5"]);
            //RSS18001.Cls.SetValue(6, table.Rows[0]["Cls6"]);
            //RSS18001.Cls.SetValue(7, table.Rows[0]["Cls7"]);
            //RSS18001.Cls.SetValue(8, table.Rows[0]["Cls8"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS07001 I continue with the following details:")]
        [When(@"In RSS07001 I continue with the following details:")]
        public void GivenInRSS07001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS07001");
            RSS07001.Selection.SetValue(1, table.Rows[0]["Selection"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS07500 I continue with the following details:")]
        [When(@"In RSS07500 I continue with the following details:")]
        public void GivenInRSS07500ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS07500");
            RSS07500.PlanSelection.SetValue(1, table.Rows[0]["PlanSelection1"]);
            RSS07500.PlanSelection.SetValue(2, table.Rows[0]["PlanSelection2"]);
            RSS07500.PlanPartType.SetValue(1, table.Rows[0]["PlanPartType"]);
            RSS07500.BalanceSelection.SetValue(1, table.Rows[0]["BalanceSelection"]);
            RSS07500.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [Given(@"In RSS09000 I click on: ""(.*)"" within the Broker Analysis Menu")]
        [When(@"In RSS09000 I click on: ""(.*)"" within the Broker Analysis Menu")]
        public void ClickWithinTheBrokerAnalysisMenu(string menuOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS09000");
            switch (menuOption.ToLower())
            {
                case "broker trading analysis":
                    RSS09000.MenuItemBT.ClickField();
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "broker application report":
                    RSS09000.MenuItemBA.ClickField();
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "broker state report":
                    RSS09000.MenuItemBS.ClickField();
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS09002 I continue with the following details:")]
        [When(@"In RSS09002 I continue with the following details:")]
        public void GivenInRSS09002ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS09002");
            RSS09002.RepDate.SetValue(1, table.Rows[0]["RepDate"]);
            //RSS09002.ExtractFileName.SetValue(1, table.Rows[0]["ExtractFileName"]);
            RSS09002.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS09002.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS09002.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            RSS09002.BkrsCol1.SetValue(1, table.Rows[0]["BrokerCode1"]);
            RSS09002.BkrsCol1.SetValue(2, table.Rows[0]["BrokerCode2"]);
            //RSS09002.BkrsCol1.SetValue(3, table.Rows[0]["BrokerCode3"]);
            RSS09002.BkrsCol1.SetValue(4, table.Rows[0]["BrokerCode4"]);
            RSS09002.BkrsCol2.SetValue(1, table.Rows[0]["BrokerCode5"]);
            //RSS09002.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            //RSS09002.Cls.SetValue(5, table.Rows[0]["Cls5"]);
            //RSS09002.Cls.SetValue(6, table.Rows[0]["Cls6"]);
            //RSS09002.Cls.SetValue(7, table.Rows[0]["Cls7"]);
            //RSS09002.Cls.SetValue(8, table.Rows[0]["Cls8"]);
            //RSS09002.Cls.SetValue(9, table.Rows[0]["Cls9"]);
            //RSS09002.Cls.SetValue(10, table.Rows[0]["Cls10"]);
            RSS09002.ClgCon.SetValue(1, table.Rows[0]["ClgCon"]);
            RSS09002.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            RSS09002.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            RSS09002.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            RSS09002.PrintUnknown.SetValue(1, table.Rows[0]["PrintUnknown"]);
            RSS09002.BrokerReportSeq.SetValue(1, table.Rows[0]["BrokerReportSeq"]);
            RSS09002.PrintHin.SetValue(1, table.Rows[0]["PrintHin"]);
            RSS09002.BrokerCommission.SetValue(1, table.Rows[0]["BrokerCommission"]);
            if (table.Rows[0]["BrokerCommission"] == "Y")
            {
                RSS09002.BrokerCommission.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS09002.CommissionFrom.SetValue(1, table.Rows[0]["CommissionFrom1"]);
                //RSS09002.CommissionFrom.SetValue(2, table.Rows[0]["CommissionFrom2"]);
                //RSS09002.CommissionFrom.SetValue(3, table.Rows[0]["CommissionFrom3"]);
                RSS09002.CommissionTO.SetValue(1, table.Rows[0]["CommissionTo1"]);
                //RSS09002.CommissionTO.SetValue(2, table.Rows[0]["CommissionTo2"]);
                //RSS09002.CommissionTO.SetValue(3, table.Rows[0]["CommissionTo3"]);
                RSS09002.CommPerc.SetValue(1, table.Rows[0]["CommPerc"]);
                RSS09002.ChequesRequired.SetValue(1, table.Rows[0]["ChequesRequired"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string currentForm = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (currentForm == "RSS09003")
            {
                RSS09003.ChequeFormat.SetValue(1, table.Rows[0]["ChequeFormat"]);
                RSS09003.ChequeDate.SetValue(1, table.Rows[0]["ChequeDate"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS23001 I continue with the following details:")]
        [When(@"In RSS23001 I continue with the following details:")]
        public void GivenInRSS23001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS23001");
            RSS23001.Client.SetValue(1, table.Rows[0]["Client"]);
            RSS23001.Company.SetValue(1, table.Rows[0]["Company"]);
            RSS23001.UserName.SetValue(1, table.Rows[0]["UserName"]);
            RSS23001.StartDate.SetValue(1, table.Rows[0]["StartDate"]);
            RSS23001.EndDate.SetValue(1, table.Rows[0]["EndDate"]);
            RSS23001.OrigSystem.SetValue(1, table.Rows[0]["OrigSystem"]);
            RSS23001.ServProvider.SetValue(1, table.Rows[0]["ServProvider"]);
            RSS23001.ServCode.SetValue(1, table.Rows[0]["ServCode"]);
            RSS23001.Department.SetValue(1, table.Rows[0]["Department"]);
            RSS23001.Branch.SetValue(1, table.Rows[0]["Branch"]);
            RSS23001.TransCode.SetValue(1, table.Rows[0]["TransCode1"]);
            RSS23001.TransCode.SetValue(2, table.Rows[0]["TransCode2"]);
            RSS23001.BrokerCode.SetValue(1, table.Rows[0]["BrokerCode"]);
            RSS23001.AccessCode.SetValue(1, table.Rows[0]["AccessCode"]);
            RSS23001.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS19000 I continue with the following details:")]
        [When(@"In RSS19000 I continue with the following details:")]
        public void GivenInRSS19000ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS19000");
            RSS19000.PreloadDefaults.SetValue(1, table.Rows[0]["PreloadDefaults"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In RSS10010 I click on: ""(.*)"" within the Extract Reporting Menu")]
        [Given(@"In RSS10010 I click on: ""(.*)"" within the Extract Reporting Menu")]
        public void ClickWithinTheExtractReportingMenu(string menuOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10010");
            switch (menuOption.ToLower())
            {
                case "class register balance":
                    RSS10010.MenuItemCR.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "certificates":
                    RSS10010.MenuItemCS.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "registered transactions":
                    RSS10010.MenuItemRT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "extract file details":
                    RSS10010.MenuItemXT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "account types phone numbers":
                    RSS10010.MenuItemAT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "name address":
                    RSS10010.MenuItemNA.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "static transactions return mail":
                    RSS10010.MenuItemSR.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "holder flags alternative ids":
                    RSS10010.MenuItemHF.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "user defined holder flags":
                    RSS10010.MenuItemHU.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "notings":
                    RSS10010.MenuItemNS.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "payment instruction":
                    RSS10010.MenuItemPI.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "dividend reinvestment plans":
                    RSS10010.MenuItemPS.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "tax selection":
                    RSS10010.MenuItemTS.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "electronic communication":
                    RSS10010.MenuItemEC.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "employee static details":
                    RSS10010.MenuItemES.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "schedule job":
                    RSS10010.MenuItemSJ.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "other holder attributes":
                    RSS10010.MenuItemOH.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS10042 I continue with the following details:")]
        [When(@"In RSS10042 I continue with the following details:")]
        public void GivenInRSS10042ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10042");
            if (table.Rows[0]["ShellHoldersOption"] == "")
            {
                RSS10042.ShellHoldersOption.SetValue(1, table.Rows[0]["ShellHoldersOption"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (table.Rows[0]["ShellHoldersOption"] == "I")
            {
                RSS10042.ShellHoldersOption.SetValue(1, table.Rows[0]["ShellHoldersOption"]);
                RSS10042.ShellHoldersOption.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10042.ShellCntrolOption.SetValue(1, table.Rows[0]["ShellCntrolOption"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS10032 I continue with the following details:")]
        [When(@"In RSS10032 I continue with the following details:")]
        public void InRSS10032ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10032");
            RSS10032.TaxCodeFlag.SetValue(1, table.Rows[0]["TaxCodeFlag"]);
            if (table.Rows[0]["TaxCodeFlag"] == "S")
            {
                RSS10032.TaxCodeFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10032.OtaxCodes.SetValue(1, table.Rows[0]["OtaxCodes1"]);
                RSS10032.OtaxCodes.SetValue(2, table.Rows[0]["OtaxCodes2"]);
                RSS10032.OtaxCodes.SetValue(3, table.Rows[0]["OtaxCodes3"]);
                RSS10032.OtaxCodes.SetValue(4, table.Rows[0]["OtaxCodes4"]);
                RSS10032.OtaxCodes.SetValue(5, table.Rows[0]["OtaxCodes5"]);
            }
            RSS10032.NzlIrds.SetValue(1, table.Rows[0]["NzlIrds"]);
            RSS10032.NzlExempt.SetValue(1, table.Rows[0]["NzlExempt"]);
            RSS10032.TfnFlag.SetValue(1, table.Rows[0]["TfnFlag"]);
            if (table.Rows[0]["TfnFlag"] == "Q")
            {
                RSS10032.TfnFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10032.TfnQuotedFlag.SetValue(1, table.Rows[0]["TfnQuotedFlag"]);

                if (table.Rows[0]["TfnQuotedFlag"] == "E")
                {
                    RSS10032.TfnQuotedFlag.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10032.ExemptCode.SetValue(1, table.Rows[0]["ExemptCode1"]);
                    RSS10032.ExemptCode.SetValue(2, table.Rows[0]["ExemptCode2"]);
                    RSS10032.ExemptCode.SetValue(3, table.Rows[0]["ExemptCode3"]);
                    RSS10032.ExemptCode.SetValue(4, table.Rows[0]["ExemptCode4"]);
                }
                else
                {
                    RSS10032.TfnQuotedFlag.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10032.JointIncompleteInd.SetValue(1, table.Rows[0]["JointIncompleteInd"]);
                }
            }
            if (table.Rows[0]["TfnFlag"] == "N")
            {
                RSS10032.TfnNotQuotedFlag.SetValue(1, table.Rows[0]["TfnNotQuotedFlag"]);
                if (table.Rows[0]["TfnNotQuotedFlag"] == "R" || table.Rows[0]["TfnNotQuotedFlag"] == "A")
                {
                    RSS10032.JointIncompleteInd.SetValue(1, table.Rows[0]["JointIncompleteInd"]);
                }
            }

            if (table.Rows[0]["TinType1"] != "")
            {
                RSS10032.TinType.SetValue(1, table.Rows[0]["TinType1"]);
                RSS10032.TinType.SetValue(2, table.Rows[0]["TinType2"]);
                RSS10032.TinType.SetValue(3, table.Rows[0]["TinType3"]);
            }

            //RSS10032.TinStatusNbr.SetValue(1, table.Rows[0]["TinStatusNbr"]);
            //RSS10032.TinExpiryDateFrom.SetValue(1, table.Rows[0]["TinExpiryDateFrom"]);
            //RSS10032.TinExpiryDateTO.SetValue(1, table.Rows[0]["TinExpiryDateTO"]);
            //RSS10032.TinCertifiedInd.SetValue(1, table.Rows[0]["TinCertifiedInd"]);
            //RSS10032.HolderParentIdent.SetValue(1, table.Rows[0]["HolderParentIdent"]);
            //RSS10032.USTaxCodeFlag.SetValue(1, table.Rows[0]["USTaxCodeFlag"]);
            //RSS10032.USOtaxCodes.SetValue(1, table.Rows[0]["USOtaxCodes"]);
            //RSS10032.AccountTypeFlag.SetValue(1, table.Rows[0]["AccountTypeFlag"]);
            //RSS10032.AccountType.SetValue(1, table.Rows[0]["AccountType"]);
            //RSS10032.PreexCodeFlag.SetValue(1, table.Rows[0]["PreexCodeFlag"]);
            //RSS10032.PreexCode.SetValue(1, table.Rows[0]["PreexCode"]);
            //RSS10032.CuringStatusFlag.SetValue(1, table.Rows[0]["CuringStatusFlag"]);
            //RSS10032.CuringStatus.SetValue(1, table.Rows[0]["CuringStatus"]);
            //RSS10032.ValueStatusFlag.SetValue(1, table.Rows[0]["ValueStatusFlag"]);
            //RSS10032.ValueStatus.SetValue(1, table.Rows[0]["ValueStatus"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10050 I continue with the following details:")]
        [Given(@"In RSS10050 I continue with the following details:")]
        public void RSS10050ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10050");
            RSS10050.IndFlag.SetValue(1, table.Rows[0]["IndFlag"]);
            RSS10050.Email.SetValue(1, table.Rows[0]["Email"]);
            RSS10050.RtnDateInd.SetValue(1, table.Rows[0]["RtnDateInd"]);
            if (table.Rows[0]["RtnDateInd"] == "S")
            {
                RSS10050.RtnDateInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10050.RtnDateFrom.SetValue(1, table.Rows[0]["RtnDateFrom"]);
                RSS10050.RtnDateTO.SetValue(1, table.Rows[0]["RtnDateTO"]);
            }

            if (table.Rows[0]["PubSelection1"] == "S" || table.Rows[0]["PubSelection1"] == "E")
            {
                if (RSS10050.PubSelection1.Exists() == true)
                {
                    RSS10050.PubSelection1.SetValue(1, table.Rows[0]["PubSelection1"]);
                    RSS10050.PubSelection1.ClickField();
                    WinFormsTestSteps.PressTAB();
                }

                if (RSS10050.Methods1.Exists() == true)
                {
                    RSS10050.Methods1.SetValue(1, table.Rows[0]["1Methods1"]);
                    RSS10050.Methods1.SetValue(2, table.Rows[0]["2Methods1"]);
                    RSS10050.Methods1.SetValue(3, table.Rows[0]["3Methods1"]);
                }

            }
            else
            {
                if (RSS10050.PubSelection1.Exists() == true)
                {
                    RSS10050.PubSelection1.SetValue(1, table.Rows[0]["PubSelection1"]);
                }

            }
            if (table.Rows[0]["PubSelection2"] == "S" || table.Rows[0]["PubSelection2"] == "E")
            {
                RSS10050.PubSelection2.SetValue(1, table.Rows[0]["PubSelection2"]);
                RSS10050.PubSelection2.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10050.Methods2.SetValue(1, table.Rows[0]["Methods2"]);
            }
            else
            {
                if (RSS10050.PubSelection2.Exists() == true)
                {
                    RSS10050.PubSelection2.SetValue(1, table.Rows[0]["PubSelection2"]);
                }

            }
            if (table.Rows[0]["PubSelection3"] == "S" || table.Rows[0]["PubSelection3"] == "E")
            {
                if (RSS10050.PubSelection3.Exists() == true)
                {
                    RSS10050.PubSelection3.SetValue(1, table.Rows[0]["PubSelection3"]);
                    RSS10050.PubSelection3.ClickField();
                    WinFormsTestSteps.PressTAB();
                }
                if (RSS10050.Methods3.Exists() == true)
                {
                    RSS10050.Methods3.SetValue(1, table.Rows[0]["Methods3"]);
                }
            }
            else
            {
                if (RSS10050.PubSelection3.Exists() == true)
                {
                    RSS10050.PubSelection3.SetValue(1, table.Rows[0]["PubSelection3"]);
                }

            }
            if (table.Rows[0]["PubSelection7"] == "S" || table.Rows[0]["PubSelection7"] == "E")
            {
                if (RSS10050.PubSelection7.Exists() == true)
                {
                    RSS10050.PubSelection7.SetValue(1, table.Rows[0]["PubSelection7"]);
                    RSS10050.PubSelection7.ClickField();
                    WinFormsTestSteps.PressTAB();
                }
                if (RSS10050.Methods7.Exists() == true)
                {
                    RSS10050.Methods7.SetValue(1, table.Rows[0]["Methods7"]);
                }

            }
            else
            {
                if (RSS10050.PubSelection7.Exists() == true)
                {
                    RSS10050.PubSelection7.SetValue(1, table.Rows[0]["PubSelection7"]);
                }

            }
            if (table.Rows[0]["PubSelection8"] == "S" || table.Rows[0]["PubSelection8"] == "E")
            {
                if (RSS10050.PubSelection8.Exists() == true)
                {
                    RSS10050.PubSelection8.SetValue(1, table.Rows[0]["PubSelection8"]);
                    RSS10050.PubSelection8.ClickField();
                    WinFormsTestSteps.PressTAB();
                }

                if (RSS10050.Methods8.Exists() == true)
                {
                    RSS10050.Methods8.SetValue(1, table.Rows[0]["Methods8"]);
                }

            }
            else
            {
                if (RSS10050.PubSelection8.Exists() == true)
                {
                    RSS10050.PubSelection8.SetValue(1, table.Rows[0]["PubSelection8"]);
                }

            }
            if (table.Rows[0]["PubSelection9"] == "S" || table.Rows[0]["PubSelection9"] == "E")
            {
                if (RSS10050.PubSelection9.Exists() == true)
                {
                    RSS10050.PubSelection9.SetValue(1, table.Rows[0]["PubSelection9"]);
                    RSS10050.PubSelection9.ClickField();
                    WinFormsTestSteps.PressTAB();
                }
                if (RSS10050.Methods9.Exists() == true)
                {
                    RSS10050.Methods9.SetValue(1, table.Rows[0]["Methods9"]);
                }

            }
            else
            {
                if (RSS10050.PubSelection9.Exists() == true)
                {
                    RSS10050.PubSelection9.SetValue(1, table.Rows[0]["PubSelection9"]);
                }

            }

            //RSS10050.Numbers.SetValue(1, table.Rows[0]["Numbers"]);
            //RSS10050.Descriptions.SetValue(1, table.Rows[0]["Descriptions"]);
            //RSS10050.PubSelection4.SetValue(1, table.Rows[0]["PubSelection4"]);
            //RSS10050.Methods4.SetValue(1, table.Rows[0]["Methods4"]);
            //RSS10050.PubSelection5.SetValue(1, table.Rows[0]["PubSelection5"]);
            //RSS10050.Methods5.SetValue(1, table.Rows[0]["Methods5"]);
            //RSS10050.PubSelection6.SetValue(1, table.Rows[0]["PubSelection6"]);
            //RSS10050.Methods6.SetValue(1, table.Rows[0]["Methods6"]);
            //RSS10050.PubSelection10.SetValue(1, table.Rows[0]["PubSelection10"]);
            //RSS10050.Methods10.SetValue(1, table.Rows[0]["Methods10"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10043 I continue with the following details:")]
        [Given(@"In RSS10043 I continue with the following details:")]
        public void RSS10043ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10043");
            if (table.Rows[0]["IRLCustodianRefOpt"] == "")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else
            {
                RSS10043.CustodianRefOpt.SetValue(1, table.Rows[0]["IRLCustodianRefOpt"]);
                if (table.Rows[0]["CountryResidenceOpt"] == "S")
                {
                    RSS10043.CustodianRefOpt.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10043.CustodianRef.SetValue(1, table.Rows[0]["IRLCustodianRef1"]);
                    RSS10043.CustodianRef.SetValue(2, table.Rows[0]["IRLCustodianRef2"]);
                    RSS10043.CustodianRef.SetValue(3, table.Rows[0]["IRLCustodianRef3"]);
                }
                RSS10043.Intermediary.SetValue(1, table.Rows[0]["IRLIntermediary"]);
                RSS10043.InternalStatusOpt.SetValue(1, table.Rows[0]["IRLInternalStatusOpt"]);
                if (table.Rows[0]["IRLInternalStatusOpt"] == "S")
                {
                    RSS10043.InternalStatusOpt.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10043.InternalStatus.SetValue(1, table.Rows[0]["IRLInternalStatus1"]);
                    RSS10043.InternalStatus.SetValue(2, table.Rows[0]["IRLInternalStatus2"]);
                    RSS10043.InternalStatus.SetValue(3, table.Rows[0]["IRLInternalStatus2"]);
                }
                RSS10043.CountryResidenceOpt.SetValue(1, table.Rows[0]["CountryResidenceOpt"]);
                if (table.Rows[0]["CountryResidenceOpt"] == "S")
                {
                    RSS10043.CountryResidenceOpt.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10043.CountryResidence.SetValue(1, table.Rows[0]["CountryResidence1"]);
                    RSS10043.CountryResidence.SetValue(2, table.Rows[0]["CountryResidence2"]);
                    RSS10043.CountryResidence.SetValue(3, table.Rows[0]["CountryResidence3"]);
                }
                RSS10043.EntityTypeOpt.SetValue(1, table.Rows[0]["EntityTypeOpt"]);
                if (table.Rows[0]["EntityTypeOpt"] == "S")
                {
                    RSS10043.EntityTypeOpt.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10043.EntityType.SetValue(1, table.Rows[0]["EntityType1"]);
                    RSS10043.EntityType.SetValue(2, table.Rows[0]["EntityType2"]);
                    RSS10043.EntityType.SetValue(3, table.Rows[0]["EntityType3"]);
                }
                RSS10043.TaxReference.SetValue(1, table.Rows[0]["IRLTaxReference"]);
                RSS10043.DateOFBirth.SetValue(1, table.Rows[0]["IRLDateOFBirth"]);
                RSS10043.CertFileRef.SetValue(1, table.Rows[0]["CertFileRef"]);
                RSS10043.CertDwtRef.SetValue(1, table.Rows[0]["CertDwtRef"]);
                RSS10043.DwtExpiryOpt.SetValue(1, table.Rows[0]["DwtExpiryOpt"]);
                if (table.Rows[0]["DwtExpiryOpt"] != "")
                {
                    RSS10043.DwtExpiryOpt.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10043.DwtExpiryDate.SetValue(1, table.Rows[0]["DwtExpiryDate"]);
                }
                RSS10043.CertificationStatus.SetValue(1, table.Rows[0]["IRLCertificationStatus"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10023 I continue with the following details:")]
        [Given(@"In RSS10023 I continue with the following details:")]
        public void RSS10023ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10023");
            RSS10023.PrintAsx.SetValue(1, table.Rows[0]["PrintAsx"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10044 I continue with the following details:")]
        [Given(@"In RSS10044 I continue with the following details:")]
        public void RSS10044ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10044");
            RSS10044.CustodianRefOpt.SetValue(1, table.Rows[0]["ZAFCustodianRefOpt"]);
            if (table.Rows[0]["ZAFCustodianRefOpt"] == "S")
            {
                RSS10044.CustodianRefOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.CustodianRef.SetValue(1, table.Rows[0]["ZAFCustodianRef1"]);
                RSS10044.CustodianRef.SetValue(2, table.Rows[0]["ZAFCustodianRef2"]);
                RSS10044.CustodianRef.SetValue(3, table.Rows[0]["ZAFCustodianRef3"]);
            }
            RSS10044.Intermediary.SetValue(1, table.Rows[0]["ZAFIntermediary"]);
            RSS10044.InternalStatusOpt.SetValue(1, table.Rows[0]["ZAFInternalStatusOpt"]);
            if (table.Rows[0]["ZAFInternalStatusOpt"] == "S")
            {
                RSS10044.InternalStatusOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.InternalStatus.SetValue(1, table.Rows[0]["ZAFInternalStatus1"]);
                RSS10044.InternalStatus.SetValue(2, table.Rows[0]["ZAFInternalStatus2"]);
                RSS10044.InternalStatus.SetValue(3, table.Rows[0]["ZAFInternalStatus3"]);
            }
            RSS10044.TaxDomicileOpt.SetValue(1, table.Rows[0]["TaxDomicileOpt"]);
            if (table.Rows[0]["TaxDomicileOpt"] == "S")
            {
                RSS10044.TaxDomicileOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.TaxDomicile.SetValue(1, table.Rows[0]["TaxDomicile1"]);
                RSS10044.TaxDomicile.SetValue(2, table.Rows[0]["TaxDomicile2"]);
                RSS10044.TaxDomicile.SetValue(3, table.Rows[0]["TaxDomicile3"]);
            }
            RSS10044.NaturePersonOpt.SetValue(1, table.Rows[0]["NaturePersonOpt"]);
            if (table.Rows[0]["NaturePersonOpt"] == "S")
            {
                RSS10044.NaturePersonOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.NaturePerson.SetValue(1, table.Rows[0]["NaturePerson1"]);
                //RSS10044.NaturePerson.SetValue(2, table.Rows[0]["NaturePerson2"]);
                //RSS10044.NaturePerson.SetValue(3, table.Rows[0]["NaturePerson3"]);
            }
            RSS10044.TaxReference.SetValue(1, table.Rows[0]["ZAFTaxReference"]);
            RSS10044.IDNO.SetValue(1, table.Rows[0]["IDNO"]);
            RSS10044.DateOFBirth.SetValue(1, table.Rows[0]["ZAFDateOFBirth"]);
            RSS10044.ExemptionCodeOpt.SetValue(1, table.Rows[0]["ExemptionCodeOpt"]);
            if (table.Rows[0]["ExemptionCodeOpt"] == "S")
            {
                RSS10044.ExemptionCodeOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.ExemptionCode.SetValue(1, table.Rows[0]["ExemptionCode1"]);
                RSS10044.ExemptionCode.SetValue(2, table.Rows[0]["ExemptionCode2"]);
                RSS10044.ExemptionCode.SetValue(3, table.Rows[0]["ExemptionCode3"]);
            }
            RSS10044.PassportCtryIssOpt.SetValue(1, table.Rows[0]["PassportCtryIssOpt"]);
            if (table.Rows[0]["PassportCtryIssOpt"] == "S")
            {
                RSS10044.PassportCtryIssOpt.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10044.PassportCtryIss.SetValue(1, table.Rows[0]["PassportCtryIss1"]);
                RSS10044.PassportCtryIss.SetValue(2, table.Rows[0]["PassportCtryIss2"]);
                RSS10044.PassportCtryIss.SetValue(3, table.Rows[0]["PassportCtryIss3"]);
            }
            RSS10044.CertificationStatus.SetValue(1, table.Rows[0]["ZAFCertificationStatus"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [Given(@"In RSS10022 I click on: ""(.*)"" within the Output Format Menu")]
        [When(@"In RSS10022 I click on: ""(.*)"" within the Output Format Menu")]
        [Given(@"In RSS10022 I click on: ""(.*)"" within the Output Format Menu")]
        public void ClickWithinTheOutputFormatMenu(string menuOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10022");
            switch (menuOption.ToLower())
            {
                case "audit file":
                    RSS10022.MenuItemAU.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "labels":
                    RSS10022.MenuItemLB.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "notices":
                    RSS10022.MenuItemNT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "register list format":
                    RSS10022.MenuItemRL.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "static list format":
                    RSS10022.MenuItemSL.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "holder tape":
                    RSS10022.MenuItemHT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "special process":
                    RSS10022.MenuItemSP.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "customised data extract":
                    RSS10022.MenuItemDE.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "totals only":
                    RSS10022.MenuItemTO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "holder tape-balance by class":
                    RSS10022.MenuItemBT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "balance export tape":
                    RSS10022.MenuItemBE.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "holder export tape":
                    RSS10022.MenuItemHE.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "employee mailing tape":
                    RSS10022.MenuItemEM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS10034 I continue with the following details:")]
        [When(@"In RSS10034 I continue with the following details:")]
        public void GivenInRSS10034ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10034");
            RSS10034.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            RSS10034.HolderCat.SetValue(1, table.Rows[0]["HolderCat"]);
            RSS10034.RegAddress.SetValue(1, table.Rows[0]["RegAddress"]);

            //RSS10034.HolderNumber.SetValue(1, table.Rows[0]["HolderNumber"]);
            //RSS10034.RegAddrCase.SetValue(1, table.Rows[0]["RegAddrCase"]);
            //RSS10034.HolderName.SetValue(1, table.Rows[0]["HolderName"]);
            //RSS10034.Fullnames.SetValue(1, table.Rows[0]["Fullnames"]);
            //RSS10034.CaseFull.SetValue(1, table.Rows[0]["CaseFull"]);
            //RSS10034.FormattedFull.SetValue(1, table.Rows[0]["FormattedFull"]);
            //RSS10034.NameDetailed.SetValue(1, table.Rows[0]["NameDetailed"]);
            //RSS10034.CaseDetailed.SetValue(1, table.Rows[0]["CaseDetailed"]);
            //RSS10034.CompanyName.SetValue(1, table.Rows[0]["CompanyName"]);
            //RSS10034.Surname.SetValue(1, table.Rows[0]["Surname"]);
            //RSS10034.FirstName.SetValue(1, table.Rows[0]["FirstName"]);
            //RSS10034.SecondName.SetValue(1, table.Rows[0]["SecondName"]);
            //RSS10034.ThirdName.SetValue(1, table.Rows[0]["ThirdName"]);
            //RSS10034.Title.SetValue(1, table.Rows[0]["Title"]);
            //RSS10034.Initials.SetValue(1, table.Rows[0]["Initials"]);
            //RSS10034.Designator.SetValue(1, table.Rows[0]["Designator"]);
            //RSS10034.NameKey.SetValue(1, table.Rows[0]["NameKey"]);
            //RSS10034.NameType.SetValue(1, table.Rows[0]["NameType"]);
            //RSS10034.HolderAddress.SetValue(1, table.Rows[0]["HolderAddress"]);
            //RSS10034.HolderAddressCase.SetValue(1, table.Rows[0]["HolderAddressCase"]);
            //RSS10034.IncludePcode.SetValue(1, table.Rows[0]["IncludePcode"]);
            //RSS10034.PcodeDomicile.SetValue(1, table.Rows[0]["PcodeDomicile"]);
            //RSS10034.Dpid.SetValue(1, table.Rows[0]["Dpid"]);
            //RSS10034.Barcode.SetValue(1, table.Rows[0]["Barcode"]);
            //RSS10034.AlternateID.SetValue(1, table.Rows[0]["AlternateID"]);
            //RSS10034.Rss10034PersonalUrl.SetValue(1, table.Rows[0]["Rss10034PersonalUrl"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10035 I continue with the following details:")]
        [Given(@"In RSS10035 I continue with the following details:")]
        public void InRSS10035ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10035");
            RSS10035.HolderTypeCode.SetValue(1, table.Rows[0]["HolderTypeCode"]);
            RSS10035.HolderOtherTaxCode.SetValue(1, table.Rows[0]["HolderOtherTaxCode"]);
            //RSS10035.HolderGroupCode.SetValue(1, table.Rows[0]["HolderGroupCode"]);
            //RSS10035.HolderStatusFlags.SetValue(1, table.Rows[0]["HolderStatusFlags"]);
            //RSS10035.HstDeceased.SetValue(1, table.Rows[0]["HstDeceased"]);
            //RSS10035.HstException.SetValue(1, table.Rows[0]["HstException"]);
            //RSS10035.HstStopTrade.SetValue(1, table.Rows[0]["HstStopTrade"]);
            //RSS10035.HstAnnualReport.SetValue(1, table.Rows[0]["HstAnnualReport"]);
            //RSS10035.HstDividendReport.SetValue(1, table.Rows[0]["HstDividendReport"]);
            //RSS10035.HolderVariableFlags.SetValue(1, table.Rows[0]["HolderVariableFlags"]);
            //RSS10035.VariableField.SetValue(1, table.Rows[0]["VariableField"]);
            RSS10035.TfnDesc.SetValue(1, table.Rows[0]["TfnDesc"]);
            //RSS10035.HolderDates.SetValue(1, table.Rows[0]["HolderDates"]);
            //RSS10035.MailUnclaimedDate.SetValue(1, table.Rows[0]["MailUnclaimedDate"]);
            //RSS10035.HolderONDate.SetValue(1, table.Rows[0]["HolderONDate"]);
            //RSS10035.HolderOffDate.SetValue(1, table.Rows[0]["HolderOffDate"]);
            //RSS10035.HolderAddedDate.SetValue(1, table.Rows[0]["HolderAddedDate"]);
            //RSS10035.HolderBirthDate.SetValue(1, table.Rows[0]["HolderBirthDate"]);
            //RSS10035.BrokerCode.SetValue(1, table.Rows[0]["BrokerCode"]);
            //RSS10035.USTaxDetails.SetValue(1, table.Rows[0]["USTaxDetails"]);
            //RSS10035.IrlTaxDetails.SetValue(1, table.Rows[0]["IrlTaxDetails"]);
            //RSS10035.ZafTaxDetails.SetValue(1, table.Rows[0]["ZafTaxDetails"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10039 I continue with the following details:")]
        [Given(@"In RSS10039 I continue with the following details:")]
        public void InRSS10039ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10039");
            RSS10039.ExtraIdentifier.SetValue(1, table.Rows[0]["ExtraIdentifier"]);
            RSS10039.HomePhone.SetValue(1, table.Rows[0]["HomePhone"]);
            RSS10039.WorkPhone.SetValue(1, table.Rows[0]["WorkPhone"]);
            RSS10039.FaxNumber.SetValue(1, table.Rows[0]["FaxNumber"]);
            RSS10039.MobilePhone.SetValue(1, table.Rows[0]["MobilePhone"]);
            //RSS10039.Abn.SetValue(1, table.Rows[0]["Abn"]);
            //RSS10039.ExtraWarningFlags.SetValue(1, table.Rows[0]["ExtraWarningFlags"]);
            //RSS10039.EmailAddress.SetValue(1, table.Rows[0]["EmailAddress"]);
            //RSS10039.ReturnedEmail.SetValue(1, table.Rows[0]["ReturnedEmail"]);
            //if (table.Rows[0]["CommMethods"] ==  "Y")
            //{
            //    RSS10039.CommMethods.SetValue(1, table.Rows[0]["CommMethods"]);
            //}

            //RSS10039.UsePubCatDesc.SetValue(1, table.Rows[0]["UsePubCatDesc"]);
            // RSS10039.SuppressCommMethod.SetValue(1, table.Rows[0]["SuppressCommMethod"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10036 I continue with the following details:")]
        [Given(@"In RSS10036 I continue with the following details:")]
        public void RSS10036ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10036");
            if (table.Rows[0]["BalanceDetails"] == "Y")
            {
                RSS10036.BalanceDetails.SetValue(1, table.Rows[0]["BalanceDetails"]);
                RSS10036.BalanceDetails.ClickField();
                WinFormsTestSteps.PressTAB();
                if (table.Rows[0]["ClassTotals"] == "Y")
                {
                    RSS10036.ClassTotals.SetValue(1, table.Rows[0]["ClassTotals"]);
                    RSS10036.ClassTotals.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10036.Class.SetValue(1, table.Rows[0]["Class"]);
                }
                //RSS10036.CertificateNmbrs.SetValue(1, table.Rows[0]["CertificateNmbrs"]);
                if (table.Rows[0]["GroupTotals"] == "Y")
                {
                    RSS10036.GroupTotals.SetValue(1, table.Rows[0]["GroupTotals"]);
                    RSS10036.GroupTotals.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10036.ReportClassORGroup.SetValue(1, table.Rows[0]["ReportClassORGroup"]);
                    RSS10036.ClassGroup.SetValue(1, table.Rows[0]["ClassGroup"]);
                }
                //RSS10036.RegisterRequired.SetValue(1, table.Rows[0]["RegisterRequired"]);
                //RSS10036.Register.SetValue(1, table.Rows[0]["Register"]);
            }
            if (table.Rows[0]["PlanDetails"] == "Y")
            {
                RSS10036.PlanDetails.SetValue(1, table.Rows[0]["PlanDetails"]);
                RSS10036.PlanDetails.ClickField();
                WinFormsTestSteps.PressTAB();
                if (table.Rows[0]["DrpDetails"] == "Y")
                {
                    RSS10036.DrpDetails.SetValue(1, table.Rows[0]["DrpDetails"]);
                    RSS10036.DrpDetails.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10036.DrpPlanDesc.SetValue(1, table.Rows[0]["DrpPlanDesc"]);
                }
                if (table.Rows[0]["BspDetails"] == "Y")
                {
                    RSS10036.BspDetails.SetValue(1, table.Rows[0]["BspDetails"]);
                    RSS10036.BspDetails.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10036.BspPlanDesc.SetValue(1, table.Rows[0]["BspPlanDesc"]);
                }
            }
            if (table.Rows[0]["DirectCredit"] == "Y")
            {
                RSS10036.DirectCredit.SetValue(1, table.Rows[0]["DirectCredit"]);
                RSS10036.DirectCredit.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10036.BankAccountNbr.SetValue(1, table.Rows[0]["BankAccountNbr"]);
                RSS10036.BankAccountName.SetValue(1, table.Rows[0]["BankAccountName"]);
                RSS10036.BankID.SetValue(1, table.Rows[0]["BankID"]);
                RSS10036.BankNamadd.SetValue(1, table.Rows[0]["BankNamadd"]);
            }
            if (table.Rows[0]["ResidencyInd"] == "Y")
            {
                RSS10036.ResidencyInd.SetValue(1, table.Rows[0]["ResidencyInd"]);
            }
            if (table.Rows[0]["PayeeDetails"] == "Y")
            {
                RSS10036.PayeeDetails.SetValue(1, table.Rows[0]["PayeeDetails"]);
                RSS10036.PayeeDetails.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10036.PayeeAddress.SetValue(1, table.Rows[0]["PayeeAddress"]);
                RSS10036.PayeePcodeDomicile.SetValue(1, table.Rows[0]["PayeePcodeDomicile"]);
            }
            if (table.Rows[0]["ForeignChequeInd"] == "Y")
            {
                RSS10036.ForeignChequeInd.SetValue(1, table.Rows[0]["ForeignChequeInd"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10029 I continue with the following details:")]
        [Given(@"In RSS10029 I continue with the following details:")]
        public void RSS10029ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10029");
            RSS10029.BulkPayInd.SetValue(1, table.Rows[0]["BulkPayInd"]);
            if (table.Rows[0]["BulkPayInd"] == "S")
            {
                RSS10029.BulkPayInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10029.BulkPay.SetValue(1, table.Rows[0]["BulkPay"]);
                //RSS10029.BulkPay.SetValue(2, table.Rows[0]["BulkPay2"]);
                //RSS10029.BulkPay.SetValue(3, table.Rows[0]["BulkPay3"]);
                //RSS10029.BulkPay.SetValue(4, table.Rows[0]["BulkPay4"]);
                //RSS10029.BulkPay.SetValue(5, table.Rows[0]["BulkPay5"]);
                //RSS10029.BulkPay.SetValue(6, table.Rows[0]["BulkPay6"]);
            }

            RSS10029.DirectCreditInd.SetValue(1, table.Rows[0]["DirectCreditInd"]);
            if (table.Rows[0]["DirectCreditInd"] == "S")
            {
                RSS10029.DirectCreditInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10029.DirectCredit.SetValue(1, table.Rows[0]["DirectCredit"]);
                //RSS10029.DirectCredit.SetValue(2, table.Rows[0]["DirectCredit2"]);
                //RSS10029.DirectCredit.SetValue(3, table.Rows[0]["DirectCredit3"]);
                //RSS10029.DirectCredit.SetValue(4, table.Rows[0]["DirectCredit4"]);
                //RSS10029.DirectCredit.SetValue(5, table.Rows[0]["DirectCredit5"]);
                //RSS10029.DirectCredit.SetValue(6, table.Rows[0]["DirectCredit6"]);
                //RSS10029.DirectCredit.SetValue(7, table.Rows[0]["DirectCredit7"]);
                //RSS10029.DirectCredit.SetValue(8, table.Rows[0]["DirectCredit8"]);
            }

            RSS10029.ForeignChequeInd.SetValue(1, table.Rows[0]["ForeignChequeInd"]);
            if (table.Rows[0]["ForeignChequeInd"] == "S")
            {
                RSS10029.ForeignChequeInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10029.ForeignCurrency.SetValue(1, table.Rows[0]["ForeignCurrency1"]);
                RSS10029.ForeignCurrency.SetValue(2, table.Rows[0]["ForeignCurrency2"]);
                //RSS10029.ForeignCurrency.SetValue(3, table.Rows[0]["ForeignCurrency3"]);
                //RSS10029.ForeignCurrency.SetValue(4, table.Rows[0]["ForeignCurrency4"]);
                //RSS10029.ForeignCurrency.SetValue(5, table.Rows[0]["ForeignCurrency5"]);
            }

            //Commented -Contact Peter  7/1/2016

            RSS10029.WireInd.SetValue(1, table.Rows[0]["WireInd"]);
            if (table.Rows[0]["WireInd"] == "S")
            {
                RSS10029.WireInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10029.WireCurrency.SetValue(1, table.Rows[0]["WireCurrency1"]);
                //RSS10029.WireCurrency.SetValue(2, table.Rows[0]["WireCurrency2"]);
                //RSS10029.WireCurrency.SetValue(3, table.Rows[0]["WireCurrency3"]);
                //RSS10029.WireCurrency.SetValue(4, table.Rows[0]["WireCurrency4"]);
                //RSS10029.WireCurrency.SetValue(5, table.Rows[0]["WireCurrency5"]);
            }

            RSS10029.ThirdPartyInd.SetValue(1, table.Rows[0]["ThirdPartyInd"]);
            if (table.Rows[0]["ThirdPartyInd"] == "S")
            {
                RSS10029.ThirdPartyInd.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10029.ThirdPartyPCInd.SetValue(1, table.Rows[0]["ThirdPartyPCInd"]);
                if (table.Rows[0]["ThirdPartyPCInd"] == "E" || table.Rows[0]["ThirdPartyPCInd"] == "I")
                {
                    RSS10029.ThirdPartyPCInd.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10029.PCFrom1.SetValue(1, table.Rows[0]["PCFrom1"]);
                    RSS10029.PCTo1.SetValue(1, table.Rows[0]["PCTo1"]);
                    //RSS10029.PCFrom2.SetValue(1, table.Rows[0]["PCFrom2"]);
                    //RSS10029.PCTo2.SetValue(1, table.Rows[0]["PCTo2"]);
                    //RSS10029.PCFrom3.SetValue(1, table.Rows[0]["PCFrom3"]);
                    //RSS10029.PCTo3.SetValue(1, table.Rows[0]["PCTo3"]);
                    //RSS10029.PCFrom4.SetValue(1, table.Rows[0]["PCFrom4"]);
                    //RSS10029.PCTo4.SetValue(1, table.Rows[0]["PCTo4"]);
                }

                RSS10029.ThirdPartyDCInd.SetValue(1, table.Rows[0]["ThirdPartyDCInd"]);
                if (table.Rows[0]["ThirdPartyDCInd"] == "E" || table.Rows[0]["ThirdPartyDCInd"] == "I")
                {
                    RSS10029.DomCodes.SetValue(1, table.Rows[0]["DomCodes1"]);
                    //RSS10029.DomCodes.SetValue(2, table.Rows[0]["DomCodes2"]);
                    //RSS10029.DomCodes.SetValue(3, table.Rows[0]["DomCodes3"]);
                    //RSS10029.DomCodes.SetValue(4, table.Rows[0]["DomCodes4"]);
                    //RSS10029.DomCodes.SetValue(5, table.Rows[0]["DomCodes5"]);
                    //RSS10029.DomCodes.SetValue(6, table.Rows[0]["DomCodes6"]);
                    //RSS10029.DomCodes.SetValue(7, table.Rows[0]["DomCodes7"]);
                    //RSS10029.DomCodes.SetValue(8, table.Rows[0]["DomCodes8"]);
                    //RSS10029.DomCodes.SetValue(9, table.Rows[0]["DomCodes9"]);
                    //RSS10029.DomCodes.SetValue(10, table.Rows[0]["DomCodes10"]);
                }
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10048 I continue with the following details:")]
        [Given(@"In RSS10048 I continue with the following details:")]
        public void RSS10048ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10048");
            RSS10048.DetailRecordOutput.SetValue(1, table.Rows[0]["DetailRecordOutput"]);
            if (table.Rows[0]["DetailRecordOutput"] == "H")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            if (table.Rows[0]["DetailRecordOutput"] == "C")
            {
                //RSS10048.Class.SetValue(1, table.Rows[0]["Class"]);
                RSS10048.DetailRecordOutput.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10048.RemittRefNumbers.SetValue(1, table.Rows[0]["RemittRefNumbers"]);
                if (table.Rows[0]["RemittRefNumbers"] == "Y")
                {
                    RSS10048.RemittRefNumbers.ClickField();
                    WinFormsTestSteps.PressTAB();
                    RSS10048.GenerateRrn.SetValue(1, table.Rows[0]["GenerateRrn"]);
                }
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (table.Rows[0]["DetailRecordOutput"] == "T")
            {
                RSS10048.SlrDetails.SetValue(1, table.Rows[0]["SlrDetails"]);
                RSS10048.SubRecTypeDetails.SetValue(1, table.Rows[0]["SubRecTypeDetails"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10046 I continue with the following details:")]
        [Given(@"In RSS10046 I continue with the following details:")]
        public void RSS10046ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10046");
            RSS10046.WebProxyMailing.SetValue(1, table.Rows[0]["WebProxyMailing"]);
            //RSS10046.ProxyMeeting.SetValue(1, table.Rows[0]["ProxyMeeting"]);
            //RSS10046.RequiredPin.SetValue(1, table.Rows[0]["RequiredPin"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10041 I continue with the following details:")]
        [Given(@"In RSS10041 I continue with the following details:")]
        public void RSS10041ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10041");
            if (table.Rows[0]["IncludeDetails"] == "N")
            {
                RSS10041.IncludeDetails.SetValue(1, table.Rows[0]["IncludeDetails"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (table.Rows[0]["IncludeDetails"] == "Y")
            {
                RSS10041.IncludeDetails.SetValue(1, table.Rows[0]["IncludeDetails"]);
                RSS10041.IncludeDetails.ClickField();
                WinFormsTestSteps.PressTAB();

                RSS10041.EmpIDInd.SetValue(1, table.Rows[0]["EmpIDInd"]);
                //RSS10041.AutoForfitInd.SetValue(1, table.Rows[0]["AutoForfitInd"]);
                RSS10041.PayIDInd.SetValue(1, table.Rows[0]["PayIDInd"]);
                //RSS10041.LeaverPackInd.SetValue(1, table.Rows[0]["LeaverPackInd"]);
                RSS10041.EmployeeUniqueIDInd.SetValue(1, table.Rows[0]["EmployeeUniqueIDInd"]);
                //RSS10041.LevrPckSentDateInd.SetValue(1, table.Rows[0]["LevrPckSentDateInd"]);
                RSS10041.LocCodesInd.SetValue(1, table.Rows[0]["LocCodesInd"]);
                //RSS10041.TermDateInd.SetValue(1, table.Rows[0]["TermDateInd"]);
                RSS10041.BusUnitsInd.SetValue(1, table.Rows[0]["BusUnitsInd"]);
                //RSS10041.TermDescInd.SetValue(1, table.Rows[0]["TermDescInd"]);
                RSS10041.JobBandsInd.SetValue(1, table.Rows[0]["JobBandsInd"]);
                RSS10041.CostCentreInd.SetValue(1, table.Rows[0]["CostCentreInd"]);
                //RSS10041.EmpFlag1Ind.SetValue(1, table.Rows[0]["EmpFlag1Ind"]);
                //RSS10041.NatInsNumInd.SetValue(1, table.Rows[0]["NatInsNumInd"]);
                //RSS10041.EmpFlag2Ind.SetValue(1, table.Rows[0]["EmpFlag2Ind"]);
                //RSS10041.PrefNameInd.SetValue(1, table.Rows[0]["PrefNameInd"]);
                //RSS10041.EmpStatusInd.SetValue(1, table.Rows[0]["EmpStatusInd"]);
                //RSS10041.EffDateInd.SetValue(1, table.Rows[0]["EffDateInd"]);
                //RSS10041.BlkoutRstrctdInd.SetValue(1, table.Rows[0]["BlkoutRstrctdInd"]);
                //RSS10041.StartDateInd.SetValue(1, table.Rows[0]["StartDateInd"]);
                //RSS10041.BlkoutRstrctdCdeInd.SetValue(1, table.Rows[0]["BlkoutRstrctdCdeInd"]);
                //RSS10041.BirthDateInd.SetValue(1, table.Rows[0]["BirthDateInd"]);
                //RSS10041.GspEmployeeInd.SetValue(1, table.Rows[0]["GspEmployeeInd"]);
                //RSS10041.SubPayrollIDInd.SetValue(1, table.Rows[0]["SubPayrollIDInd"]);
                //RSS10041.LeaverCodeInd.SetValue(1, table.Rows[0]["LeaverCodeInd"]);
                RSS10041.EmpCommMethodsInd.SetValue(1, table.Rows[0]["EmpCommMethodsInd"]);
                WinFormsTestSteps.Transmit();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10037 I continue with the following details:")]
        [Given(@"In RSS10037 I continue with the following details:")]
        public void RSS10037ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10037");
            RSS10037.FieldSeparator.SetValue(1, table.Rows[0]["FieldSeparator"]);
            //RSS10037.TextDelimiterReq.SetValue(1, table.Rows[0]["TextDelimiterReq"]);
            //RSS10037.TextDelimiter.SetValue(1, table.Rows[0]["TextDelimiter"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10028 I continue with the following details:")]
        [Given(@"In RSS10028 I continue with the following details:")]
        public void RSS10028ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10028");
            //RSS10028.MenuItemA.SetValue(1, table.Rows[0]["MenuItemA"]);
            //RSS10028.MenuItemP.SetValue(1, table.Rows[0]["MenuItemP"]);
            //RSS10028.MenuItemD.SetValue(1, table.Rows[0]["MenuItemD"]);
            //RSS10028.MenuItemS.SetValue(1, table.Rows[0]["MenuItemS"]);
            //RSS10028.MenuItemH.SetValue(1, table.Rows[0]["MenuItemH"]);
            //RSS10028.MenuItemB.SetValue(1, table.Rows[0]["MenuItemB"]);
            //RSS10028.MenuItemX.SetValue(1, table.Rows[0]["MenuItemX"]);
            //RSS10028.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            //RSS10028.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            //RSS10028.RunNumberFrom.SetValue(1, table.Rows[0]["RunNumberFrom"]);
            //RSS10028.RunNumberTO.SetValue(1, table.Rows[0]["RunNumberTO"]);
            //RSS10028.ASATRun.SetValue(1, table.Rows[0]["ASATRun"]);
            RSS10028.ReportSeq.SetValue(1, table.Rows[0]["ReportSeq"]);
            //RSS10028.CutoffPoint.SetValue(1, table.Rows[0]["CutoffPoint"]);
            //RSS10028.ReturnMailATEnd.SetValue(1, table.Rows[0]["ReturnMailATEnd"]);
            //RSS10028.ProduceEmailList.SetValue(1, table.Rows[0]["ProduceEmailList"]);
            //RSS10028.FurtherSequencing.SetValue(1, table.Rows[0]["FurtherSequencing"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [Given(@"In RSS10097 I continue")]
        [When(@"In RSS10097 I continue")]
        public void GivenInRSS10097Continue()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10097");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS10001 I continue with the following details:")]
        [When(@"In RSS10001 I continue with the following details:")]
        public void GivenInRSS10001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10001");
            RSS10001.Preload.SetValue(1, table.Rows[0]["Preload"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01500 I continue with the following details:")]
        [When(@"In RSS01500 I continue with the following details:")]
        public void GivenInRSS01500ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01500");
            RSS01500.PreloadDefaults.SetValue(1, table.Rows[0]["PreloadDefaults"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [Given(@"In RSS18010 I click on: ""(.*)"" within the Shareholder Movement Reporting Menu")]
        [When(@"In RSS18010 I click on: ""(.*)"" within the Shareholder Movement Reporting Menu")]
        public void ClickWithinTheShareholderMovementMenu(string menuOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS18010");
            switch (menuOption.ToLower())
            {
                case "significant holder report":
                    RSS18010.MenuItemSH.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "significant trade report":
                    RSS18010.MenuItemST.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "shareholder movement report":
                    RSS18010.MenuItemSM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS19001 I continue with the following details:")]
        [When(@"In RSS19001 I continue with the following details:")]
        public void GivenInRSS19001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS19001");
            //RSS19001.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            RSS19001.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS19001.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS19001.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            //RSS19001.Clg.SetValue(1, table.Rows[0]["Clg"]);
            //RSS19001.Htc.SetValue(1, table.Rows[0]["Htc"]);
            RSS19001.BalanceLimit.SetValue(1, table.Rows[0]["BalanceLimit"]);
            RSS19001.BalanceLimit.SetValue(1, table.Rows[0]["BalanceLimit"]);
            RSS19001.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            RSS19001.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS09001 I continue with the following details:")]
        [When(@"In RSS09001 I continue with the following details:")]
        public void GivenInRSS09001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS09001");
            //RSS09001.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            RSS09001.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS09001.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS09001.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            RSS09001.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            //RSS09001.Clg.SetValue(1, table.Rows[0]["Clg"]);
            RSS09001.Level.SetValue(1, table.Rows[0]["Level"]);
            RSS09001.Sequence.SetValue(1, table.Rows[0]["Sequence"]);
            RSS09001.BrokerCode.SetValue(1, table.Rows[0]["BrokerCode"]);
            RSS09001.Selection.SetValue(1, table.Rows[0]["Selection"]);
            RSS09001.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            RSS09001.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            RSS09001.TransGroupFrom.SetValue(1, table.Rows[0]["TransGroupFrom"]);
            RSS09001.TransGroupTO.SetValue(1, table.Rows[0]["TransGroupTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS13003 I continue with the following details:")]
        [When(@"In RSS13003 I continue with the following details:")]
        public void GivenInRSS13003ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS13003");
            RSS13003.Companies.SetValue(1, table.Rows[0]["Companies"]);
            RSS13003.OutputFormat.SetValue(1, table.Rows[0]["OutputFormat"]);
            RSS13003.DateFrom.SetValue(1, table.Rows[0]["DateFrom"]);
            RSS13003.DateTO.SetValue(1, table.Rows[0]["DateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01501 I continue with the following details:")]
        [When(@"In RSS01501 I continue with the following details:")]
        public void GivenInRSS01501ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01501");
            // RSS01501.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            RSS01501.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS01501.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS01501.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            RSS01501.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            RSS01501.ClgCon.SetValue(1, table.Rows[0]["ClgCon"]);
            //RSS01501.GroupIDX.SetValue(1, table.Rows[0]["GroupIDX"]);
            RSS01501.Selection.SetValue(1, table.Rows[0]["Selection"]);
            RSS01501.Selection.ClickField();
            WinFormsTestSteps.PressTAB();
            RSS01501.GroupEssTrustees.SetValue(1, table.Rows[0]["GroupEssTrustees"]);
            if (table.Rows[0]["HighestBalanceLevel"] != "")
            {
                RSS01501.HighestBalanceLevel.SetValue(1, table.Rows[0]["HighestBalanceLevel"]);
            }
            if (table.Rows[0]["MovementSelection"] != "")
            {
                RSS01501.MovementSelection.SetValue(1, table.Rows[0]["MovementSelection"]);
                RSS01501.MovementLevel.SetValue(1, table.Rows[0]["MovementLevel"]);
            }

            // RSS01501.ClosingBalanceLevel.SetValue(1, table.Rows[0]["ClosingBalanceLevel"]);
            RSS01501.ReportingPeriod.SetValue(1, table.Rows[0]["ReportingPeriod"]);
            RSS01501.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            RSS01501.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            RSS01501.NameAddressTOPrint.SetValue(1, table.Rows[0]["NameAddressTOPrint"]);
            RSS01501.Sequence.SetValue(1, table.Rows[0]["Sequence"]);
            //RSS01501.HolderLimit.SetValue(1, table.Rows[0]["HolderLimit"]);
            RSS01501.HolderIDTOPrint.SetValue(1, table.Rows[0]["HolderIDTOPrint"]);
            RSS01501.Order.SetValue(1, table.Rows[0]["Order"]);
            RSS01501.IncEntrepot.SetValue(1, table.Rows[0]["IncEntrepot"]);
            // RSS01501.VarianceOrder.SetValue(1, table.Rows[0]["VarianceOrder"]);
            if (table.Rows[0]["PrintGrpDetails"] == "")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else
            {
                RSS01501.PrintGrpDetails.SetValue(1, table.Rows[0]["PrintGrpDetails"]);
                //RSS01501.SystemInfoFree6.SetValue(1, table.Rows[0]["SystemInfoFree6"]);
                //RSS01501.SystemInfoFree4.SetValue(1, table.Rows[0]["SystemInfoFree4"]);
                //RSS01501.SystemInfoFree7.SetValue(1, table.Rows[0]["SystemInfoFree7"]);
                //RSS01501.SystemInfoFree5.SetValue(1, table.Rows[0]["SystemInfoFree5"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS26001 I continue with the following details:")]
        [When(@"In RSS26001 I continue with the following details:")]
        public void GivenInRSS26001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS26001");
            RSS26001.Hldacc.SetValue(1, table.Rows[0]["Hldacc"]);
            RSS26001.CompanyCode.SetValue(1, table.Rows[0]["CompanyCode"]);
            RSS26001.HolderID.SetValue(1, table.Rows[0]["HolderID"]);
            RSS26001.CusRep1.SetValue(1, table.Rows[0]["CusRep1"]);
            RSS26001.CusRep1.ClickField();
            WinFormsTestSteps.PressTAB();
            RSS26001.HldrInstr1.SetValue(1, table.Rows[0]["HldrInstr1"]);
            RSS26001.NOInstr1.SetValue(1, table.Rows[0]["NOInstr1"]);
            RSS26001.ExclNil1.SetValue(1, table.Rows[0]["ExclNil1"]);
            RSS26001.CusRep2.SetValue(1, table.Rows[0]["CusRep2"]);
            RSS26001.CusRep2.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["CusRep2"] == "Y")
            {
                RSS26001.HldrInstr2.SetValue(1, table.Rows[0]["HldrInstr2"]);
                RSS26001.NOInstr2.SetValue(1, table.Rows[0]["NOInstr2"]);
                RSS26001.ExclNil2.SetValue(1, table.Rows[0]["ExclNil2"]);
            }
            RSS26001.CusRep3.SetValue(1, table.Rows[0]["CusRep3"]);
            RSS26001.CusRep3.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["CusRep3"] == "Y")
            {
                RSS26001.HldrInstr3.SetValue(1, table.Rows[0]["HldrInstr3"]);
                RSS26001.NOInstr3.SetValue(1, table.Rows[0]["NOInstr3"]);
                RSS26001.ExclNil3.SetValue(1, table.Rows[0]["ExclNil3"]);
            }
            RSS26001.CusRep4.SetValue(1, table.Rows[0]["CusRep4"]);
            RSS26001.CusRep4.ClickField();
            WinFormsTestSteps.PressTAB();

            if (table.Rows[0]["CusRep4"] == "Y")
            {
                RSS26001.ExclNil4.SetValue(1, table.Rows[0]["ExclNil4"]);
            }

            RSS26001.CusRep5.SetValue(1, table.Rows[0]["CusRep5"]);
            RSS26001.CusRep5.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["CusRep5"] == "Y")
            {
                RSS26001.ExclNil5.SetValue(1, table.Rows[0]["ExclNil5"]);
                RSS26001.PaymentDateFrom.SetValue(1, table.Rows[0]["PaymentDateFrom"]);
                RSS26001.PaymentDateTO.SetValue(1, table.Rows[0]["PaymentDateTO"]);
            }
            RSS26001.CusRep6.SetValue(1, table.Rows[0]["CusRep6"]);
            RSS26001.CusRep6.ClickField();
            WinFormsTestSteps.PressTAB();
            //RSS26001.SystemInfoFree6.SetValue(1, table.Rows[0]["SystemInfoFree6"]);
            //RSS26001.SystemInfoFree4.SetValue(1, table.Rows[0]["SystemInfoFree4"]);
            //RSS26001.SystemInfoFree7.SetValue(1, table.Rows[0]["SystemInfoFree7"]);
            //RSS26001.SystemInfoFree5.SetValue(1, table.Rows[0]["SystemInfoFree5"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01020 I continue with the following details:")]
        [When(@"In RSS01020 I continue with the following details:")]
        public void GivenInRSS1020ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01020");
            RSS01020.ReportDesc.SetValue(1, table.Rows[0]["ReportDesc"]);
            RSS01020.ASATRun.SetValue(1, table.Rows[0]["ASATRun"]);
            RSS01020.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            RSS01020.InputFile.SetValue(1, table.Rows[0]["InputFile"]);
            RSS01020.InputFile.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["InputFile"] == "Y")
            {
                RSS01020.InputFilename.SetValue(1, table.Rows[0]["InputFilename"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01030 I continue with the following details:")]
        [When(@"In RSS01030 I continue with the following details:")]
        public void GivenInRSS1030ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01030");
            RSS01030.Cls.SetValue(1, table.Rows[0]["Cls1"]);
            RSS01030.Cls.SetValue(2, table.Rows[0]["Cls2"]);
            RSS01030.Cls.SetValue(3, table.Rows[0]["Cls3"]);
            RSS01030.Cls.SetValue(4, table.Rows[0]["Cls4"]);
            RSS01030.Cls.SetValue(5, table.Rows[0]["Cls5"]);
            RSS01030.Cls.SetValue(6, table.Rows[0]["Cls6"]);
            RSS01030.Cls.SetValue(7, table.Rows[0]["Cls7"]);
            RSS01030.Cls.SetValue(8, table.Rows[0]["Cls8"]);
            RSS01030.Cls.SetValue(9, table.Rows[0]["Cls9"]);
            RSS01030.Cls.SetValue(10, table.Rows[0]["Cls10"]);
            RSS01030.Clg.SetValue(1, table.Rows[0]["Clg1"]);
            RSS01030.Clg.SetValue(2, table.Rows[0]["Clg2"]);
            RSS01030.Clg.SetValue(3, table.Rows[0]["Clg3"]);
            RSS01030.GroupIDX.SetValue(1, table.Rows[0]["GroupIDX1"]);
            RSS01030.GroupIDX.SetValue(2, table.Rows[0]["GroupIDX2"]);
            RSS01030.GroupIDX.SetValue(3, table.Rows[0]["GroupIDX3"]);
            if (table.ContainsColumn("Reg1"))
            {
                RSS01030.Reg.SetValue(1, table.Rows[0]["Reg1"]);
                RSS01030.Reg.SetValue(2, table.Rows[0]["Reg2"]);
                RSS01030.Reg.SetValue(3, table.Rows[0]["Reg3"]);
            }
            if (table.Rows[0]["ReportingPeriod"] != "")
            {
                if (table.Rows[0]["ReportingPeriod"] == "R")
                {
                    RSS01030.ReportingPeriod.SetValue(1, table.Rows[0]["ReportingPeriod"]);
                    RSS01030.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
                    RSS01030.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
                }
                RSS01030.ReportingPeriod.SetValue(1, table.Rows[0]["ReportingPeriod"]);
            }

            if (table.Rows[0]["MandatoryDCInd"] == "Y")
            {
                RSS01030.MandatoryDCInd.SetValue(1, table.Rows[0]["MandatoryDCInd"]);
                if (table.Rows[0]["MandDCDom1"] != "")
                {
                    RSS01030.MandDCDom.SetValue(1, table.Rows[0]["MandDCDom1"]);
                    RSS01030.MandDCDom.SetValue(2, table.Rows[0]["MandDCDom2"]);
                    RSS01030.MandDCDom.SetValue(3, table.Rows[0]["MandDCDom3"]);
                }
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS11000 I continue with the following details:")]
        [When(@"In RSS11000 I continue with the following details:")]
        public void GivenInRSS11000ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11000");
            RSS11000.PreloadDefaults.SetValue(1, table.Rows[0]["Preload"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS01040 I continue with the following details:")]
        [When(@"In RSS01040 I continue with the following details:")]
        public void GivenInRSS01040ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01040");
            //RSS01040.FormatDesc.SetValue(1, table.Rows[0]["FormatDesc"]);
            RSS01040.Runits18From.SetValue(1, table.Rows[0]["Runits18From"]);
            RSS01040.Runits18TO.SetValue(1, table.Rows[0]["Runits18TO"]);
            RSS01040.Runits18From.SetValue(2, table.Rows[0]["Runits916From"]);
            RSS01040.Runits18TO.SetValue(2, table.Rows[0]["Runits916TO"]);
            //RSS01040.Runits18From.SetValue(3, table.Rows[0]["Runits916From2"]);
            //RSS01040.Runits18TO.SetValue(3, table.Rows[0]["Runits916TO2"]);
            //RSS01040.Runits916From.SetValue(1, table.Rows[0]["Runits916From"]);
            //RSS01040.Runits916TO.SetValue(1, table.Rows[0]["Runits916TO"]);
            if (table.Rows[0]["UseClassPrice"] == "Y")
            {
                RSS01040.UseClassPrice.SetValue(1, table.Rows[0]["UseClassPrice"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                GivenInRSS01070ContinueWithTheFollowingDetails(table);
            }
            else
            {
                RSS01040.UseClassPrice.SetValue(1, table.Rows[0]["UseClassPrice"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="table">data table</param>
        [Given(@"In RSS01050 I continue with the following details:")]
        [When(@"In RSS01050 I continue with the following details:")]
        public void GivenInRSS01050ContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (formname == "RSS01045")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "RSS01050")
            {


                WinFormsTestSteps.ExpectToBeInTheScreen("RSS01050");
                if (table.ContainsColumn("HtcFlag") == true)
                {
                    RSS01050.HtcFlag.SetValue(1, table.Rows[0]["HtcFlag"]);
                    RSS01050.HT.SetValue(1, table.Rows[0]["HT1"]);
                    RSS01050.HT.SetValue(2, table.Rows[0]["HT2"]);
                    RSS01050.HT.SetValue(3, table.Rows[0]["HT3"]);
                    if (table.ContainsColumn("LocalDomicileFlag") == true)
                    {
                        RSS01050.LocalDomicileFlag.SetValue(1, table.Rows[0]["LocalDomicileFlag"]);
                    }
                    if (table.ContainsColumn("DomicileSequence") == true)
                    {
                        RSS01050.DomicileSequence.SetValue(1, table.Rows[0]["DomicileSequence"]);
                    }
                    if (table.ContainsColumn("LocalFlag") == true)
                    {
                        if (table.Rows[0]["LocalFlag"] == "I")
                        {
                            RSS01050.LocalFlag.SetValue(1, table.Rows[0]["LocalFlag"]);
                            RSS01050.LocalFlag.ClickField();
                            WinFormsTestSteps.PressTAB();
                            RSS01050.PCFrom1.SetValue(1, table.Rows[0]["PCFrom1"]);
                            RSS01050.PCTo1.SetValue(1, table.Rows[0]["PCTo1"]);
                            //RSS01050.PCFrom2.SetValue(1, table.Rows[0]["PCFrom2"]);
                            //RSS01050.PCTo2.SetValue(1, table.Rows[0]["PCTo2"]);
                        }
                        RSS01050.LocalFlag.SetValue(1, table.Rows[0]["LocalFlag"]);
                    }

                }
                if (table.Rows[0]["DomcodeFlag"] != "")
                {
                    RSS01050.DomcodeFlag.SetValue(1, table.Rows[0]["DomcodeFlag"]);

                    RSS01050.DomcodeFlag.ClickField();
                    WinFormsTestSteps.PressTAB();
                    if (table.Rows[0]["DomcodeFlag"] == "I")
                    {
                        RSS01050.DC.SetValue(1, table.Rows[0]["DC1"]);
                        RSS01050.DC.SetValue(2, table.Rows[0]["DC2"]);
                    }
                }
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01001 I continue with the following details:")]
        public void ERS01001IContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01001");
            ERS01001.Preload.SetValue(1, table.Rows[0]["Preload"]);
            if (table.Rows[0]["Preload"] == "Y")
            {
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("SLRSP001");
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("SELRSP01");
                SELRSP01.FileSelected.SetValue("1");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01002 I continue with the following details:")]
        public void WhenInERSIContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01002");
            ERS01002.EmpStatus.SetValue(1, table.Rows[0]["EmpStatus1"]);
            ERS01002.EmpStatus.SetValue(2, table.Rows[0]["EmpStatus2"]);
            ERS01002.LeaverCode.SetValue(1, table.Rows[0]["LeaverCode1"]);
            ERS01002.LeaverCode.SetValue(2, table.Rows[0]["LeaverCode2"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01010 I continue with the following details:")]
        public void ERS01010ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01010");
            ERS01010.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01011 I continue with the following details:")]
        public void ERS01011ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01011");
            //Include static details does not have a field ID
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01012 I continue with the following details:")]
        public void ERS01012ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01012");
            ERS01012.ExtraIdentifier.SetValue(1, table.Rows[0]["ExtraIdentifier"]);
            ERS01012.HomePhone.SetValue(1, table.Rows[0]["HomePhone"]);
            ERS01012.EmailAddress.SetValue(1, table.Rows[0]["EmailAddress"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01028 I continue with the following details:")]
        public void ERS01028ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01028");
            ERS01028.HolderStatus.SetValue(1, table.Rows[0]["HolderStatus"]);

            if (table.Rows[0]["HolderStatus"] == "Y")
            {
                ERS01028.HolderStatus.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01028.DeceasedFlag.SetValue(1, table.Rows[0]["DeceasedFlag"]);
                ERS01028.ExceptionFlag.SetValue(1, table.Rows[0]["ExceptionFlag"]);
                ERS01028.StopTradeFlag.SetValue(1, table.Rows[0]["StopTradeFlag"]);
                ERS01028.DivIntentionFlag.SetValue(1, table.Rows[0]["DivIntentionFlag"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01009 I continue with the following details:")]
        public void ERS01009ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01009");
            ERS01009.Selcls.SetValue(1, table.Rows[0]["Selcls"]);
            ERS01009.Selreg.SetValue(1, table.Rows[0]["Selreg1"]);
            ERS01009.Selreg.SetValue(2, table.Rows[0]["Selreg2"]);
            ERS01009.RegType.SetValue(1, table.Rows[0]["RegType1"]);
            ERS01009.RegType.SetValue(2, table.Rows[0]["RegType2"]);
            ERS01009.Participants.SetValue(1, table.Rows[0]["Participants"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01003 I continue with the following details:")]
        public void ERS01003ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01003");
            ERS01003.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            ERS01003.ReportSeq.SetValue(1, table.Rows[0]["ReportSeq"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01013 I continue with the following details:")]
        public void ERS01013ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01013");
            ERS01013.Selcls.SetValue(1, table.Rows[0]["Selcls1"]);
            ERS01013.Selcls.SetValue(2, table.Rows[0]["Selcls2"]);
            ERS01013.Selgrp.SetValue(1, table.Rows[0]["Selgrp1"]);
            ERS01013.Selgrp.SetValue(2, table.Rows[0]["Selgrp2"]);
            ERS01013.Exd.SetValue(1, table.Rows[0]["Exd1"]);
            ERS01013.UnitBalanceFrom.SetValue(1, table.Rows[0]["UnitBalanceFrom"]);
            ERS01013.UnitBalanceTO.SetValue(1, table.Rows[0]["UnitBalanceTO"]);
            ERS01013.HolderTotalsOnly.SetValue(1, table.Rows[0]["HolderTotalsOnly"]);

            if (table.Rows[0].ContainsKey("Selgrp3"))
                ERS01013.Selgrp.SetValue(3, table.Rows[0]["Selgrp3"]);
            if (table.Rows[0].ContainsKey("Selgrp4"))
                ERS01013.Selgrp.SetValue(4, table.Rows[0]["Selgrp4"]);
            if (table.Rows[0].ContainsKey("Selgrp5"))
                ERS01013.Selgrp.SetValue(5, table.Rows[0]["Selgrp5"]);
            if (table.Rows[0].ContainsKey("Selgrp6"))
                ERS01013.Selgrp.SetValue(6, table.Rows[0]["Selgrp6"]);
            if (table.Rows[0].ContainsKey("TransDateFrom"))
                ERS01013.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            if (table.Rows[0].ContainsKey("TransDateTO"))
                ERS01013.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01016 I continue with the following details:")]
        public void ERS01016ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01016");
            ERS01016.ClassCode.SetValue(1, table.Rows[0]["ClassCode"]);
            ERS01016.RegisterCode.SetValue(1, table.Rows[0]["RegisterCode"]);
            ERS01016.RegisterType.SetValue(1, table.Rows[0]["RegisterType"]);

            if (ERS01016.AwardDate.Exists() ==true)
                ERS01016.AwardDate.SetValue(1, table.Rows[0]["AwardDate"]);

            if ((table.Rows[0].ContainsKey("ResidualXferDate")) && (ERS01016.ResidualXferDate.Exists() == true))
                ERS01016.ResidualXferDate.SetValue(1, table.Rows[0]["ResidualXferDate"]);
            if ((table.Rows[0].ContainsKey("ResidualXferAmount")) && (ERS01016.ResidualXferAmount.Exists() == true))
                ERS01016.ResidualXferAmount.SetValue(1, table.Rows[0]["ResidualXferAmount"]);
            if ((table.Rows[0].ContainsKey("HoldingEndDate")) && (ERS01016.HoldingEndDate.Exists() == true))
                ERS01016.HoldingEndDate.SetValue(1, table.Rows[0]["HoldingEndDate"]);
            if ((table.Rows[0].ContainsKey("TaxEndDate")) && (ERS01016.TaxEndDate.Exists() == true))
                ERS01016.TaxEndDate.SetValue(1, table.Rows[0]["TaxEndDate"]);
            if ((table.Rows[0].ContainsKey("Ers01016ForfEndDate")) && (ERS01016.Ers01016ForfEndDate.Exists() == true))
                ERS01016.Ers01016ForfEndDate.SetValue(1, table.Rows[0]["Ers01016ForfEndDate"]);
            if ((table.Rows[0].ContainsKey("Vwap")) && (ERS01016.Vwap.Exists() == true))
                ERS01016.Vwap.SetValue(1, table.Rows[0]["Vwap"]);
            if ((table.Rows[0].ContainsKey("ShareCost")) && (ERS01016.ShareCost.Exists() == true))
                ERS01016.ShareCost.SetValue(1, table.Rows[0]["ShareCost"]);
            if ((table.Rows[0].ContainsKey("CurrentBalance")) && (ERS01016.CurrentBalance.Exists() == true))
                ERS01016.CurrentBalance.SetValue(1, table.Rows[0]["CurrentBalance"]);
            if ((table.Rows[0].ContainsKey("OriginalBalance")) && (ERS01016.OriginalBalance.Exists() == true))
                ERS01016.OriginalBalance.SetValue(1, table.Rows[0]["OriginalBalance"]);
            if ((table.Rows[0].ContainsKey("TotalCost")) && (ERS01016.TotalCost.Exists() == true))
                ERS01016.TotalCost.SetValue(1, table.Rows[0]["TotalCost"]);
            if ((table.Rows[0].ContainsKey("Usan")) && (ERS01016.Usan.Exists() == true))
                ERS01016.Usan.SetValue(1, table.Rows[0]["Usan"]);
            if ((table.Rows[0].ContainsKey("SavingsAmount")) && (ERS01016.SavingsAmount.Exists() == true))
                ERS01016.SavingsAmount.SetValue(1, table.Rows[0]["SavingsAmount"]);
            if ((table.Rows[0].ContainsKey("TotalSavings")) && (ERS01016.TotalSavings.Exists() == true))
                ERS01016.TotalSavings.SetValue(1, table.Rows[0]["TotalSavings"]);
            if ((table.Rows[0].ContainsKey("PaymentFrequency")) && (ERS01016.PaymentFrequency.Exists() == true))
                ERS01016.PaymentFrequency.SetValue(1, table.Rows[0]["PaymentFrequency"]);
            if ((table.Rows[0].ContainsKey("Residue")) && (ERS01016.Residue.Exists() == true))
                ERS01016.Residue.SetValue(1, table.Rows[0]["Residue"]);
            if ((table.Rows[0].ContainsKey("TaxAssessed")) && (ERS01016.TaxAssessed.Exists() == true))
                ERS01016.TaxAssessed.SetValue(1, table.Rows[0]["TaxAssessed"]);
            if ((table.Rows[0].ContainsKey("TerminationInd")) && (ERS01016.TerminationInd.Exists() == true))
                ERS01016.TerminationInd.SetValue(1, table.Rows[0]["TerminationInd"]);

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01017 I continue with the following details:")]
        public void ERS01017ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01017");
            ERS01017.Select.SetValue(1, table.Rows[0]["Select"]);
            ERS01017.FieldSeparator.SetValue(1, table.Rows[0]["FieldSeparator"]);
            ERS01017.TextDelimiterReq.SetValue(1, table.Rows[0]["TextDelimiterReq"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01004 I continue with the following details:")]
        public void ERS01004ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01004");
            ERS01004.Selcls.SetValue(1, table.Rows[0]["Selcls1"]);
            ERS01004.Selcls.SetValue(2, table.Rows[0]["Selcls2"]);
            ERS01004.SelGrp.SetValue(1, table.Rows[0]["SelGrp1"]);
            ERS01004.SelGrp.SetValue(2, table.Rows[0]["SelGrp2"]);
            ERS01004.reg.SetValue(1, table.Rows[0]["Selreg1"]);
            ERS01004.reg.SetValue(2, table.Rows[0]["Selreg2"]);
            ERS01004.RegType.SetValue(1, table.Rows[0]["RegType1"]);
            ERS01004.RegType.SetValue(2, table.Rows[0]["RegType2"]);
            ERS01004.DateFrom.SetValue(1, table.Rows[0]["DateFrom"]);
            ERS01004.DateTO.SetValue(1, table.Rows[0]["DateTO"]);
            ERS01004.SummaryDetailInd.SetValue(1, table.Rows[0]["SummaryDetailInd"]);
            ERS01004.ContributionTypeInd.SetValue(1, table.Rows[0]["ContributionTypeInd"]);
            ERS01004.ContractedSvgsInd.SetValue(1, table.Rows[0]["ContractedSvgsInd"]);
            ERS01004.SvgsContribDiffInd.SetValue(1, table.Rows[0]["SvgsContribDiffInd"]);
            ERS01004.DispResidualsInd.SetValue(1, table.Rows[0]["DispResidualsInd"]);
            ERS01004.DispUnitBalanceInd.SetValue(1, table.Rows[0]["DispUnitBalanceInd"]);
            ERS01004.DispSharePriceInd.SetValue(1, table.Rows[0]["DispSharePriceInd"]);
            ERS01004.DispShareCostInd.SetValue(1, table.Rows[0]["DispShareCostInd"]);
            ERS01004.DispUnitsAllocInd.SetValue(1, table.Rows[0]["DispUnitsAllocInd"]);
            ERS01004.Ers01004RecContribDetsInd.SetValue(1, table.Rows[0]["Ers01004RecContribDetsInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01005 I continue with the following details:")]
        public void ERS01005ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01005");
            ERS01005.SelCls.SetValue(1, table.Rows[0]["Class1"]);
            ERS01005.SelCls.SetValue(2, table.Rows[0]["Class2"]);
            ERS01005.Ers01005Selgrp.SetValue(1, table.Rows[0]["Ers01005Selgrp1"]);
            ERS01005.Ers01005Selgrp.SetValue(2, table.Rows[0]["Ers01005Selgrp2"]);
            ERS01005.Reg.SetValue(1, table.Rows[0]["Reg1"]);
            ERS01005.Reg.SetValue(2, table.Rows[0]["Reg2"]);
            ERS01005.RunORDateRange.SetValue(1, table.Rows[0]["RunORDateRange"]);
            ERS01005.RunORDateRange.ClickField();
            WinFormsTestSteps.PressTAB();

            if (table.Rows[0]["RunORDateRange"] == "R")
            {
                ERS01005.RunRangeFrom.SetValue(1, table.Rows[0]["RunRangeFrom"]);
                ERS01005.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            }
            else if (table.Rows[0]["RunORDateRange"] == "D")
            {
                ERS01005.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
                ERS01005.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            }
            ERS01005.LapseDate.SetValue(1, table.Rows[0]["LapseDate"]);
            ERS01005.TotalsOnly.SetValue(1, table.Rows[0]["TotalsOnly"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01008 I continue with the following details:")]
        public void ERS01008ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01008");
            ERS01008.Selcls.SetValue(1, table.Rows[0]["Selcls1"]);
            ERS01008.Selcls.SetValue(2, table.Rows[0]["Selcls2"]);
            ERS01008.Selgrp.SetValue(1, table.Rows[0]["Selgrp1"]);
            ERS01008.Selgrp.SetValue(2, table.Rows[0]["Selgrp2"]);

            ERS01008.reg.SetValue(1, table.Rows[0]["Selreg1"]);
            ERS01008.reg.SetValue(2, table.Rows[0]["Selreg2"]);


            ERS01008.RegType.SetValue(1, table.Rows[0]["RegType1"]);
            ERS01008.RegType.SetValue(2, table.Rows[0]["RegType2"]);

            ERS01008.RunORDateRange.SetValue(1, table.Rows[0]["RunORDateRange"]);
            ERS01008.RunORDateRange.ClickField();
            WinFormsTestSteps.PressTAB();

            if (table.Rows[0]["RunORDateRange"] == "R")
            {
                ERS01008.RunRangeFrom.SetValue(1, table.Rows[0]["RunRangeFrom"]);
                ERS01008.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            }
            else if (table.Rows[0]["RunORDateRange"] == "D")
            {
                ERS01008.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
                ERS01008.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            }
            ERS01008.SummaryReportCsvInd.SetValue(1, table.Rows[0]["SummaryReportCsvInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01041 I continue with the following details:")]
        public void ERS01041ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01041");
            ERS01041.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01041.SelCls.SetValue(1, table.Rows[0]["ClsCode2"]);
            ERS01041.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01041.SelGrp.SetValue(1, table.Rows[0]["ClsGrp2"]);
            ERS01041.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01041.Reg.SetValue(1, table.Rows[0]["RegCode2"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01039 I continue with the following details:")]
        public void ERS01039ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01039");

            ERS01039.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01039.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01039.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01039.SelGrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01039.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01039.Reg.SetValue(2, table.Rows[0]["RegCode2"]);
            ERS01039.ASATRunDateInd.SetValue(1, table.Rows[0]["ASATRunDateInd"]);
            ERS01039.ASATRunDateInd.ClickField();
            WinFormsTestSteps.PressTAB();

            if (table.Rows[0]["ASATRunDateInd"] == "R")
            {
                ERS01039.ASATRunNum.SetValue(1, table.Rows[0]["ASATRunNum"]);
            }
            else if (table.Rows[0]["ASATRunDateInd"] == "D")
            {
                ERS01039.ASATDate.SetValue(1, table.Rows[0]["ASATDate"]);
            }
            ERS01039.SummaryDetailInd.SetValue(1, table.Rows[0]["SummaryDetailInd"]);
            ERS01039.NilHoldingsInd.SetValue(1, table.Rows[0]["NilHoldingsInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01040 I continue with the following details:")]
        public void ERS01040ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01040");

            ERS01040.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01040.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01040.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01040.SelGrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01040.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01040.Reg.SetValue(2, table.Rows[0]["RegCode2"]);
            ERS01040.VestingDateFrom.SetValue(1, table.Rows[0]["VestingDateFrom"]);
            ERS01040.VestingDateTO.SetValue(1, table.Rows[0]["VestingDateTO"]);
            ERS01040.SummaryDetailInd.SetValue(1, table.Rows[0]["SummaryDetailInd"]);
            ERS01040.TotalsReportInd.SetValue(1, table.Rows[0]["TotalsReportInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01046 I continue with the following details:")]
        public void ERS01046ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01046");

            ERS01046.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01046.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01046.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01046.SelGrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01046.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01046.Reg.SetValue(2, table.Rows[0]["RegCode2"]);


            ERS01046.RunDateRangeInd.SetValue(1, table.Rows[0]["RunDateRangeInd"]);
            ERS01046.RunDateRangeInd.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["RunDateRangeInd"] == "R")
            {
                ERS01046.RunRangeFrom.SetValue(1, table.Rows[0]["RunRangeFrom"]);
                ERS01046.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            }
            else if (table.Rows[0]["RunDateRangeInd"] == "D")
            {
                ERS01046.TranDateFrom.SetValue(1, table.Rows[0]["TranDateFrom"]);
                ERS01046.TranDateTO.SetValue(1, table.Rows[0]["TranDateTO"]);
            }
            ERS01046.SummaryDetailInd.SetValue(1, table.Rows[0]["SummaryDetailInd"]);
            ERS01046.ExerciseStatusInd.SetValue(1, table.Rows[0]["ExerciseStatusInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01042 I continue with the following details:")]
        public void ERS01042ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01042");
            ERS01042.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01042.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01042.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01042.SelGrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01042.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01042.Reg.SetValue(2, table.Rows[0]["RegCode2"]);

            ERS01042.RunDateRangeInd.SetValue(1, table.Rows[0]["RunDateRangeInd"]);
            ERS01042.RunDateRangeInd.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["RunDateRangeInd"] == "R")
            {
                ERS01042.RunRangeFrom.SetValue(1, table.Rows[0]["RunRangeFrom"]);
                ERS01042.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            }
            else if (table.Rows[0]["RunDateRangeInd"] == "D")
            {
                ERS01042.TranDateFrom.SetValue(1, table.Rows[0]["TranDateFrom"]);
                ERS01042.TranDateTO.SetValue(1, table.Rows[0]["TranDateTO"]);
            }
            ERS01042.SummaryDetailInd.SetValue(1, table.Rows[0]["SummaryDetailInd"]);
            ERS01042.CanExpTypeInd.SetValue(1, table.Rows[0]["CanExpTypeInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01023 I continue with the following details:")]
        public void ERS01023ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01023");
            ERS01023.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01023.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01023.Selgrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01023.Selgrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01023.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
            ERS01023.Reg.SetValue(2, table.Rows[0]["RegCode2"]);
            ERS01023.TransDateFrom.SetValue(1, table.Rows[0]["TranDateFrom"]);
            ERS01023.TransDateTO.SetValue(1, table.Rows[0]["TranDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01024 I continue with the following details:")]
        public void ERS01024ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01024");
            ERS01024.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01024.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);

            ERS01024.Selgrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01024.Selgrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01024.TransDateFrom.SetValue(1, table.Rows[0]["TranDateFrom"]);
            ERS01024.TransDateTO.SetValue(1, table.Rows[0]["TranDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01025 I continue with the following details:")]
        public void ERS01025ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01025");
            ERS01025.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01025.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01025.Selgrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01025.Selgrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01025.PayAcct.SetValue(1, table.Rows[0]["PayAcct1"]);
            ERS01025.PayAcct.SetValue(2, table.Rows[0]["PayAcct2"]);
            ERS01025.OneClassPerCatInd.SetValue(1, table.Rows[0]["OneClassPerCatInd1"]);
            ERS01025.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            ERS01025.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01026 I continue with the following details:")]
        public void ERS01026ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01026");
            ERS01026.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
            ERS01026.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            ERS01026.Selgrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01026.Selgrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01026.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            ERS01026.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            ERS01026.NfxdnSelection.SetValue(1, table.Rows[0]["NfxdnSelection"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01029 I continue with the following details:")]
        public void ERS01029ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01029");

            if (ERS01029.SelCls.Exists() == true)
            {
                ERS01029.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
                ERS01029.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
            }
            else
            {
                ERS01029.Class.SetValue(1, table.Rows[0]["ClsCode1"]);
                ERS01029.Class.SetValue(2, table.Rows[0]["ClsCode2"]);
            }
            ERS01029.Selgrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
            ERS01029.Selgrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
            ERS01029.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            ERS01029.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            ERS01029.NfxupSelection.SetValue(1, table.Rows[0]["NfxupSelection"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01056 I continue with the following details:")]
        public void ERS01056ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01056");
            ERS01056.EventType.SetValue(1, table.Rows[0]["EventType"]);
            ERS01056.EventCode.SetValue(1, table.Rows[0]["EventCode1"]);
            ERS01056.EventCode.SetValue(2, table.Rows[0]["EventCode2"]);
            ERS01056.ReportDateFrom.SetValue(1, table.Rows[0]["ReportDateFrom"]);
            ERS01056.ReportDateTO.SetValue(1, table.Rows[0]["ReportDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01057 I continue with the following details:")]
        public void ERS01057ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01057");
            ERS01057.EventCode.SetValue(1, table.Rows[0]["EventCode"]);
            ERS01057.EventType.SetValue(1, table.Rows[0]["EventType1"]);
            ERS01057.EventDate.SetValue(1, table.Rows[0]["EventDate"]);
            ERS01057.WithholdingTaxRate.SetValue(1, table.Rows[0]["WithholdingTaxRate"]);
            ERS01057.WithholdingTaxDesc.SetValue(1, table.Rows[0]["WithholdingTaxDesc"]);
            ERS01057.MarketValueType.SetValue(1, table.Rows[0]["MarketValueType"]);
            ERS01057.ComplexHolderCode.SetValue(1, table.Rows[0]["ComplexHolderCode"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01058 I continue with the following details:")]
        public void ERS01058ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01058");
            ERS01058.Selection.SetValue(1, table.Rows[0]["Selection"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01059 I continue with the following details:")]
        public void ERS01059ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01059");
            ERS01059.MktValPrice.SetValue(1, table.Rows[0]["MktValPrice"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01054 I continue with the following details:")]
        public void ERS01054ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01054");
            ERS01054.EventType.SetValue(1, table.Rows[0]["EventType"]);
            ERS01054.EventCode.SetValue(1, table.Rows[0]["EventCode"]);
            ERS01054.EventDate.SetValue(1, table.Rows[0]["EventDate"]);
            ERS01054.EventTotals.SetValue(1, table.Rows[0]["EventTotals"]);
            ERS01054.RegisterTotals.SetValue(1, table.Rows[0]["RegisterTotals"]);
            ERS01054.RegisterTypeTotals.SetValue(1, table.Rows[0]["RegisterTypeTotals"]);
            ERS01054.CertificateBalances.SetValue(1, table.Rows[0]["CertificateBalances"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01055 I continue with the following details:")]
        public void ERS01055ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01055");
            ERS01055.EventType.SetValue(1, table.Rows[0]["EventType"]);
            ERS01055.EventCode.SetValue(1, table.Rows[0]["EventCode1"]);
            ERS01055.EventCode.SetValue(2, table.Rows[0]["EventCode2"]);
            ERS01055.ReportDateFrom.SetValue(1, table.Rows[0]["ReportDateFrom"]);
            ERS01055.ReportDateTO.SetValue(1, table.Rows[0]["ReportDateTO"]);
            ERS01055.ModelPrice.SetValue(1, table.Rows[0]["ModelPrice"]);
            ERS01055.TotalsOnly.SetValue(1, table.Rows[0]["TotalsOnly"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01030 I continue with the following details:")]
        public void ERS01030ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01030");
            ERS01030.FinalSecurity.SetValue(1, table.Rows[0]["FinalSecurity"]);
            ERS01030.VwapDateFrom.SetValue(1, table.Rows[0]["VwapDateFrom"]);
            ERS01030.VwapDateTO.SetValue(1, table.Rows[0]["VwapDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01031 I continue with the following details:")]
        public void ERS01031ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01031");

            if (ERS01031.ClntCode.Exists() == true)
            {
                ERS01031.ClntCode.SetValue(1, table.Rows[0]["ClntCode1"]);
                ERS01031.ClntCode.SetValue(2, table.Rows[0]["ClntCode2"]);
                ERS01031.CoyCode.SetValue(1, table.Rows[0]["CoyCode1"]);
                ERS01031.CoyCode.SetValue(2, table.Rows[0]["CoyCode2"]);
            }
                ERS01031.SelCls.SetValue(1, table.Rows[0]["ClsCode1"]);
                ERS01031.SelCls.SetValue(2, table.Rows[0]["ClsCode2"]);
                ERS01031.SelGrp.SetValue(1, table.Rows[0]["ClsGrp1"]);
                ERS01031.SelGrp.SetValue(2, table.Rows[0]["ClsGrp2"]);
                ERS01031.Reg.SetValue(1, table.Rows[0]["RegCode1"]);
                ERS01031.Reg.SetValue(2, table.Rows[0]["RegCode2"]);


            ERS01031.RegType.SetValue(1, table.Rows[0]["RegType1"]);
            ERS01031.RegType.SetValue(2, table.Rows[0]["RegType2"]);
            ERS01031.SelectedPlanType.SetValue(1, table.Rows[0]["SelectedPlanType"]);
            ERS01031.SelectedTaxType.SetValue(1, table.Rows[0]["SelectedTaxType"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01036 I continue with the following details:")]
        public void ERS01036ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01036");
            ERS01036.CurrUnitBal.SetValue(1, table.Rows[0]["CurrUnitBal"]);
            ERS01036.NbrCurrCerts.SetValue(1, table.Rows[0]["NbrCurrCerts"]);
            ERS01036.NbrNilCerts.SetValue(1, table.Rows[0]["NbrNilCerts"]);
            ERS01036.HolderID.SetValue(1, table.Rows[0]["HolderID"]);
            ERS01036.HolderName.SetValue(1, table.Rows[0]["HolderName"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01032 I continue with the following details:")]
        public void ERS01032ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01032");
            ERS01032.PlanCode.SetValue(1, table.Rows[0]["PlanCode"]);
            ERS01032.PlanDesc.SetValue(1, table.Rows[0]["PlanDesc"]);
            ERS01032.PlanTypeInd.SetValue(1, table.Rows[0]["PlanTypeInd"]);
            ERS01032.Div13aInd.SetValue(1, table.Rows[0]["Div13aInd"]);
            ERS01032.FinalSecurity.SetValue(1, table.Rows[0]["FinalSecurity"]);
            ERS01032.CntryOFTax.SetValue(1, table.Rows[0]["CntryOFTax"]);
            ERS01032.NorTrustInd.SetValue(1, table.Rows[0]["NorTrustInd"]);
            ERS01032.MarketValueInd.SetValue(1, table.Rows[0]["MarketValueInd"]);
            ERS01032.UnawAcct.SetValue(1, table.Rows[0]["UnawAcct"]);
            ERS01032.PaymtOptionInd.SetValue(1, table.Rows[0]["PaymtOptionInd"]);
            ERS01032.PaymtCreatnInd.SetValue(1, table.Rows[0]["PaymtCreatnInd"]);
            ERS01032.BlkoutPeriodInd.SetValue(1, table.Rows[0]["BlkoutPeriodInd"]);
            ERS01032.BlkoutCode.SetValue(1, table.Rows[0]["BlkoutCode"]);
            ERS01032.LeaverPackInd.SetValue(1, table.Rows[0]["LeaverPackInd"]);
            ERS01032.ThirdPrtyPayee.SetValue(1, table.Rows[0]["ThirdPrtyPayee"]);
            ERS01032.CoyPayee.SetValue(1, table.Rows[0]["CoyPayee"]);
            ERS01032.Comments.SetValue(1, table.Rows[0]["Comments"]);
            ERS01032.TaxTypeInd.SetValue(1, table.Rows[0]["TaxTypeInd"]);
            ERS01032.UsePoolInd.SetValue(1, table.Rows[0]["UsePoolInd"]);
            ERS01032.ForfType.SetValue(1, table.Rows[0]["ForfType"]);
            ERS01032.AutoForfInd.SetValue(1, table.Rows[0]["AutoForfInd"]);
            ERS01032.AutoRemvlBulkCode.SetValue(1, table.Rows[0]["AutoRemvlBulkCode"]);
            ERS01032.AutoRemvlFromInd.SetValue(1, table.Rows[0]["AutoRemvlFromInd"]);
            ERS01032.MatchWorkgCls.SetValue(1, table.Rows[0]["MatchWorkgCls"]);
            ERS01032.PlanMtchgLimit.SetValue(1, table.Rows[0]["PlanMtchgLimit"]);
            ERS01032.PlanMtchgLimitPerd.SetValue(1, table.Rows[0]["PlanMtchgLimitPerd"]);
            ERS01032.AutoPhntmTransfr.SetValue(1, table.Rows[0]["AutoPhntmTransfr"]);
            ERS01032.RetirementAge.SetValue(1, table.Rows[0]["RetirementAge"]);
            ERS01032.FromOptionClass.SetValue(1, table.Rows[0]["FromOptionClass"]);
            ERS01032.VsaXfrJurisdictCode.SetValue(1, table.Rows[0]["VsaXfrJurisdictCode"]);
            ERS01032.SingleCertNbr.SetValue(1, table.Rows[0]["SingleCertNbr"]);
            ERS01032.DivReinvestInd.SetValue(1, table.Rows[0]["DivReinvestInd"]);
            ERS01032.DivPlanCat.SetValue(1, table.Rows[0]["DivPlanCat"]);
            ERS01032.DivPlanConcept.SetValue(1, table.Rows[0]["DivPlanConcept"]);
            ERS01032.LapseDays.SetValue(1, table.Rows[0]["LapseDays"]);
            ERS01032.NilCostOptionInd.SetValue(1, table.Rows[0]["NilCostOptionInd"]);
            ERS01032.PhantomOptionInd.SetValue(1, table.Rows[0]["PhantomOptionInd"]);
            ERS01032.ExpiryNoticeINUrr.SetValue(1, table.Rows[0]["ExpiryNoticeINUrr"]);
            ERS01032.NbrDaysBefExpiry.SetValue(1, table.Rows[0]["NbrDaysBefExpiry"]);
            ERS01032.VestingNoticeINUrr.SetValue(1, table.Rows[0]["VestingNoticeINUrr"]);
            ERS01032.NbrDaysBeforeVest.SetValue(1, table.Rows[0]["NbrDaysBeforeVest"]);
            ERS01032.ONMktPurchaseInd.SetValue(1, table.Rows[0]["ONMktPurchaseInd"]);
            ERS01032.VsaXfrAllowed.SetValue(1, table.Rows[0]["VsaXfrAllowed"]);
            ERS01032.VsaJurisdictionCodes.SetValue(1, table.Rows[0]["VsaJurisdictionCodes"]);
            ERS01032.VsaClassCodes.SetValue(1, table.Rows[0]["VsaClassCodes"]);
            ERS01032.LoanLapseExcepts.SetValue(1, table.Rows[0]["LoanLapseExcepts"]);
            ERS01032.LoanLimitMax.SetValue(1, table.Rows[0]["LoanLimitMax"]);
            ERS01032.LoanLimitTypeInd.SetValue(1, table.Rows[0]["LoanLimitTypeInd"]);
            ERS01032.LoanPaymntTypes.SetValue(1, table.Rows[0]["LoanPaymntTypes"]);
            ERS01032.LoanDivOption.SetValue(1, table.Rows[0]["LoanDivOption"]);
            ERS01032.AllowWebTrfInd.SetValue(1, table.Rows[0]["AllowWebTrfInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01033 I continue with the following details:")]
        public void ERS01033ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01033");
            ERS01033.RegisterCode.SetValue(1, table.Rows[0]["RegisterCode"]);
            ERS01033.RegisterType.SetValue(1, table.Rows[0]["RegisterType"]);
            ERS01033.RegisterDesc.SetValue(1, table.Rows[0]["RegisterDesc"]);
            ERS01033.Comments.SetValue(1, table.Rows[0]["Comments1"]);
            ERS01033.HoldingEndDate.SetValue(1, table.Rows[0]["HoldingEndDate"]);
            ERS01033.TaxEndDate.SetValue(1, table.Rows[0]["TaxEndDate"]);
            ERS01033.FirstAwardDate.SetValue(1, table.Rows[0]["FirstAwardDate"]);
            ERS01033.IndividualDatesInd.SetValue(1, table.Rows[0]["IndividualDatesInd"]);
            ERS01033.UnitRoundingInd.SetValue(1, table.Rows[0]["UnitRoundingInd"]);
            ERS01033.ReleaseTypes.SetValue(1, table.Rows[0]["ReleaseTypes"]);
            ERS01033.AutoRemoveDays.SetValue(1, table.Rows[0]["AutoRemoveDays"]);
            ERS01033.AessLimitType.SetValue(1, table.Rows[0]["AessLimitType"]);
            ERS01033.LimitMinimum.SetValue(1, table.Rows[0]["LimitMinimum"]);
            ERS01033.LimitMaximum.SetValue(1, table.Rows[0]["LimitMaximum"]);
            ERS01033.PaymentsCarrierInd.SetValue(1, table.Rows[0]["PaymentsCarrierInd"]);
            ERS01033.MoneyRoundingInd.SetValue(1, table.Rows[0]["MoneyRoundingInd"]);
            ERS01033.ResidualsInd.SetValue(1, table.Rows[0]["ResidualsInd"]);
            ERS01033.MaximumNbrRestarts.SetValue(1, table.Rows[0]["MaximumNbrRestarts"]);
            ERS01033.PaymentAcct.SetValue(1, table.Rows[0]["PaymentAcct"]);
            ERS01033.BaseCurrency.SetValue(1, table.Rows[0]["BaseCurrency"]);
            ERS01033.AwardPayFreqDtls.SetValue(1, table.Rows[0]["AwardPayFreqDtls"]);
            ERS01033.CalcTaxInd.SetValue(1, table.Rows[0]["CalcTaxInd"]);
            ERS01033.ForfeitureType.SetValue(1, table.Rows[0]["ForfeitureType"]);
            ERS01033.ProRataMethod.SetValue(1, table.Rows[0]["ProRataMethod"]);
            ERS01033.ForfeitureEndDate.SetValue(1, table.Rows[0]["ForfeitureEndDate"]);
            ERS01033.NonForfeitureStatus.SetValue(1, table.Rows[0]["NonForfeitureStatus"]);
            ERS01033.UsingMtchgInd.SetValue(1, table.Rows[0]["UsingMtchgInd"]);
            ERS01033.UsingUnmatchedInd.SetValue(1, table.Rows[0]["UsingUnmatchedInd"]);
            ERS01033.MtchgUpfrontInd.SetValue(1, table.Rows[0]["MtchgUpfrontInd"]);
            ERS01033.FutrMtchgEndDate.SetValue(1, table.Rows[0]["FutrMtchgEndDate"]);
            ERS01033.MtchgRatio.SetValue(1, table.Rows[0]["MtchgRatio"]);
            ERS01033.AwdMtchgLimitPerd.SetValue(1, table.Rows[0]["AwdMtchgLimitPerd"]);
            ERS01033.AwdMtchgLimit.SetValue(1, table.Rows[0]["AwdMtchgLimit"]);
            ERS01033.LoanBonusPerdDtls.SetValue(1, table.Rows[0]["LoanBonusPerdDtls"]);
            ERS01033.RecoursePlanInd.SetValue(1, table.Rows[0]["RecoursePlanInd"]);
            ERS01033.FutureFloat.SetValue(1, table.Rows[0]["FutureFloat"]);
            ERS01033.ForfeitureFloat.SetValue(1, table.Rows[0]["ForfeitureFloat"]);
            ERS01033.LeaverSchedule.SetValue(1, table.Rows[0]["LeaverSchedule"]);
            ERS01033.UsingVestingInd.SetValue(1, table.Rows[0]["UsingVestingInd"]);
            ERS01033.TaxStmtTypeInd.SetValue(1, table.Rows[0]["TaxStmtTypeInd"]);
            ERS01033.TaxReportableInd.SetValue(1, table.Rows[0]["TaxReportableInd"]);
            ERS01033.FinRptExp.SetValue(1, table.Rows[0]["FinRptExp"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01034 I continue with the following details:")]
        public void ERS01034ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01034");
            ERS01034.AwardDate.SetValue(1, table.Rows[0]["AwardDate"]);
            ERS01034.AcqstnSharePrice.SetValue(1, table.Rows[0]["AcqstnSharePrice"]);
            ERS01034.AwardExchgRate.SetValue(1, table.Rows[0]["AwardExchgRate"]);
            ERS01034.IfrsFmv.SetValue(1, table.Rows[0]["IfrsFmv"]);
            ERS01034.ExpiryDate.SetValue(1, table.Rows[0]["ExpiryDate"]);
            ERS01034.VestingCode.SetValue(1, table.Rows[0]["VestingCode"]);
            ERS01034.VestingStartDate.SetValue(1, table.Rows[0]["VestingStartDate"]);
            ERS01034.PerformanceHurdles.SetValue(1, table.Rows[0]["PerformanceHurdles"]);
            ERS01034.PerformanceCode.SetValue(1, table.Rows[0]["PerformanceCode"]);
            ERS01034.CtlPayFreqDtls.SetValue(1, table.Rows[0]["CtlPayFreqDtls"]);
            ERS01034.HlthIntgrtyModeInd.SetValue(1, table.Rows[0]["HlthIntgrtyModeInd"]);
            ERS01034.EnabledStatusInd.SetValue(1, table.Rows[0]["EnabledStatusInd"]);
            ERS01034.PriceUpdatedInd.SetValue(1, table.Rows[0]["PriceUpdatedInd"]);
            ERS01034.Comments.SetValue(1, table.Rows[0]["Comments2"]);
            ERS01034.DisplayONWeb.SetValue(1, table.Rows[0]["DisplayONWeb"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01035 I continue with the following details:")]
        public void ERS01035ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01035");
            ERS01035.AccumnPeriod.SetValue(1, table.Rows[0]["AccumnPeriod"]);
            ERS01035.AccumnStaDate.SetValue(1, table.Rows[0]["AccumnStaDate"]);
            ERS01035.AccumnEndDate.SetValue(1, table.Rows[0]["AccumnEndDate"]);
            ERS01035.MaxNbrPaymnts.SetValue(1, table.Rows[0]["MaxNbrPaymnts"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01037 I continue with the following details:")]
        public void ERS01037ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01037");
            ERS01037.TrancheNbr.SetValue(1, table.Rows[0]["TrancheNbr"]);
            ERS01037.TestNbr.SetValue(1, table.Rows[0]["TestNbr"]);
            ERS01037.VstDesc.SetValue(1, table.Rows[0]["VstDesc"]);
            ERS01037.VstTerm.SetValue(1, table.Rows[0]["VstTerm"]);
            ERS01037.UnitRnd.SetValue(1, table.Rows[0]["UnitRnd"]);
            ERS01037.VstComments.SetValue(1, table.Rows[0]["VstComments"]);
            ERS01037.PeriodFRVstStart.SetValue(1, table.Rows[0]["PeriodFRVstStart"]);
            ERS01037.VestPerc.SetValue(1, table.Rows[0]["VestPerc"]);
            ERS01037.VestDate.SetValue(1, table.Rows[0]["VestDate"]);
            ERS01037.PerformanceDesc.SetValue(1, table.Rows[0]["PerformanceDesc"]);
            ERS01037.TestDate.SetValue(1, table.Rows[0]["TestDate"]);
            ERS01037.TestPerc.SetValue(1, table.Rows[0]["TestPerc"]);
            ERS01037.CancUnvest.SetValue(1, table.Rows[0]["CancUnvest"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01038 I continue with the following details:")]
        public void ERS01038ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01038");
            ERS01038.LeaverSchedDesc.SetValue(1, table.Rows[0]["LeaverSchedDesc"]);
            ERS01038.LeaverCode.SetValue(1, table.Rows[0]["LeaverCode"]);
            ERS01038.LeaverCodeDesc.SetValue(1, table.Rows[0]["LeaverCodeDesc"]);
            ERS01038.EmployeeStatus.SetValue(1, table.Rows[0]["EmployeeStatus"]);
            ERS01038.EmployeeStatusDesc.SetValue(1, table.Rows[0]["EmployeeStatusDesc"]);
            ERS01038.MaintainRestrctInd.SetValue(1, table.Rows[0]["MaintainRestrctInd"]);
            ERS01038.PhantomLvrTypeInd.SetValue(1, table.Rows[0]["PhantomLvrTypeInd"]);
            ERS01038.OverrideExpiry.SetValue(1, table.Rows[0]["OverrideExpiry"]);
            ERS01038.OverridePeriod.SetValue(1, table.Rows[0]["OverridePeriod"]);
            ERS01038.OverrideFromDate.SetValue(1, table.Rows[0]["OverrideFromDate"]);
            ERS01038.UnvNOChgInd.SetValue(1, table.Rows[0]["UnvNOChgInd"]);
            ERS01038.UnvCancelImm.SetValue(1, table.Rows[0]["UnvCancelImm"]);
            ERS01038.UnvAccelVst.SetValue(1, table.Rows[0]["UnvAccelVst"]);
            ERS01038.UnvAccelPeriod.SetValue(1, table.Rows[0]["UnvAccelPeriod"]);
            ERS01038.UnvAccelFrmDate.SetValue(1, table.Rows[0]["UnvAccelFrmDate"]);
            ERS01038.VstNOChgInd.SetValue(1, table.Rows[0]["VstNOChgInd"]);
            ERS01038.VstCancelImm.SetValue(1, table.Rows[0]["VstCancelImm"]);
            ERS01038.VstIgnoreBlackout.SetValue(1, table.Rows[0]["VstIgnoreBlackout"]);
            ERS01038.Comments.SetValue(1, table.Rows[0]["Comments3"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01010 I continue with the following values:")]
        public void ERS01010ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01010");
            ERS01010.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            ERS01010.HolderCat.SetValue(1, table.Rows[0]["HolderCat"]);
            ERS01010.HolderNumber.SetValue(1, table.Rows[0]["HolderNumber"]);
            ERS01010.RegAddress.SetValue(1, table.Rows[0]["RegAddress"]);
            if (table.Rows[0]["RegAddress"] == "Y")
            {
                ERS01010.RegAddress.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01010.RegAddrCase.SetValue(1, table.Rows[0]["RegAddrCase"]);
            }

            ERS01010.HolderName.SetValue(1, table.Rows[0]["HolderName"]);
            if (table.Rows[0]["HolderName"] == "Y")
            {
                ERS01010.HolderName.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01010.Fullnames.SetValue(1, table.Rows[0]["Fullnames"]);
                if (table.Rows[0]["Fullnames"] == "Y")
                {
                    ERS01010.Fullnames.ClickField();
                    WinFormsTestSteps.PressTAB();
                    ERS01010.CaseFull.SetValue(1, table.Rows[0]["CaseFull"]);
                }
                ERS01010.NameDetailed.SetValue(1, table.Rows[0]["NameDetailed"]);
                if (table.Rows[0]["NameDetailed"] == "Y")
                {
                    ERS01010.NameDetailed.ClickField();
                    WinFormsTestSteps.PressTAB();
                    ERS01010.CaseDetailed.SetValue(1, table.Rows[0]["CaseDetailed"]);
                    ERS01010.Surname.SetValue(1, table.Rows[0]["Surname"]);
                    ERS01010.FirstName.SetValue(1, table.Rows[0]["FirstName"]);
                    ERS01010.SecondName.SetValue(1, table.Rows[0]["SecondName"]);
                    ERS01010.ThirdName.SetValue(1, table.Rows[0]["ThirdName"]);
                    ERS01010.Title.SetValue(1, table.Rows[0]["Title"]);
                    ERS01010.Initials.SetValue(1, table.Rows[0]["Initials"]);
                }
                ERS01010.Designator.SetValue(1, table.Rows[0]["Designator"]);
                ERS01010.NameKey.SetValue(1, table.Rows[0]["NameKey"]);
                ERS01010.NameType.SetValue(1, table.Rows[0]["NameType"]);
            }
            ERS01010.HolderAddress.SetValue(1, table.Rows[0]["HolderAddress"]);
            if (table.Rows[0]["HolderAddress"] == "Y")
            {
                ERS01010.HolderAddress.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01010.HolderAddressCase.SetValue(1, table.Rows[0]["HolderAddressCase"]);
                ERS01010.IncludePcode.SetValue(1, table.Rows[0]["IncludePcode"]);
            }
            ERS01010.PcodeDomicile.SetValue(1, table.Rows[0]["PcodeDomicile"]);
            ERS01010.Dpid.SetValue(1, table.Rows[0]["Dpid"]);
            ERS01010.Barcode.SetValue(1, table.Rows[0]["Barcode"]);
            ERS01010.AlternateID.SetValue(1, table.Rows[0]["AlternateID"]);
            ERS01010.Ers01010PersonalUrl.SetValue(1, table.Rows[0]["Ers01010PersonalUrl"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01012 I continue with the following Values:")]
        public void ERS01012ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01012");
            ERS01012.ExtraIdentifier.SetValue(1, table.Rows[0]["ExtraIdentifier"]);
            ERS01012.HomePhone.SetValue(1, table.Rows[0]["HomePhone"]);
            ERS01012.WorkPhone.SetValue(1, table.Rows[0]["WorkPhone"]);
            ERS01012.FaxNumber.SetValue(1, table.Rows[0]["FaxNumber"]);
            ERS01012.MobilePhone.SetValue(1, table.Rows[0]["MobilePhone"]);
            ERS01012.EmailAddress.SetValue(1, table.Rows[0]["EmailAddress"]);
            ERS01012.ReturnedEmail.SetValue(1, table.Rows[0]["ReturnedEmail"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01028 I continue with the following Values:")]
        public void ERS01028ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01028");
            ERS01028.HolderStatus.SetValue(1, table.Rows[0]["HolderStatus"]);
            if (table.Rows[0]["HolderStatus"] == "Y")
            {
                ERS01028.HolderStatus.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01028.DeceasedFlag.SetValue(1, table.Rows[0]["DeceasedFlag"]);
                ERS01028.ExceptionFlag.SetValue(1, table.Rows[0]["ExceptionFlag"]);
                ERS01028.StopTradeFlag.SetValue(1, table.Rows[0]["StopTradeFlag"]);
                ERS01028.DivIntentionFlag.SetValue(1, table.Rows[0]["DivIntentionFlag"]);
            }
            ERS01028.VariableFlags.SetValue(1, table.Rows[0]["VariableFlags"]);
            ERS01028.VariableField.SetValue(1, table.Rows[0]["VariableField"]);
            ERS01028.TfnDescription.SetValue(1, table.Rows[0]["TfnDescription"]);
            ERS01028.Dates.SetValue(1, table.Rows[0]["Dates"]);
            if (table.Rows[0]["Dates"] == "Y")
            {
                ERS01028.Dates.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01028.MailUnclaimedDate.SetValue(1, table.Rows[0]["MailUnclaimedDate"]);
                ERS01028.HolderONDate.SetValue(1, table.Rows[0]["HolderONDate"]);
                ERS01028.HolderOffDate.SetValue(1, table.Rows[0]["HolderOffDate"]);
                ERS01028.HolderAddedDate.SetValue(1, table.Rows[0]["HolderAddedDate"]);
            }
            ERS01028.PlanDetails.SetValue(1, table.Rows[0]["PlanDetails"]);
            if (table.Rows[0]["PlanDetails"] == "Y")
            {
                ERS01028.PlanDetails.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01028.DrpDetails.SetValue(1, table.Rows[0]["DrpDetails"]);
                ERS01028.BspDetails.SetValue(1, table.Rows[0]["BspDetails"]);
            }
            ERS01028.DirectCredit.SetValue(1, table.Rows[0]["DirectCredit"]);
            if (table.Rows[0]["DirectCredit"] == "Y")
            {
                ERS01028.DirectCredit.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01028.BankID.SetValue(1, table.Rows[0]["BankID"]);
                ERS01028.BankNamadd.SetValue(1, table.Rows[0]["BankNamadd"]);
                ERS01028.BankAccountNbr.SetValue(1, table.Rows[0]["BankAccountNbr"]);
                ERS01028.BankAccountName.SetValue(1, table.Rows[0]["BankAccountName"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01020 I continue with the following details:")]
        public void ERS01020ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01020");
            ERS01020.SELCLS.SetValue(1, table.Rows[0]["Class1"]);
            ERS01020.SELCLS.SetValue(2, table.Rows[0]["Class2"]);
            ERS01020.Selgrp.SetValue(1, table.Rows[0]["Selgrp1"]);
            ERS01020.Selgrp.SetValue(2, table.Rows[0]["Selgrp2"]);
            ERS01020.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            ERS01020.StatementRunFrom.SetValue(1, table.Rows[0]["StatementRunFrom"]);
            ERS01020.MarketValuePrice.SetValue(1, table.Rows[0]["MarketValuePrice"]);
            ERS01020.MarketValueDate.SetValue(1, table.Rows[0]["MarketValueDate"]);
            ERS01020.ForeignExchangeRate.SetValue(1, table.Rows[0]["ForeignExchangeRate"]);
            ERS01020.StmtDsplayDateFrom.SetValue(1, table.Rows[0]["StmtDsplayDateFrom"]);
            ERS01020.StmtDsplayDateTO.SetValue(1, table.Rows[0]["StmtDsplayDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01021 I continue with the following details:")]
        public void ERS01021ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01021");
            ERS01021.SELCLS.SetValue(1, table.Rows[0]["Class1"]);
            ERS01021.SELCLS.SetValue(2, table.Rows[0]["Class2"]);
            ERS01021.Selgrp.SetValue(1, table.Rows[0]["Selgrp1"]);
            ERS01021.Selgrp.SetValue(2, table.Rows[0]["Selgrp2"]);
            ERS01021.Reg.SetValue(1, table.Rows[0]["Reg1"]);
            ERS01021.Reg.SetValue(2, table.Rows[0]["Reg2"]);

            ERS01021.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            ERS01021.StatementRunFrom.SetValue(1, table.Rows[0]["StatementRunFrom"]);
            ERS01021.BFBalanceInd.SetValue(1, table.Rows[0]["BFBalanceInd"]);
            ERS01021.StatementDisplayInd.SetValue(1, table.Rows[0]["StatementDisplayInd"]);
            ERS01021.Ers01021PymtTranInd.SetValue(1, table.Rows[0]["Ers01021PymtTranInd"]);
            ERS01021.MarketValuePrice.SetValue(1, table.Rows[0]["MarketValuePrice"]);
            ERS01021.MarketValueDate.SetValue(1, table.Rows[0]["MarketValueDate"]);
            ERS01021.ForeignExchangeRate.SetValue(1, table.Rows[0]["ForeignExchangeRate"]);
            ERS01021.StmtDsplayDateFrom.SetValue(1, table.Rows[0]["StmtDsplayDateFrom"]);
            ERS01021.StmtDsplayDateTO.SetValue(1, table.Rows[0]["StmtDsplayDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01043 I continue with the following details:")]
        public void ERS01043ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01043");
            if (ERS01043.SelCls.Exists() == true)
            {
                ERS01043.SelCls.SetValue(1, table.Rows[0]["Class1"]);
                ERS01043.SelCls.SetValue(2, table.Rows[0]["Class2"]);
            }
            else
            {
                ERS01043.Class.SetValue(1, table.Rows[0]["Class1"]);
                ERS01043.Class.SetValue(2, table.Rows[0]["Class2"]);
            }

            ERS01043.Selgrp.SetValue(1, table.Rows[0]["Selgrp1"]);
            ERS01043.Selgrp.SetValue(2, table.Rows[0]["Selgrp2"]);
            ERS01043.Reg.SetValue(1, table.Rows[0]["Reg1"]);
            ERS01043.Reg.SetValue(2, table.Rows[0]["Reg2"]);

            ERS01043.StatementType.SetValue(1, table.Rows[0]["StatementType"]);
            ERS01043.StatementType.ClickField();
            WinFormsTestSteps.PressTAB();
            if (table.Rows[0]["StatementType"] == "G" || table.Rows[0]["StatementType"] == "H")
            {
                ERS01043.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
                ERS01043.StatementRunFrom.SetValue(1, table.Rows[0]["StatementRunFrom"]);
                if (table.Rows[0]["StatementType"] == "G")
                {
                    ERS01043.NilHoldingsInd.SetValue(1, table.Rows[0]["NilHoldingsInd"]);
                }
            }
            else if (table.Rows[0]["StatementType"] == "V" || table.Rows[0]["StatementType"] == "E")
            {
                ERS01043.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
                ERS01043.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            }

            ERS01043.MarketValuePrice.SetValue(1, table.Rows[0]["MarketValuePrice"]);
            ERS01043.MarketValueDate.SetValue(1, table.Rows[0]["MarketValueDate"]);
            ERS01043.StmtDsplayDateFrom.SetValue(1, table.Rows[0]["StmtDsplayDateFrom"]);
            ERS01043.StmtDsplayDateTO.SetValue(1, table.Rows[0]["StmtDsplayDateTO"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01044 I continue with the following details:")]
        public void ERS01044ContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "ERS01044" || FormName == "ERS01045")
            {
                ERS01044.Confirm.SetValue(1, table.Rows[0]["Confirm"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01062 I continue with the following details:")]
        public void ERS01062ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01062");
            ERS01062.Class1.SetValue(1, table.Rows[0]["Class1"]);
            ERS01062.PayAcct.SetValue(1, table.Rows[0]["PayAcct1"]);
            ERS01062.PayAcct.SetValue(2, table.Rows[0]["PayAcct2"]);
            ERS01062.ClassPerCatInd1.SetValue(1, table.Rows[0]["ClassPerCatInd11"]);
            ERS01062.ClassPerCatInd1.SetValue(1, table.Rows[0]["ClassPerCatInd12"]);
            ERS01062.UseHistClassesInd.SetValue(1, table.Rows[0]["UseHistClassesInd"]);
            if (table.Rows[0]["UseHistClassesInd"] == "Y")
            {
                ERS01062.UseHistClassesInd.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01062.HistClass.SetValue(1, table.Rows[0]["HistClass1"]);
                ERS01062.HistClass.SetValue(1, table.Rows[0]["HistClass2"]);
            }

            ERS01062.RunRangeTO.SetValue(1, table.Rows[0]["RunRangeTO"]);
            ERS01062.StatementRunFrom.SetValue(1, table.Rows[0]["StatementRunFrom"]);
            ERS01062.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            ERS01062.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            ERS01062.LoanDiscountPrice.SetValue(1, table.Rows[0]["LoanDiscountPrice"]);
            ERS01062.GenerateCsvInd.SetValue(1, table.Rows[0]["GenerateCsvInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01022 I continue with the following details:")]
        public void ERS01022ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01022");
            ERS01022.Class1.SetValue(1, table.Rows[0]["Class1"]);
            ERS01022.PayAcct.SetValue(1, table.Rows[0]["PayAcct1"]);
            ERS01022.PayAcct.SetValue(2, table.Rows[0]["PayAcct2"]);
            ERS01022.ClassPerCatInd.SetValue(1, table.Rows[0]["ClassPerCatInd1"]);
            ERS01022.ClassPerCatInd.SetValue(2, table.Rows[0]["ClassPerCatInd2"]);
            ERS01022.UseHistClassesInd.SetValue(1, table.Rows[0]["UseHistClassesInd"]);
            if (table.Rows[0]["UseHistClassesInd"] == "Y")
            {
                ERS01022.UseHistClassesInd.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01022.HistClass.SetValue(1, table.Rows[0]["HistClass1"]);
                ERS01022.HistClass.SetValue(2, table.Rows[0]["HistClass2"]);
            }

            ERS01022.ReportCgtInd.SetValue(1, table.Rows[0]["ReportCgtInd"]);
            ERS01022.TransDateFrom.SetValue(1, table.Rows[0]["TransDateFrom"]);
            ERS01022.TransDateTO.SetValue(1, table.Rows[0]["TransDateTO"]);
            ERS01022.LoanDiscountPrice.SetValue(1, table.Rows[0]["LoanDiscountPrice"]);
            ERS01022.AmendmentInd.SetValue(1, table.Rows[0]["AmendmentInd"]);
            if (table.Rows[0]["AmendmentInd"] == "A")
            {
                ERS01022.AmendmentInd.ClickField();
                WinFormsTestSteps.PressTAB();
                ERS01022.Ers01022AmendTfnReqInd.SetValue(1, table.Rows[0]["Ers01022AmendTfnReqInd"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01064 I continue with the following details:")]
        public void ERS01064ContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "ERS01064")
            {
                ERS01064.Confirm.SetValue(1, table.Rows[0]["Confirm"]);
                WinFormsTestSteps.Transmit();
            }
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01050 I continue with the following details:")]
        public void ERS01050ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01050");
            ERS01050.CoyCode15.SetValue(1, table.Rows[0]["CoyCode151"]);
            ERS01050.CoyCode15.SetValue(2, table.Rows[0]["CoyCode152"]);
            ERS01050.CoyCode15.SetValue(3, table.Rows[0]["CoyCode153"]);
            ERS01050.FinYear.SetValue(1, table.Rows[0]["FinYear"]);
            ERS01050.TaxStatus.SetValue(1, table.Rows[0]["TaxStatus1"]);
            ERS01050.TaxStatus.SetValue(2, table.Rows[0]["TaxStatus2"]);
            ERS01050.TaxStatus.SetValue(3, table.Rows[0]["TaxStatus3"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01051 I continue with the following details:")]
        public void ERS01051ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01051");
            ERS01051.CoyCode15.SetValue(1, table.Rows[0]["CoyCode151"]);
            ERS01051.CoyCode15.SetValue(2, table.Rows[0]["CoyCode152"]);
            ERS01051.CoyCode15.SetValue(3, table.Rows[0]["CoyCode153"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In ERS01052 I continue with the following details:")]
        public void ERS01052ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ERS01052");
            ERS01052.Class.SetValue(1, table.Rows[0]["Class"]);
            ERS01052.FinancialYear.SetValue(1, table.Rows[0]["FinancialYear"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="table">data table</param>
        [Given(@"In RSS01070 I continue with the following details:")]
        [When(@"In RSS01070 I continue with the following details:")]
        public void GivenInRSS01070ContinueWithTheFollowingDetails(Table table)
        {
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "RSS01045")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS01070");
            if (table.Rows[0]["PriceMethod"] == "R")
            {
                RSS01070.PriceMethod.SetValue(1, table.Rows[0]["PriceMethod"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else
            {
                if (table.Rows[0].ContainsKey("ClassPriceA") == true)
                    if (table.Rows[0]["ClassPriceA"] != "")
                        RSS01070.ClassPriceA.SetValue(1, table.Rows[0]["ClassPriceA"]);
                if (table.Rows[0].ContainsKey("ClassPriceB") == true)
                    if (table.Rows[0]["ClassPriceB"] != "")
                        RSS01070.ClassPriceA.SetValue(2, table.Rows[0]["ClassPriceB"]);
                if (table.Rows[0].ContainsKey("ClassPriceC") == true)
                    if (table.Rows[0]["ClassPriceC"] != "")
                        RSS01070.ClassPriceA.SetValue(3, table.Rows[0]["ClassPriceC"]);
                if (table.Rows[0].ContainsKey("ClassPriceD") == true)
                    if (table.Rows[0]["ClassPriceD"] != "")
                        RSS01070.ClassPriceA.SetValue(4, table.Rows[0]["ClassPriceD"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }
    


        /// <param name="table">data table</param>
        [When(@"In JOBSUB90 I submit the Proxy report")]
        public void JOBSUB90SubmitTheProxyReport(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(5000);
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB90");
            ReportDesc = JOBSUB90.Desc.GetValue();
            ReportJobNumber = JOBSUB90.JobNODec.GetValue();
            ReportPRNName = JOBSUB90.ParameterID.GetValue();
            ReportPrintFileName = JOBSUB90.PrintID.GetValue();
            currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
            GetCoyFromForm();
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            //To run PAL job, need to exit from the company. Cannot kill the winforms session as the job already running in the background.
            PXS00101.Selection.SetValue("EX");
            WinFormsTestSteps.Transmit();
            MNS00101.Selection.SetValue("EX");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.CloseWinforms();
            //WinFormsTestSteps.ExpectToBeInTheScreen("RSS00101");
            //Check the jobs are completed in VMS or Linux
            WinFormsTestSteps.WaitForJobNumber(table);
        }

        /// <param name="table">data table</param>
        [Given(@"In RSS11001 I continue with the following details:")]
        [When(@"In RSS11001 I continue with the following details:")]
        public void GivenInRSS11001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11001");
            if (table.Rows[0]["OutstandingUnpres"] == "Y")
            {
                RSS11001.OutstandingUnpres.SetValue(1, table.Rows[0]["OutstandingUnpres"]);
                RSS11001.UseInputFile.SetValue(1, table.Rows[0]["UseInputFile"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else
            {
                RSS11001.OutstandingUnpres.SetValue(1, table.Rows[0]["OutstandingUnpres"]);
            }

            if (table.Rows[0]["PayAccountNumber1"] != "")
            {
                RSS11001.PayAccountNumber1.SetValue(1, table.Rows[0]["PayAccountNumber1"]);
                RSS11001.PayAccountNumber2.SetValue(2, table.Rows[0]["PayAccountNumber2"]);
                RSS11001.PayAccountNumber3.SetValue(3, table.Rows[0]["PayAccountNumber3"]);
                RSS11001.PayAccountNumber4.SetValue(4, table.Rows[0]["PayAccountNumber4"]);
                RSS11001.PayAccountNumber5.SetValue(5, table.Rows[0]["PayAccountNumber5"]);
                RSS11001.PayAccountNumber6.SetValue(6, table.Rows[0]["PayAccountNumber6"]);
                RSS11001.PayAccountNumber7.SetValue(7, table.Rows[0]["PayAccountNumber7"]);
                RSS11001.PayAccountNumber8.SetValue(8, table.Rows[0]["PayAccountNumber8"]);
                RSS11001.PayAccountNumber9.SetValue(9, table.Rows[0]["PayAccountNumber9"]);
            }

            if (table.Rows[0]["DividendType1"] != "")
            {
                RSS11001.DividendType.SetValue(1, table.Rows[0]["DividendType1"]);
                RSS11001.DividendType.SetValue(2, table.Rows[0]["DividendType2"]);
                //RSS11001.DividendType.SetValue(3, table.Rows[0]["DividendType3"]);
                //RSS11001.DividendType.SetValue(4, table.Rows[0]["DividendType4"]);
            }

            if (table.Rows[0]["PaymentCurr1"] != "")
            {
                RSS11001.PaymentCurr.SetValue(1, table.Rows[0]["PaymentCurr1"]);
                //RSS11001.PaymentCurr.SetValue(2, table.Rows[0]["PaymentCurr2"]);
                //RSS11001.PaymentCurr.SetValue(3, table.Rows[0]["PaymentCurr3"]);
                //RSS11001.PaymentCurr.SetValue(4, table.Rows[0]["PaymentCurr4"]);
                //RSS11001.PaymentCurr.SetValue(5, table.Rows[0]["PaymentCurr5"]);
                //RSS11001.PaymentCurr.SetValue(6, table.Rows[0]["PaymentCurr6"]);
                //RSS11001.PaymentCurr.SetValue(7, table.Rows[0]["PaymentCurr7"]);
                //RSS11001.PaymentCurr.SetValue(8, table.Rows[0]["PaymentCurr8"]);
                //RSS11001.PaymentCurr.SetValue(9, table.Rows[0]["PaymentCurr9"]);
                //RSS11001.PaymentCurr.SetValue(10, table.Rows[0]["PaymentCurr10"]);
            }

            if (table.Rows[0]["PaymentAmountFrom"] != "")
            {
                RSS11001.PaymentAmountFrom.SetValue(1, table.Rows[0]["PaymentAmountFrom"]);
            }

            if (table.Rows[0]["PaymentAmountTO"] != "")
            {
                RSS11001.PaymentAmountTO.SetValue(1, table.Rows[0]["PaymentAmountTO"]);
            }

            if (table.Rows[0]["TaxSelectionYN"] != "")
            {
                RSS11001.TaxSelectionYN.SetValue(1, table.Rows[0]["TaxSelectionYN"]);
            }

            if (table.Rows[0]["UseInputFile"] != "")
            {
                RSS11001.UseInputFile.SetValue(1, table.Rows[0]["UseInputFile"]);
            }
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS11010 I continue with the following details:")]
        [Given(@"In RSS11010 I continue with the following details:")]
        public void RSS11010ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11010");

            if (table.Rows[0]["PaymentRangeInd"] != "")
            {
                RSS11010.PaymentRangeInd.SetValue(1, table.Rows[0]["PaymentRangeInd"]);
            }

            if (table.Rows[0]["PaymentStatus1"] != "")
            {
                RSS11010.PaymentStatus.SetValue(1, table.Rows[0]["PaymentStatus1"]);
                RSS11010.PaymentStatus.SetValue(2, table.Rows[0]["PaymentStatus2"]);
                //RSS11010.PaymentStatus.SetValue(3, table.Rows[0]["PaymentStatus3"]);
                //RSS11010.PaymentStatus.SetValue(4, table.Rows[0]["PaymentStatus4"]);
                //RSS11010.PaymentStatus.SetValue(5, table.Rows[0]["PaymentStatus5"]);
                //RSS11010.PaymentStatus.SetValue(6, table.Rows[0]["PaymentStatus6"]);
                //RSS11010.PaymentStatus.SetValue(7, table.Rows[0]["PaymentStatus7"]);
                //RSS11010.PaymentStatus.SetValue(8, table.Rows[0]["PaymentStatus8"]);
            }

            if (table.Rows[0]["PaymentTransTypes1"] != "")
            {
                RSS11010.PaymentTransTypes.SetValue(1, table.Rows[0]["PaymentTransTypes1"]);
                RSS11010.PaymentTransTypes.SetValue(2, table.Rows[0]["PaymentTransTypes2"]);
                RSS11010.PaymentTransTypes.SetValue(3, table.Rows[0]["PaymentTransTypes3"]);
                RSS11010.PaymentTransTypes.SetValue(4, table.Rows[0]["PaymentTransTypes4"]);
                RSS11010.PaymentTransTypes.SetValue(5, table.Rows[0]["PaymentTransTypes5"]);
                RSS11010.PaymentTransTypes.SetValue(6, table.Rows[0]["PaymentTransTypes6"]);
                RSS11010.PaymentTransTypes.SetValue(7, table.Rows[0]["PaymentTransTypes7"]);
                RSS11010.PaymentTransTypes.SetValue(8, table.Rows[0]["PaymentTransTypes8"]);
                RSS11010.PaymentTransTypes.SetValue(9, table.Rows[0]["PaymentTransTypes9"]);
                //RSS11010.PaymentTransTypes.SetValue(10, table.Rows[0]["PaymentTransTypes10"]);
            }

            if (table.Rows[0]["PaymentMethod1"] != "")
            {
                RSS11010.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod1"]);
                RSS11010.PaymentMethod.SetValue(2, table.Rows[0]["PaymentMethod2"]);
                //RSS11010.PaymentMethod.SetValue(3, table.Rows[0]["PaymentMethod3"]);
                //RSS11010.PaymentMethod.SetValue(4, table.Rows[0]["PaymentMethod4"]);
            }

            if (table.Rows[0]["PayRefNumberFrom"] != "")
            {
                RSS11010.PayRefNumberFrom.SetValue(1, table.Rows[0]["PayRefNumberFrom"]);
                RSS11010.PayRefNumberTO.SetValue(1, table.Rows[0]["PayRefNumberTO"]);
            }

            if (table.Rows[0]["TaxSelection1"] != "")
            {
                RSS11010.TaxSelection.SetValue(1, table.Rows[0]["TaxSelection1"]);
                RSS11010.TaxSelection.SetValue(2, table.Rows[0]["TaxSelection2"]);
                RSS11010.TaxSelection.SetValue(3, table.Rows[0]["TaxSelection3"]);
            }

            if (table.Rows[0]["PresentedDateFrom"] != "")
            {
                RSS11010.PresentedDateFrom.SetValue(1, table.Rows[0]["PresentedDateFrom"]);
                RSS11010.PresentedDateTO.SetValue(1, table.Rows[0]["PresentedDateTO"]);
            }

            if (table.Rows[0]["ReturnedMail"] != "")
            {
                RSS11010.ReturnedMail.SetValue(1, table.Rows[0]["ReturnedMail"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS11006 I continue with the following details:")]
        [Given(@"In RSS11006 I continue with the following details:")]
        public void RSS11006ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11006");
            RSS11006.ExtractHoldersPI.SetValue(1, table.Rows[0]["ExtractHoldersPI"]);
            RSS11006.ExtractHoldersPI.ClickField();
            WinFormsTestSteps.PressTAB();

            if (table.Rows[0]["RptDirectCreditInd"] == "S")
            {
                RSS11006.RptDirectCreditInd.SetValue(1, table.Rows[0]["RptDirectCreditInd"]);
                RSS11006.RptDirectCredit.SetValue(1, table.Rows[0]["RptDirectCredit1"]);
                RSS11006.RptDirectCredit.SetValue(2, table.Rows[0]["RptDirectCredit2"]);
                RSS11006.RptDirectCredit.SetValue(3, table.Rows[0]["RptDirectCredit3"]);
                //RSS11006.RptDirectCredit.SetValue(4, table.Rows[0]["RptDirectCredit4"]);
                //RSS11006.RptDirectCredit.SetValue(5, table.Rows[0]["RptDirectCredit5"]);
                //RSS11006.RptDirectCredit.SetValue(6, table.Rows[0]["RptDirectCredit6"]);
                //RSS11006.RptDirectCredit.SetValue(7, table.Rows[0]["RptDirectCredit7"]);
                //RSS11006.RptDirectCredit.SetValue(8, table.Rows[0]["RptDirectCredit8"]);
                //RSS11006.RptDirectCredit.SetValue(9, table.Rows[0]["RptDirectCredit9"]);
                //RSS11006.RptDirectCredit.SetValue(10, table.Rows[0]["RptDirectCredit10"]);
                WinFormsTestSteps.Transmit();
            }
            else
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        [Given(@"In RSS11002 I click on: ""(.*)"" within the Cheque Extract Output Menu")]
        [When(@"In RSS11002 I click on: ""(.*)"" within the Cheque Extract Output Menu")]
        public void ClickWithinTheChequeExtractOutputMenu(string menuOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11002");
            switch (menuOption.ToLower())
            {
                case "summary":
                    RSS11002.MenuItemSU.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    break;

                case "brief":
                    RSS11002.MenuItemBR.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    break;

                case "full":
                    RSS11002.MenuItemFU.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    break;

                case "labels":
                    RSS11002.MenuItemLB.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    break;

                case "notices":
                    RSS11002.MenuItemNT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    break;

                case "tape":
                    RSS11002.MenuItemTP.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "residenttaxlisting":
                    RSS11002.MenuItemTL.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "totalsonly":
                    RSS11002.MenuItemTO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "briefunclaimedmonies":
                    RSS11002.MenuItemBM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "nswunclaimedmonies":
                    RSS11002.MenuItemNM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "queenslandunclaimedmonies":
                    RSS11002.MenuItemQM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "victorianunclaimedmonies":
                    RSS11002.MenuItemVM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "unclaimedmoniestape":
                    RSS11002.MenuItemUM.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "victorianunclaimedmoniesTape":
                    RSS11002.MenuItemVT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [When(@"In RSS11009 I continue with the following details:")]
        [Given(@"In RSS11009 I continue with the following details:")]
        public void RSS11009ContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "RSS11004")
            {
                RSS11004ContinueWithTheFollowingDetails(table);
            }
            else
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("RSS11009");
                RSS11009.PrintFlag1.SetValue(1, table.Rows[0]["PrintFlag1"]);
                RSS11009.PrintFlag2.SetValue(1, table.Rows[0]["PrintFlag2"]);
                RSS11009.PrintFlag3.SetValue(1, table.Rows[0]["PrintFlag3"]);
                RSS11009.PrintFlag4.SetValue(1, table.Rows[0]["PrintFlag4"]);
                //RSS11009.PrintFlag5.SetValue(1, table.Rows[0]["PrintFlag5"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "RSS11004")
                {
                    RSS11004ContinueWithTheFollowingDetails(table);
                }
                if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "RSS11008")
                {
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "RSS11004")
                    {
                        RSS11004ContinueWithTheFollowingDetails(table);
                    }
                }
            }
        }

        /// <param name="table">data table</param>
        [When(@"In RSS10016 I continue with the following details:")]
        [Given(@"In RSS10016 I continue with the following details:")]
        public void RSS10016ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS10016");
            RSS10016.StaticSelOnly.SetValue(1, table.Rows[0]["StaticSelOnly"]);
            RSS10016.NASearchPattern1.SetValue(1, table.Rows[0]["NASearchPattern1"]);
            RSS10016.NASearchRegexpInd1.SetValue(1, table.Rows[0]["NASearchRegexpInd1"]);
            RSS10016.NASearchLocation1.SetValue(1, table.Rows[0]["NASearchLocation1"]);
            RSS10016.NASearchPattern2.SetValue(1, table.Rows[0]["NASearchPattern2"]);
            RSS10016.NASearchRegexpInd2.SetValue(1, table.Rows[0]["NASearchRegexpInd2"]);
            RSS10016.NASearchLocation2.SetValue(1, table.Rows[0]["NASearchLocation2"]);
            RSS10016.NASearchPattern3.SetValue(1, table.Rows[0]["NASearchPattern3"]);
            RSS10016.NASearchRegexpInd3.SetValue(1, table.Rows[0]["NASearchRegexpInd3"]);
            RSS10016.NASearchLocation3.SetValue(1, table.Rows[0]["NASearchLocation3"]);
            RSS10016.NASearchConnector.SetValue(1, table.Rows[0]["NASearchConnector"]);
            if (table.Rows[0]["PostcodeFlag"] == "E" || table.Rows[0]["PostcodeFlag"] == "I")
            {
                RSS10016.PostcodeFlag.SetValue(1, table.Rows[0]["PostcodeFlag"]);
                RSS10016.PostcodeFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10016.PCFrom1.SetValue(1, table.Rows[0]["PCFrom1"]);
                RSS10016.PCTo1.SetValue(1, table.Rows[0]["PCTo1"]);
                RSS10016.PCFrom2.SetValue(1, table.Rows[0]["PCFrom2"]);
                RSS10016.PCTo2.SetValue(1, table.Rows[0]["PCTo2"]);
                RSS10016.PCFrom3.SetValue(1, table.Rows[0]["PCFrom3"]);
                RSS10016.PCTo3.SetValue(1, table.Rows[0]["PCTo3"]);
                RSS10016.PCFrom4.SetValue(1, table.Rows[0]["PCFrom4"]);
                RSS10016.PCTo4.SetValue(1, table.Rows[0]["PCTo4"]);
            }
            if (table.Rows[0]["DomcodeFlag"] == "I" || table.Rows[0]["DomcodeFlag"] == "E")
            {
                RSS10016.DomcodeFlag.SetValue(1, table.Rows[0]["DomcodeFlag"]);
                RSS10016.DomcodeFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                RSS10016.DomCodes.SetValue(1, table.Rows[0]["DomCodes1"]);
                RSS10016.DomCodes.SetValue(2, table.Rows[0]["DomCodes2"]);
                RSS10016.DomCodes.SetValue(3, table.Rows[0]["DomCodes3"]);
            }

            RSS10016.BrokerNum.SetValue(1, table.Rows[0]["BrokerNum"]);
            RSS10016.NameKeyAlphaFrom.SetValue(1, table.Rows[0]["NameKeyAlphaFrom"]);
            RSS10016.NameKeyAlphaTO.SetValue(1, table.Rows[0]["NameKeyAlphaTO"]);
            RSS10016.Dpid.SetValue(1, table.Rows[0]["Dpid"]);
            //RSS10016.ResidencyInd.SetValue(1, table.Rows[0]["ResidencyInd"]);

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS11008 I continue with the following details:")]
        [Given(@"In RSS11008 I continue with the following details:")]
        public void RSS11008ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11008");
            RSS11008.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            WinFormsTestSteps.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In RSS11004 I continue with the following details:")]
        [Given(@"In RSS11004 I continue with the following details:")]
        public void RSS11004ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RSS11004");
            //RSS11004.MenuItemA.SetValue(1, table.Rows[0]["MenuItemA"]);
            //RSS11004.MenuItemP.SetValue(1, table.Rows[0]["MenuItemP"]);
            //RSS11004.MenuItemC.SetValue(1, table.Rows[0]["MenuItemC"]);
            RSS11004.Sequence.SetValue(1, table.Rows[0]["Sequence"]);
            //RSS11004.PrintCompany.SetValue(1, table.Rows[0]["PrintCompany"]);
            //RSS11004.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            //RSS11004.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            //RSS11004.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            //RSS11004.SpecialProgram.SetValue(1, table.Rows[0]["SpecialProgram"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [Then(@"I copy VMS Trade output to local")]
        public int ThenICopyVMSTradeOutputToLocal(Table table)
        {
            //System.IO.File.AppendAllText(@"c:\\a.txt", "here1");

            String localFileName;
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;
            if (table.Rows[0]["FileName"] == "trd")
            {
                ReportPrintFileName = WinFormsTestSteps.TradeID;
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }
            //int coyindex = currentCOY.IndexOf("/");
            //if (coyindex != -1)
            //{
            //    currentCOY = currentCOY.Substring(coyindex + 1);
            //}

            ////System.IO.File.AppendAllText(@"c:\\a.txt", "here2");
            //if (FileNameDerivedFromInput == false)
            //{
            //    ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
            //}
            //if (ReportPrintFileName.StartsWith("$"))
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(1, ReportPrintFileName.Length - 1);
            //}

            //// System.IO.File.AppendAllText(@"c:\\a.txt", "ReportPrintFileName = " + ReportPrintFileName);

            /* VMS Download */
            var sshFTP = new SftpClient(ConfigurationManager.AppSettings["VMSNode"], ConfigurationManager.AppSettings["VMSUser"], ConfigurationManager.AppSettings["VMSPassword"]);

            string localDIR = ConfigurationManager.AppSettings["DownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");
            var VMSoutputdir = (localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");
            VMSReportDir = VMSoutputdir;
            string vmsDIR;
            if (FileNameDerivedFromInput == false)
            {
                vmsDIR = ConfigurationManager.AppSettings["VMSRemoteFolderPrn"].Replace("COMPANYCODE", currentCOY);
            }
            else
            {
                vmsDIR = ConfigurationManager.AppSettings["VMSRemoteFolderTrd"].Replace("COMPANYCODE", currentCOY);
            }

            sshFTP.Connect();

            // System.IO.File.AppendAllText(@"c:\\a.txt", "VMSoutputdir= " + VMSoutputdir);

            //There are files with different names -only checking the timestamp the get the files
            //if (FileNameDerivedFromInput == false)
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(6);
            //}
            //else
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(0, ReportPrintFileName.Length - 4);
            //}

            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {
                //System.IO.File.AppendAllText(@"c:\\a.txt", "Comparing Server File " + file.Name.ToUpper() + " with local " + ReportPrintFileName.ToUpper() + "\r\n");

                if (file.Name.ToUpper().Contains(ReportPrintFileName.ToUpper()))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                    remoteFileName = vmsDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }

            ReportPrintFileName = "";
            return vmsFileCount;
        }

        /// <param name="table">data table</param>
        [Then(@"I copy Linux Trade output to local")]
        public int ThenICopyLinuxTradeOutputToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;

            if (table.Rows[0]["FileName"] == "trd")
            {
                ReportPrintFileName = WinFormsTestSteps.TradeID;
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }
            if (vmsFileCount == 0)
            {
                Assert.Fail("VMS file count is " + vmsFileCount);
            }

            //int coyindex = currentCOY.IndexOf("/");
            //if (coyindex != -1)
            //{
            //    currentCOY = currentCOY.Substring(coyindex + 1);
            //}
            //if (FileNameDerivedFromInput == false)
            //{
            //    ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
            //}
            ////ReportPrintFileName = ReportPrintFileName.Remove(ReportPrintFileName.Length - 4);
            //if (ReportPrintFileName.StartsWith("$"))
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(1, ReportPrintFileName.Length - 1);
            //}

            //int dollarIndex = ReportPrintFileName.IndexOf("$");
            //if (dollarIndex != -1)
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(dollarIndex + 1);
            //}

            /* Linux Download */
            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["LinuxNode"];
            }
            var sshFTP = new SftpClient(host, ConfigurationManager.AppSettings["LinuxUser"], ConfigurationManager.AppSettings["LinuxPassword"]);
            string localDIR = ConfigurationManager.AppSettings["DownloadFolder"];
            string linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderTrd"].Replace("COMPANYCODE", currentCOY.ToLower());

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux");
            var Linuxoutputdir = localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux";
            LinuxReportDir = Linuxoutputdir;
            sshFTP.Connect();
            //if (FileNameDerivedFromInput == false)
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(6);
            //}
            //else
            //{
            //    ReportPrintFileName = ReportPrintFileName.Substring(0, ReportPrintFileName.Length - 4);
            //}
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }

            linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY.ToLower());

            //Report file names are different in the company level dir (temp and csv)
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {
                if (file.Name.ToLower().Contains(ReportPrintFileName.ToLower()))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }

            return linuxFileCount;
        }



        [Then(@"I parse the files from Linux")]
        public void ThenIParseTheFilesFromLinux()
        {
            foreach (string filename in Directory.EnumerateFiles(LinuxReportDir, "*.*", SearchOption.AllDirectories))
            {
                if (Path.GetExtension(filename) != ".mask")
                    ParseFile(filename, Path.GetExtension(filename) == ".prn");
            }
        }

        [When(@"I compare the files from VMS and Linux goldcopy")]
        [Then(@"I compare the files from VMS and Linux goldcopy")]
        public void CompareTheFilesFromVMSAndLinuxGoldcopy()
        {
            int FtpFIleCount = 0;
            WinFormsTestSteps.Mode = System.Environment.GetEnvironmentVariable("Mode");
            if (WinFormsTestSteps.Mode == null)
            {
                WinFormsTestSteps.Mode = ConfigurationManager.AppSettings["Mode"];
            }

            if (WinFormsTestSteps.Mode.ToLower() == "test")
            {

                String vmsFileName;
                String linuxFileName;

                string VMSReportDir = LinuxReportDir.Replace("Linux", "VMS");
                
                foreach (string filename in Directory.EnumerateFiles(VMSReportDir, "*.*mask", SearchOption.AllDirectories))
                {
                    vmsFileCount++;
                }

                if (vmsFileCount == 0)
                {
                    Assert.Fail("VMS file count is " + vmsFileCount);
                }
                if (vmsFileCount != linuxFileCount || (vmsFileCount + linuxFileCount == 0))
                {
                    Console.WriteLine("The number of files returned between VMS and Linux is different." + "VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
                    //Assert.Fail("The number of files returned between VMS and Linux is different." + "VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
                    FtpFIleCount++;
                }
                else
                    Console.WriteLine("VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);


                // compare each
                foreach (string filename in Directory.EnumerateFiles(VMSReportDir, "*.*mask", SearchOption.AllDirectories))
                {
                    vmsFileName = linuxFileName = filename;
                    linuxFileName = vmsFileName.Replace("VMS","Linux");

                    if (File.Exists(linuxFileName))
                    {
                        if (FileCompare(vmsFileName, linuxFileName) == false)
                        {
                            FailCount++;
                            Console.WriteLine("Failed, File Comparison Failed, " + linuxFileName);
                            //Assert.Fail("File comparison failed. File name: " + vmsFileName);
                        }
                        else
                            Console.WriteLine("Passed, File is Identical, " + linuxFileName);
                    }
                    else
                    {
                        FailCount++;
                        Console.WriteLine("Failed, File Not Found, " + linuxFileName);
                    }
                    
                }

                if (FailCount > 0 && FtpFIleCount==1)
                {
                    Console.WriteLine(FailCount + " Files are Different");
                    Console.WriteLine("The number of files returned between VMS and Linux is different." + "VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
                    Assert.Fail("**** TEST FAIELD ****");
                }
                else if (FailCount > 0 && FtpFIleCount == 0)
                {
                    Console.WriteLine(FailCount + " Files are Different");
                    Assert.Fail("**** TEST FAIELD ****");
                }
                else if (FailCount == 0 && FtpFIleCount == 1)
                {
                    Console.WriteLine("The number of files returned between VMS and Linux is different." + "VMS file count is " + vmsFileCount + " And Linux file count is " + linuxFileCount);
                    Assert.Fail("**** TEST FAIELD ****");
                }
                else
                {
                    Console.WriteLine("Files are Identical");
                    Console.WriteLine("**** TEST PASSED *****");
                }



                }

        }

        [When(@"I copy output files to local")]
        [Given(@"I copy output files to local")]
        [Then(@"I copy output files to local")]
        public void CopyOutputFilesToLocal(Table table)
        {
            FileCount++;
            if (WinFormsTestSteps.Environment ==null)
            {
                WinFormsTestSteps.Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            }

            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                CopyVMSOutputToLocal(table);
            }
            else
            {
                CopyLinuxOutputToLocal(table);
            }
        }




        [When(@"I parse the files from VMS or Linux")]
        [Then(@"I parse the files from VMS or Linux")]
        public void ParseTheFilesFromVMSOrLinux()
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                foreach (string filename in Directory.EnumerateFiles(VMSReportDir, "*.*", SearchOption.AllDirectories))
                {
                    if (Path.GetExtension(filename) != ".mask")
                        ParseFile(filename, false);
                    // set to false because of FTP  processes files differently Removes fortran format)
                    //ParseFile(filename, Path.GetExtension(filename) == ".prn");
                }
            }
            else
            {
                foreach (string filename in Directory.EnumerateFiles(LinuxReportDir, "*.*", SearchOption.AllDirectories))
                {
                    if (Path.GetExtension(filename) != ".mask")
                        ParseFile(filename, Path.GetExtension(filename) == ".prn");
                }
            }

        }

        [When(@"In JOBSUB90 I submit the report for VMS and Linux")]
        public void JOBSUB90SubmitTheReportForVMSAndLinux(Table table)
        {
            string currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (currentScreenName != "OLSB0102")
            {

                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (currentScreenName.ToLower() != "jobsub90" && sw.ElapsedMilliseconds <= 20000)
                {
                    currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                    System.Threading.Thread.Sleep(100);
                }
                if (Spartan.Core.WinForms.WinFormsDriver.GetFormName().ToLower() != "jobsub90")
                    throw new Exception("Not in the expected screen: " + "jobsub90" + "Current screen name is: " + currentScreenName);

                if (currentScreenName == "JOBSUB90")
                {
                    string value = JOBSUB90.SystemInfoFree4.GetValue().Trim();
                    string RunNumber = value.Substring(0, 4);

                    ReportDesc = JOBSUB90.Desc.GetValue();
                    ReportJobNumber = JOBSUB90.JobNODec.GetValue();

                    ReportPRNName = JOBSUB90.ParameterID.GetValue();
                    ReportPrintFileName = JOBSUB90.PrintID.GetValue();
                    TempReportPrintFileName = ReportPrintFileName;

                    if (ReportPrintFileName.ToLower().Contains("rs_ur"))
                        ReportPrintFileName = RunNumber;

                    currentCOY = JOBSUB90.SystemInfoFree7.GetValue();
                    GetCoyFromForm();
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                    //Winforms need to close for URR
                    if (TempReportPrintFileName.ToLower().Contains("rs_ur"))
                        WinFormsTestSteps.ExitFromWinformsFromReportingMenu();

                    if (ReportRunTime.ToString() == "1/1/0001 12:00:00 AM")
                    ReportRunTime = DateTime.Now;
                    ReportTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                }

            }
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {

                WaitForJobNumberVMS(table);
                //if (TempReportPrintFileName.ToLower().Contains("rs_ur"))
                //    SendShellCommand("", host);
            }
            else
            {
                //Temporary to check the pass/fail criteria works
                table.Rows[0]["FailCriteria"] = "EXIT";
                table.Rows[0]["PassCriteria"] = "DONE";
                WaitForJobNumberLinux(table);
                //if (TempReportPrintFileName.ToLower().Contains("rs_ur"))
                //    SendShellCommand("", host);                    
            }
            


        }


        // ### This copy method is temporarry -helping testers to compare DIV files after DIV build -DS 16/05/2016

        [Given(@"I copy DIV output files to local")]
        public void CopyDIVOutputFilesToLocal(Table table)
        {
            WinFormsTestSteps.Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                CopyVMSDIVOutputToLocal(table);
            }
            else
            {
                CopyLinuxDIVOutputToLocal(table);
            }

        }

        // ### This copy method is temporarry -helping testers to compare DIV files after DIV build -DS 16/05/2016
        public int CopyVMSDIVOutputToLocal(Table table)
        {

            String localFileName;
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;

            ReportPrintFileName = (table.Rows[0]["FileName"]);

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }

            /* Create directory */
            var sshFTP = new SftpClient(ConfigurationManager.AppSettings["VMSNode"], ConfigurationManager.AppSettings["VMSUser"], ConfigurationManager.AppSettings["VMSPassword"]);

            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS") == true)
            {
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS", true);
            }
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");
            var VMSoutputdir = (localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/VMS");
            VMSReportDir = VMSoutputdir;

            /*Get VMS directory path */
            string vmsDIR = null;
            if (FileNameDerivedFromInput == false)
            {
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {

                        System.Threading.Thread.Sleep(5000);
                        //var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.DIVDIV1] && w");
                        var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.DIV" + table.Rows[0]["DividendName"] + "] && w");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        vmsDIR = output;
                        sshClient.Disconnect();
                    }

                }
            }
            else
            {
                vmsDIR = ConfigurationManager.AppSettings["VMSRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY);
            }

            /*FTP VMS files */
            sshFTP.Connect();
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
            {

                //if ((Path.GetExtension(file.Name).ToLower() != ".com;1") && (Path.GetExtension(file.Name).ToLower() != ".log;1"))
                if ((Path.GetExtension(file.Name).ToLower().Contains(".prn")) || (Path.GetExtension(file.Name).ToLower().Contains(".temp")) || (Path.GetExtension(file.Name).ToLower().Contains(".csv")))
                {
                    Console.WriteLine(file);
                    localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                    remoteFileName = vmsDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    vmsFileCount++;
                }
            }

            ReportPrintFileName = "";
            return vmsFileCount;
        }


        // ### This copy method is temporarry -helping testers to compare DIV files after DIV build -DS 16/05/2016
        public int CopyLinuxDIVOutputToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;

            ReportPrintFileName = (table.Rows[0]["FileName"]);

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }

            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            var sshFTP = new SftpClient(host, ConfigurationManager.AppSettings["LinuxUser"], ConfigurationManager.AppSettings["LinuxPassword"]);
            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];
            string linuxDIR = (ConfigurationManager.AppSettings["LinuxRemoteFolderDiv"].Replace("COMPANYCODE", currentCOY.ToLower())) + table.Rows[0]["DividendName"];

            /* Create directory */
            string reportName = ScenarioContext.Current.ScenarioInfo.Title;
            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux") == true)
            {
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux", true);
            }
            Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux");


            var Linuxoutputdir = localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux";
            LinuxReportDir = Linuxoutputdir;

            /*FTP VMS files */
            sshFTP.Connect();
            foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
            {

                //if ((Path.GetExtension(file.Name).ToLower() != ".com;1") && (Path.GetExtension(file.Name).ToLower() != ".log;1") && (file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name).ToLower() != ".sh"))
                if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name).ToLower().Contains(".prn")) || (Path.GetExtension(file.Name).ToLower().Contains(".temp")) || (Path.GetExtension(file.Name).ToLower().Contains(".csv")))
                {
                    Console.WriteLine(file);
                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                    remoteFileName = linuxDIR + file.Name;
                    streamFile = File.OpenWrite(localFileName);
                    sshFTP.DownloadFile(file.FullName, streamFile);
                    streamFile.Close();

                    linuxFileCount++;
                }
            }
            return linuxFileCount;
        }

        [When(@"In TRDRSP11 I continue with the following details:")]
        public void WTRDRSP11ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("TRDRSP11");
            TRDRSP11.Preload.SetValue(1, table.Rows[0]["Preload"]);
            WinFormsTestSteps.Transmit();
        }

        [When(@"In TRDRSP01 I continue with the following details:")]
        public void TRDRSP01ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("TRDRSP01");
            TRDRSP01.ClientCode.SetValue(1, table.Rows[0]["ClientCode1"]);
            TRDRSP01.ClientCode.SetValue(2, table.Rows[0]["ClientCode2"]);
            TRDRSP01.CompanyCode.SetValue(1, table.Rows[0]["CompanyCode1"]);
            TRDRSP01.CompanyCode.SetValue(2, table.Rows[0]["CompanyCode2"]);
            TRDRSP01.ClassCode.SetValue(1, table.Rows[0]["ClassCode1"]);
            TRDRSP01.ClassCode.SetValue(2, table.Rows[0]["ClassCode2"]);
            if (TRDRSP01.RegCode.Exists() == true)
            {
                TRDRSP01.RegCode.SetValue(1, table.Rows[0]["RegCode1"]);
                TRDRSP01.RegCode.SetValue(2, table.Rows[0]["RegCode2"]);
            }

            TRDRSP01.TrdCntrlCode.SetValue(1, table.Rows[0]["TrdCntrlCode1"]);
            TRDRSP01.TrdCntrlCode.SetValue(2, table.Rows[0]["TrdCntrlCode2"]);
            TRDRSP01.TrdCntrlCode.SetValue(3, table.Rows[0]["TrdCntrlCode3"]);
            TRDRSP01.ReportNonCurrent.SetValue(1, table.Rows[0]["ReportNonCurrent"]);
            TRDRSP01.TrdType.SetValue(1, table.Rows[0]["TrdType"]);
            TRDRSP01.RealTimeTrdInd.SetValue(1, table.Rows[0]["RealTimeTrdInd"]);
            TRDRSP01.TrdOrdStatus.SetValue(1, table.Rows[0]["TrdOrdStatus1"]);
            TRDRSP01.TrdOrdStatus.SetValue(2, table.Rows[0]["TrdOrdStatus2"]);
            TRDRSP01.CutOffDateFrom.SetValue(1, table.Rows[0]["CutOffDateFrom"]);
            TRDRSP01.CutOffDateTO.SetValue(1, table.Rows[0]["CutOffDateTO"]);
            TRDRSP01.TrdDateFrom.SetValue(1, table.Rows[0]["TrdDateFrom"]);
            TRDRSP01.TrdDateTO.SetValue(1, table.Rows[0]["TrdDateTO"]);
            TRDRSP01.StlDateFrom.SetValue(1, table.Rows[0]["StlDateFrom"]);
            TRDRSP01.StlDateTO.SetValue(1, table.Rows[0]["StlDateTO"]);
            TRDRSP01.OrdNumFrom.SetValue(1, table.Rows[0]["OrdNumFrom"]);
            TRDRSP01.OrdNumTO.SetValue(1, table.Rows[0]["OrdNumTO"]);
            TRDRSP01.FinalPriceFrom.SetValue(1, table.Rows[0]["FinalPriceFrom"]);
            TRDRSP01.FinalPriceTO.SetValue(1, table.Rows[0]["FinalPriceTO"]);
            TRDRSP01.TotUnitRangeFrom.SetValue(1, table.Rows[0]["TotUnitRangeFrom"]);
            TRDRSP01.TotUnitRangeTO.SetValue(1, table.Rows[0]["TotUnitRangeTO"]);
            TRDRSP01.TotMnyRangeFrom.SetValue(1, table.Rows[0]["TotMnyRangeFrom"]);
            TRDRSP01.TotMnyRangeTO.SetValue(1, table.Rows[0]["TotMnyRangeTO"]);

            if (TRDRSP01.TranNumRangeFrom.Exists() == true)
            {
                TRDRSP01.TranNumRangeFrom.SetValue(1, table.Rows[0]["TranNumRangeFrom"]);
                TRDRSP01.TranNumRangeTO.SetValue(1, table.Rows[0]["TranNumRangeTO"]);
            }
            if (TRDRSP01.PymtRefRangeFrom.Exists() == true)
            {
                TRDRSP01.PymtRefRangeFrom.SetValue(1, table.Rows[0]["PymtRefRangeFrom"]);
                TRDRSP01.PymtRefRangeTO.SetValue(1, table.Rows[0]["PymtRefRangeTO"]);
            }
            WinFormsTestSteps.Transmit();

        }

        [When(@"In TRDRSP03 I continue with the following details:")]
        public void TRDRSP03ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("TRDRSP03");
            TRDRSP03.OrderType.SetValue(1, table.Rows[0]["OrderType"]);
            TRDRSP03.LimitPriceFrom.SetValue(1, table.Rows[0]["LimitPriceFrom"]);
            TRDRSP03.LimitPriceTO.SetValue(1, table.Rows[0]["LimitPriceTO"]);
            TRDRSP03.OrdDurationType.SetValue(1, table.Rows[0]["OrdDurationType"]);
            TRDRSP03.OrmsOrderStatus.SetValue(1, table.Rows[0]["OrmsOrderStatus1"]);
            TRDRSP03.OrmsOrderStatus.SetValue(2, table.Rows[0]["OrmsOrderStatus2"]);
            TRDRSP03.DateOrderSentFrom.SetValue(1, table.Rows[0]["DateOrderSentFrom"]);
            TRDRSP03.DateOrderSentTO.SetValue(1, table.Rows[0]["DateOrderSentTo"]);
            TRDRSP03.BrokerCode.SetValue(1, table.Rows[0]["BrokerCode"]);
            TRDRSP03.BrokerAccount.SetValue(1, table.Rows[0]["BrokerAccount"]);
            TRDRSP03.RecnCode.SetValue(1, table.Rows[0]["RecnCode"]);
            TRDRSP03.PayAccount.SetValue(1, table.Rows[0]["PayAccount1"]);
            TRDRSP03.PayAccount.SetValue(2, table.Rows[0]["PayAccount2"]);
            TRDRSP03.ChgPaidBY.SetValue(1, table.Rows[0]["ChgPaidBY1"]);
            TRDRSP03.ChgPaidBY.SetValue(2, table.Rows[0]["ChgPaidBY2"]);
            TRDRSP03.ChgType.SetValue(1, table.Rows[0]["ChgType1"]);
            TRDRSP03.ChgType.SetValue(2, table.Rows[0]["ChgType2"]);

            if (TRDRSP03.PaymentMethod.Exists() == true)
            {
                TRDRSP03.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod1"]);
                TRDRSP03.PaymentMethod.SetValue(2, table.Rows[0]["PaymentMethod2"]);
                TRDRSP03.PymtCurrCode.SetValue(1, table.Rows[0]["PymtCurrCode1"]);
                TRDRSP03.PymtCurrCode.SetValue(2, table.Rows[0]["PymtCurrCode2"]);
            }

            TRDRSP03.ReportFormat.SetValue(1, table.Rows[0]["ReportFormat"]);

            if (TRDRSP03.CertDtlsInd.Exists() == true)
            {
                TRDRSP03.CertDtlsInd.SetValue(1, table.Rows[0]["CertDtlsInd"]);
            }

            if (TRDRSP03.ReversedTradeInd.Exists() == true)
            {
                TRDRSP03.ReversedTradeInd.SetValue(1, table.Rows[0]["ReversedTradeInd"]);
            }
            WinFormsTestSteps.Transmit();

        }


        [When(@"In TRDRSP12 I continue with the following details:")]
        public void TRDRSP12ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("TRDRSP12");
            TRDRSP12.ClassCode.SetValue(1, table.Rows[0]["ClassCode1"]);
            TRDRSP12.ClassCode.SetValue(2, table.Rows[0]["ClassCode2"]);
            TRDRSP12.TrdCntrlCode.SetValue(1, table.Rows[0]["TrdCntrlCode1"]);
            TRDRSP12.TrdCntrlCode.SetValue(2, table.Rows[0]["TrdCntrlCode2"]);
            TRDRSP12.TrdCntrlCode.SetValue(3, table.Rows[0]["TrdCntrlCode3"]);
            TRDRSP12.TrdType.SetValue(1, table.Rows[0]["TrdType"]);
            TRDRSP12.ReportNonCurrent.SetValue(1, table.Rows[0]["ReportNonCurrent"]);
            TRDRSP12.ReportEventBulks.SetValue(1, table.Rows[0]["ReportEventBulks"]);
            TRDRSP12.ApplyTransactions.SetValue(1, table.Rows[0]["ApplyTransactions"]);
            TRDRSP12.ONMarketTradeInd.SetValue(1, table.Rows[0]["ONMarketTradeInd"]);
            TRDRSP12.RealTimeTrdInd.SetValue(1, table.Rows[0]["RealTimeTrdInd"]);
            TRDRSP12.OnlineEntryInd.SetValue(1, table.Rows[0]["OnlineEntryInd"]);
            TRDRSP12.WebEntryInd.SetValue(1, table.Rows[0]["WebEntryInd"]);
            TRDRSP12.TransactionAuditInd.SetValue(1, table.Rows[0]["TransactionAuditInd"]);
            TRDRSP12.ReconciliationCode.SetValue(1, table.Rows[0]["ReconciliationCode1"]);
            TRDRSP12.ReconciliationCode.SetValue(1, table.Rows[0]["ReconciliationCode2"]);

            if (TRDRSP12.ClientCode.Exists() == true)
            {
                TRDRSP12.ClientCode.SetValue(1, table.Rows[0]["ClientCode1"]);
                TRDRSP12.ClientCode.SetValue(2, table.Rows[0]["ClientCode2"]);
            }
            if (TRDRSP12.CompanyCode.Exists() == true)
            {
                TRDRSP12.CompanyCode.SetValue(1, table.Rows[0]["CompanyCode1"]);
                TRDRSP12.CompanyCode.SetValue(2, table.Rows[0]["CompanyCode2"]);
            }
            WinFormsTestSteps.Transmit();

        }


        [When(@"In TRDRSP13 I continue with the following details:")]
        public void TRDRSP13ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("TRDRSP13");
            TRDRSP13.CommChgCode.SetValue(1, table.Rows[0]["CommChgCode1"]);
            TRDRSP13.CommChgCode.SetValue(2, table.Rows[0]["CommChgCode2"]);
            TRDRSP13.CommChgCode.SetValue(3, table.Rows[0]["CommChgCode3"]);
            TRDRSP13.ReportMasterCodes.SetValue(1, table.Rows[0]["ReportMasterCodes"]);
            TRDRSP13.CommChgTypes.SetValue(1, table.Rows[0]["CommChgTypes1"]);
            TRDRSP13.CommChgTypes.SetValue(2, table.Rows[0]["CommChgTypes2"]);
            TRDRSP13.CommChgTypes.SetValue(3, table.Rows[0]["CommChgTypes3"]);
            TRDRSP13.TestChargeCodesInd.SetValue(1, table.Rows[0]["TestChargeCodesInd"]);
            TRDRSP13.TestCalcDealInput.SetValue(1, table.Rows[0]["TestCalcDealInput"]);
            TRDRSP13.TestCalcBulkInput.SetValue(1, table.Rows[0]["TestCalcBulkInput"]);
            TRDRSP13.TestCalcUnitInput.SetValue(1, table.Rows[0]["TestCalcUnitInput"]);

            if (TRDRSP13.ClientCode.Exists() == true)
            {
                TRDRSP13.ClientCode.SetValue(1, table.Rows[0]["ClientCode1"]);
                TRDRSP13.ClientCode.SetValue(2, table.Rows[0]["ClientCode2"]);
            }
            if (TRDRSP13.CompanyCode.Exists() == true)
            {
                TRDRSP13.CompanyCode.SetValue(1, table.Rows[0]["CompanyCode1"]);
                TRDRSP13.CompanyCode.SetValue(2, table.Rows[0]["CompanyCode2"]);
            }

            WinFormsTestSteps.Transmit();

        }

        [When(@"I read Timestamps from the Health and Integrity file as:")]
        public void ReadTimestampsFromTheHealthAndIntegrityFile(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                ReadVMSTimestamps(table);
            }
            else
            {
                ReadLinuxTimestamps(table);
            }
        }

        public void ReadVMSTimestamps(Table table)
        {
            if (table.Rows[0]["FileName"] != "")
                ReportPrintFileName = (table.Rows[0]["FileName"]);
            else
            {
                ReportPrintFileName = (ReportPrintFileName.Remove(ReportPrintFileName.Length - 4) + "_TOT.PRN;");
            }
            currentCOY = table.Rows[0]["COY"];

            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    char cs = (char)34;

                    System.Threading.Thread.Sleep(5000);
                    String str = "pipe sc " + currentCOY + " && set def [.prn] && search " + ReportPrintFileName + " " + cs + "H & I Date Time Stamp" + cs;
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    Timestamps = output.Remove(output.Length - 3);
                    Timestamps = Timestamps.Substring(Timestamps.Length - 14);
                    Console.WriteLine(Timestamps);
                    sshClient.Disconnect();
                }
            }
        }

        public void ReadLinuxTimestamps(Table table)
        {
            if (table.Rows[0]["FileName"] != "")
                ReportPrintFileName = (table.Rows[0]["FileName"]);
            else
            {
                ReportPrintFileName = (ReportPrintFileName.Remove(ReportPrintFileName.Length - 4) + "_tot.prn");
            }
            currentCOY = table.Rows[0]["COY"];

            var host = WinFormsTestSteps.Environment;
            if(host == null)
                host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];

            //var TimestampsDir = ConfigurationManager.AppSettings["TimestampsPath"];
            //TimestampsDir = TimestampsDir.Replace("COMPANYCODE", currentCOY).ToLower();

            //Temporary
            var TimestampsDir = "COMPANYCODE/prn";
            TimestampsDir = TimestampsDir.Replace("COMPANYCODE", currentCOY).ToLower();
            char dq = (char)34;
            char sq = (char)39;

            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    System.Threading.Thread.Sleep(5000);
                    String str = "sc " + TimestampsDir + " && grep " + dq + "H & I Date Time Stamp" + dq + " " + sq + ReportPrintFileName + sq;
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    Timestamps = output.Remove(output.Length - 1);
                    Timestamps = Timestamps.Substring(output.Length - 15);
                    Console.WriteLine(Timestamps);
                    sshClient.Disconnect();
                }
            }
        }

        //URR Capture Rollback
        [When(@"I start Capture Rollback process")]
        public void StartCaptureRollbackProcess(Table table)
        {
            DeleteRollbackExtract(table);
            StartCaptureRollback(table, currentCOY);
        }

        //URR Capture Rollback
        public void DeleteRollbackExtract(Table table)
        {

            currentCOY = table.Rows[0]["COY"];

            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {

                if (host.ToLower() == "csshyc")
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {
                        String str ="pipe sc " + currentCOY + " && delete ROLLBACK_EXTRACT.TXT;*";
                        var cmd = sshClient.RunCommand(str);
                        var output = cmd.Result;

                        if (output.Contains("file not found"))
                            Console.WriteLine("Rollback file not found in " + currentCOY);
                        else if (output.Contains(""))
                            Console.WriteLine("Rollback file is deleted in " + currentCOY);
                    }
                    sshClient.Disconnect();
                }
                else
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {
                        String str = "sc " + currentCOY + " && rm ROLLBACK_*.TXT";
                        var cmd = sshClient.RunCommand(str);
                        var output = cmd.Result;
                        if (output.Contains("No such file or directory"))
                            Console.WriteLine("Rollback file not found in " + currentCOY);
                        else if (output.Contains(""))
                            Console.WriteLine("Rollback file is deleted in " + currentCOY);
                    }
                    sshClient.Disconnect();
                }
            }


        }
        

        //URR Capture Rollback
        public void StartCaptureRollback(Table table, string currentCOY)
        {

            currentCOY = table.Rows[0]["COY"];
            host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            if (host.ToLower() == "csshyc")
            {
                username = ConfigurationManager.AppSettings["VMSUser"];
                pwd = ConfigurationManager.AppSettings["VMSPassword"];
            }
            else
            {
                username = ConfigurationManager.AppSettings["LinuxUser"];
                pwd = ConfigurationManager.AppSettings["LinuxPassword"];
            }



            // establish the connection to the SSH session
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);
            SSHManager.SendShellCommand("sc " + currentCOY, host, new List<String>(), new List<String>());

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            passCriteria.Add("Press <RETURN> to START capture");

            if (host.ToLower() == "csshyc")
            {
                SSHManager.SendShellCommand("capture_rollback /raw /mask /company=" + currentCOY + " /output=ROLLBACK_EXTRACT.TXT", host, passCriteria, new List<String>());
            }
            else
            {
                SSHManager.SendShellCommand("capture_rollback --raw --mask --company=" + currentCOY + " --output=ROLLBACK_EXTRACT.TXT", host, passCriteria, new List<String>());
            }

            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());

        }


        [When(@"I stop Capture Rollback process")]
        public void StopCaptureRollbackProcess(Table table)
        {
            currentCOY = table.Rows[0]["COY"];
            host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            if (host.ToLower() == "csshyc")
            {
                username = ConfigurationManager.AppSettings["VMSUser"];
                pwd = ConfigurationManager.AppSettings["VMSPassword"];
            }
            else
            {
                username = ConfigurationManager.AppSettings["LinuxUser"];
                pwd = ConfigurationManager.AppSettings["LinuxPassword"];
            }

            List<String> passCriteria;
            List<String> failCriteria;
            passCriteria = new List<String>();
            passCriteria.Add("Created file: ROLLBACK_EXTRACT.TXT");
            SSHManager.SendShellCommand("", host, passCriteria, new List<String>());

        }

        [When(@"I copy URR files to local")]
        [Then(@"I copy URR files to local")]
        public void ICopyURRFilesToLocal(Table table)
        {
            FileCount++;
            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            }

            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                CopyVmsURRFilesToLocal(table);
            }
            else
            {
                CopyLinuxURRFilesToLocal(table);
            }


        }

        
        //Created a seperate method as we are ftping all the files which got created after the URR 
        //Does not check Timestamps or Run Number
        [Then(@"I copy Vms URR Files to local")]
        [When(@"I copy Vms URR Files to local")]
        public int CopyVmsURRFilesToLocal(Table table)
        {
           String localFileName = "";
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;
            //need to put a hard wait, after the URR its taking some time to remove the locks in the files
            if (table.Rows[0]["FileName"] != "")
            {
                ReportPrintFileName = (table.Rows[0]["FileName"]).ToLower();
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
            {
                currentCOY = table.Rows[0]["COY"];
            }
            int coyindex = currentCOY.IndexOf("/");
            if (coyindex != -1)
            {
                currentCOY = currentCOY.Substring(coyindex + 1);
            }

            //Timestamps
            TempReportPrintFileName = TempReportPrintFileName.Remove(TempReportPrintFileName.Length - 6);
            TempReportPrintFileName = TempReportPrintFileName.Substring(TempReportPrintFileName.Length - 8);

            /* VMS Download */
            var sshFTP = new SftpClient(ConfigurationManager.AppSettings["VMSNode"], ConfigurationManager.AppSettings["VMSUser"], ConfigurationManager.AppSettings["VMSPassword"]);

            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;

            var VMSDir = ConfigurationManager.AppSettings["VMSDir"];

            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + VMSDir) == true && FileCount == 1)
            {
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + VMSDir, true);
            }
            if (FileCount == 1)
                Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + VMSDir);

            var VMSoutputdir = (localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + VMSDir);
            VMSReportDir = VMSoutputdir;
            string vmsDIR = null;

            sshFTP.Connect();
            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {
                //Company level
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {

                        System.Threading.Thread.Sleep(5000);
                        var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && w");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        vmsDIR = output;
                        sshClient.Disconnect();
                    }

                }
                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                {

                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                    {
                        if ((!Path.GetExtension(file.Name).ToLower().Contains(".isam")) && (!Path.GetExtension(file.Name).ToLower().Contains(".dir")) && (!file.Name.Contains("DUMMY")) && (!file.Name.Contains("ARL")) && (!file.Name.Contains("PARAM_")))
                        {
                            Console.WriteLine(file);
                            localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                            if (file.Name.ToLower().Contains("rs_ur"))
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                            remoteFileName = vmsDIR + file.Name;
                            streamFile = File.OpenWrite(localFileName);
                            sshFTP.DownloadFile(file.FullName, streamFile);
                            streamFile.Close();

                            vmsFileCount++;
                        }

                    }

                }


            }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                //PRN Dir
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {

                        System.Threading.Thread.Sleep(5000);
                        var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.prn] && w");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        vmsDIR = output;
                        sshClient.Disconnect();
                    }

                }

                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                {
                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0 && (!file.Name.Contains("DUMMY")))
                    {
                        Console.WriteLine(file);
                        localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                        localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                        remoteFileName = vmsDIR + file.Name;
                        streamFile = File.OpenWrite(localFileName);
                        sshFTP.DownloadFile(file.FullName, streamFile);
                        streamFile.Close();

                        vmsFileCount++;
                    }
                }

            }

            //Other location1
            if (table.Rows[0].ContainsKey("fileLocationVMS1"))
            {
                if (table.Rows[0]["OtherFile1"].ToLower() == "y")
                {
                    using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                    {
                        sshClient.Connect();
                        if (sshClient.IsConnected == true)
                        {

                            System.Threading.Thread.Sleep(5000);
                            //var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.prn_aus] && w");
                            var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def " + table.Rows[0]["fileLocationVMS1"] + " && w");
                            var output = cmd.Result.Replace("/n/r", "").Trim();
                            vmsDIR = output;
                            sshClient.Disconnect();
                        }

                    }

                    foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                    {
                        if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                        {
                            if ((!Path.GetExtension(file.Name).ToLower().Contains(".log")) && (!Path.GetExtension(file.Name).ToLower().Contains(".com")) && (!Path.GetExtension(file.Name).ToLower().Contains(".isam")) && (!file.Name.Contains("DUMMY")))
                            {
                                Console.WriteLine(file);
                                localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                                //Different directories have the same file name 
                                //PRN_AUS //PRN_NZL
                                string fileLocationVMS = table.Rows[0]["fileLocationVMS1"];

                                int start = fileLocationVMS.IndexOf(".") + 1;
                                int end = fileLocationVMS.IndexOf("]", start);
                                string result = fileLocationVMS.Substring(start, end - start);
                                localFileName = localFileName + "_" + result;


                                remoteFileName = vmsDIR + file.Name;
                                streamFile = File.OpenWrite(localFileName);

                                sshFTP.DownloadFile(file.FullName, streamFile);
                                streamFile.Close();

                                vmsFileCount++;
                            }
                        }
                    }


                }
            }


            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                //Other location2
                if (table.Rows[0].ContainsKey("fileLocationVMS2"))
                {
                    if (table.Rows[0]["OtherFile2"].ToLower() == "y")
                    {
                        using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                        {
                            sshClient.Connect();
                            if (sshClient.IsConnected == true)
                            {

                                System.Threading.Thread.Sleep(5000);
                                //var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.prn_nzl] && w");
                                var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def " + table.Rows[0]["fileLocationVMS2"] + " && w");
                                var output = cmd.Result.Replace("/n/r", "").Trim();
                                vmsDIR = output;
                                sshClient.Disconnect();
                            }

                        }

                        foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                        {
                            if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                            {
                                Console.WriteLine(file);
                                localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                                //Different directories have the same file name 
                                //PRN_AUS //PRN_NZL
                                string fileLocationVMS = table.Rows[0]["fileLocationVMS2"];

                                int start = fileLocationVMS.IndexOf(".") + 1;
                                int end = fileLocationVMS.IndexOf("]", start);
                                string result = fileLocationVMS.Substring(start, end - start);
                                localFileName = localFileName + "_" + result;

                                remoteFileName = vmsDIR + file.Name;
                                streamFile = File.OpenWrite(localFileName);
                                sshFTP.DownloadFile(file.FullName, streamFile);
                                streamFile.Close();

                                vmsFileCount++;
                            }
                        }


                    }
                }
            }


            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {


                //TRD Directory
                using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                {
                    sshClient.Connect();
                    if (sshClient.IsConnected == true)
                    {

                        System.Threading.Thread.Sleep(5000);
                        var cmd = sshClient.RunCommand("pipe sc " + currentCOY + " && set def [.trd] && w");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        vmsDIR = output;
                        sshClient.Disconnect();
                    }

                }

                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                {
                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                    {
                        if ((!Path.GetExtension(file.Name).ToLower().Contains(".isam")) && (!Path.GetExtension(file.Name).ToLower().Contains(".dir")))
                        {
                            Console.WriteLine(file);
                            localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");


                            if (file.Name.ToLower().Contains("rs_ur"))
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                            remoteFileName = vmsDIR + file.Name;
                            streamFile = File.OpenWrite(localFileName);
                            sshFTP.DownloadFile(file.FullName, streamFile);
                            streamFile.Close();

                            vmsFileCount++;
                        }

                    }
                }

            }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                //Extrnal Files. outside company level    
                if (table.Rows[0].ContainsKey("ExternalFiles"))
                {
                    if (table.Rows[0]["ExternalFiles"].ToLower() == "y")
                    {
                        using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
                        {
                            sshClient.Connect();
                            if (sshClient.IsConnected == true)
                            {
                                System.Threading.Thread.Sleep(5000);
                                var cmd = sshClient.RunCommand("pipe sc " + table.Rows[0]["ExternalFileLocation"] + " && w");
                                var output = cmd.Result.Replace("/n/r", "").Trim();
                                vmsDIR = output;
                                sshClient.Disconnect();
                            }

                        }

                        foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(vmsDIR))
                        {
                            if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                            {
                                Console.WriteLine(file);
                                localFileName = VMSoutputdir + "/" + Regex.Replace(Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx"), @";\d+$", "");

                                if (file.Name.ToLower().Contains("rs_ur"))
                                    localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                                remoteFileName = vmsDIR + file.Name;
                                streamFile = File.OpenWrite(localFileName);
                                sshFTP.DownloadFile(file.FullName, streamFile);
                                streamFile.Close();

                                vmsFileCount++;
                            }
                        }

                    }
                }
            }

            ReportPrintFileName = "";
            sshFTP.Disconnect();
            return vmsFileCount;

        }


        /// <param name="table">data table</param>
        [Then(@"I copy Linux URR Files to local")]
        [When(@"I copy Linux URR Files to local")]
        public int CopyLinuxURRFilesToLocal(Table table)
        {
            String localFileName;
            string remoteFileName;
            Stream streamFile;
            var FileNameDerivedFromInput = false;

            if (table.Rows[0]["FileName"] != "")
            {
                ReportPrintFileName = (table.Rows[0]["FileName"]).ToLower();
                FileNameDerivedFromInput = true;
            }

            if (currentCOY == null)
                currentCOY = table.Rows[0]["COY"];
            
            int coyindex = currentCOY.IndexOf("/");

            if (coyindex != -1)
                currentCOY = currentCOY.Substring(coyindex + 1);

            //Timesstams
            TempReportPrintFileName = TempReportPrintFileName.Remove(TempReportPrintFileName.Length - 6);
            TempReportPrintFileName = TempReportPrintFileName.Substring(TempReportPrintFileName.Length - 8);

            /* Linux Download */
            var host = System.Environment.GetEnvironmentVariable("VMHOST");

            if (host == null)
                host = WinFormsTestSteps.Environment;

            var sshFTP = new SftpClient(host, ConfigurationManager.AppSettings["LinuxUser"], ConfigurationManager.AppSettings["LinuxPassword"]);
            string localDIR = ConfigurationManager.AppSettings["LocalDownloadFolder"];

            string reportName = ScenarioContext.Current.ScenarioInfo.Title;

            if (Directory.Exists(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux") == true && FileCount == 1)
                Directory.Delete(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux", true);
            
            if (FileCount == 1)
                Directory.CreateDirectory(localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux");


            var Linuxoutputdir = localDIR + reportName + "-" + table.Rows[0]["ReportHeading"] + "/Linux";
            LinuxReportDir = Linuxoutputdir;
            string linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE", currentCOY.ToLower());
            sshFTP.Connect();

            //Company level

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                {
                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                    {
                        if ((file.Name != ".") && (file.Name != ".."))
                        {
                            if ((!Path.GetExtension(file.Name).ToLower().Contains(".dat")) && (!Path.GetExtension(file.Name).ToLower().Contains(".idx")) && (!Path.GetExtension(file.Name).ToLower().Contains(".isam")) && (Path.GetExtension(file.Name) != "") && (!file.Name.Contains("dummy")) && (!file.Name.Contains("arl")))
                            {
                                Console.WriteLine(file);
                                localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                                remoteFileName = linuxDIR + file.Name;
                                streamFile = File.OpenWrite(localFileName);
                                sshFTP.DownloadFile(file.FullName, streamFile);
                                streamFile.Close();

                                linuxFileCount++;

                            }
                        }
                    }
                }
            }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                // PRN directory
                linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderPrn"].Replace("COMPANYCODE", currentCOY.ToLower());
                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                {
                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                    {
                        if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name) != ""))
                        {
                            Console.WriteLine(file);
                            localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                            localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                            remoteFileName = linuxDIR + file.Name;
                            streamFile = File.OpenWrite(localFileName);
                            sshFTP.DownloadFile(file.FullName, streamFile);
                            streamFile.Close();

                            linuxFileCount++;
                        }


                    }
                }
            }

                //Other location1  
                if (table.Rows[0].ContainsKey("fileLocationVLnx1"))
                {

                    if (table.Rows[0]["OtherFileLnx1"].ToLower() == "y")
                    {
                        //linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderOther"].Replace("COMPANYCODE", currentCOY.ToLower());
                        var linuxDIRtmp = "/company/COMPANYCODE/dir";
                        linuxDIR = linuxDIRtmp.Replace("COMPANYCODE", currentCOY.ToLower());
                        linuxDIR = linuxDIR.Replace("dir", table.Rows[0]["fileLocationVLnx1"]);

                        foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                        {
                            if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                            {
                                if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name) != "") && (!Path.GetExtension(file.Name).ToLower().Contains(".log")) && (!Path.GetExtension(file.Name).ToLower().Contains(".sh")) && (!file.Name.ToLower().Contains(".dat")) && (!file.Name.ToLower().Contains(".idx")))
                                {
                                    Console.WriteLine(file);
                                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                                    localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                                    //Different directories have the same file name 
                                    //PRN_AUS //PRN_NZL
                                    localFileName = localFileName + "_" + table.Rows[0]["fileLocationVLnx1"];


                                    remoteFileName = linuxDIR + file.Name;
                                    streamFile = File.OpenWrite(localFileName);
                                    sshFTP.DownloadFile(file.FullName, streamFile);
                                    streamFile.Close();

                                    linuxFileCount++;
                                }
                            }
                        }
                    }
                }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                //Other location2  
                if (table.Rows[0].ContainsKey("fileLocationVLnx2"))
                {

                    if (table.Rows[0]["OtherFileLnx2"].ToLower() == "y")
                    {
                        //linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderOther"].Replace("COMPANYCODE", currentCOY.ToLower());
                        //linuxDIR = linuxDIR.Replace("dir", table.Rows[0]["fileLocationVLnx2"]);

                        var linuxDIRtmp = "/company/COMPANYCODE/dir";
                        linuxDIR = linuxDIRtmp.Replace("COMPANYCODE", currentCOY.ToLower());
                        linuxDIR = linuxDIR.Replace("dir", table.Rows[0]["fileLocationVLnx2"]);

                        foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                        {
                            if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                            {

                                if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name) != ""))
                                {
                                    Console.WriteLine(file);
                                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                                    localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");


                                    //Different directories have the same file name 
                                    //PRN_AUS //PRN_NZL
                                    localFileName = localFileName + "_" + table.Rows[0]["fileLocationVLnx2"];


                                    remoteFileName = linuxDIR + file.Name;
                                    streamFile = File.OpenWrite(localFileName);
                                    sshFTP.DownloadFile(file.FullName, streamFile);
                                    streamFile.Close();

                                    linuxFileCount++;
                                }

                            }
                        }
                    }
                }

            }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderTrd"].Replace("COMPANYCODE", currentCOY.ToLower());

                //sftp TRD directory files
                foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                {
                    if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                    {

                        if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name) != ""))
                        {
                            if ((!Path.GetExtension(file.Name).ToLower().Contains(".isam")) && (!Path.GetExtension(file.Name).ToLower().Contains(".idx")) && (!Path.GetExtension(file.Name).ToLower().Contains(".dat")))
                            {
                                Console.WriteLine(file);
                                localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                                localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                                remoteFileName = linuxDIR + file.Name;
                                streamFile = File.OpenWrite(localFileName);
                                sshFTP.DownloadFile(file.FullName, streamFile);
                                streamFile.Close();

                                linuxFileCount++;
                            }
                        }

                    }
                }
            }

            if (table.Rows[0]["OnlyCorporateActionFiles"].ToLower() != "y")
            {

                //ExternalFileLocation
                if (table.Rows[0].ContainsKey("ExternalFiles"))
                {
                    if (table.Rows[0]["ExternalFiles"].ToLower() == "y")
                    {
                        //Extrnal Files. outside company level, eg:CPM_DOC
                        linuxDIR = ConfigurationManager.AppSettings["LinuxRemoteFolderLocal"].Replace("COMPANYCODE", table.Rows[0]["ExternalFileLocation"].ToLower());

                        foreach (Renci.SshNet.Sftp.SftpFile file in sshFTP.ListDirectory(linuxDIR))
                        {
                            if (file.LastWriteTime.CompareTo(ReportRunTime) > 0)
                            {

                                if ((file.Name != ".") && (file.Name != "..") && (Path.GetExtension(file.Name) != ""))
                                {
                                    Console.WriteLine(file);
                                    localFileName = Linuxoutputdir + "/" + Regex.Replace(file.Name, "_" + ORDERNUM + @"_\d{8}", "_" + ORDERNUM + "_xxxxxxxx").Replace(".info", "_info");
                                    localFileName = localFileName.Replace(TempReportPrintFileName, "xxxxxxxx");

                                    remoteFileName = linuxDIR + file.Name;
                                    streamFile = File.OpenWrite(localFileName);
                                    sshFTP.DownloadFile(file.FullName, streamFile);
                                    streamFile.Close();

                                    linuxFileCount++;
                                }


                            }
                        }

                    }

                }
            }


            return linuxFileCount;
        }


        //This method is checking all the post urr jobs are completed before ftping the files
        [When(@"I Submit Post URR Job")]
        public void SubmitPostURRJob(Table table)
        {
            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            }

            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                SubmitPostURRJobVMS(table);
            }
            else
            {
                SubmitPostURRJobLinux(table);
            }

        }

        //This method is checking all the post urr jobs are completed before ftping the files
        [Then(@"I Submit Post URR Job VMS")]
        [When(@"I Submit Post URR Job VMS")]
        public void SubmitPostURRJobVMS(Table table)
        {
            currentCOY = table.Rows[0]["COY"].ToLower();
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                var jobStatus1 = "Executing";
                var jobStatus2 = "Pending";
                var PassCriteria = "";
                sshClient.Connect();
                var cmd = sshClient.RunCommand("@SCRIP$COM:RETURN_ACTIVE_JOBS \""+currentCOY+"\"");
                var output = cmd.Result;

                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && output.Contains(jobStatus1) && output.Contains(jobStatus2))
                {
                    cmd = sshClient.RunCommand("@SCRIP$COM:RETURN_ACTIVE_JOBS \""+currentCOY+"\"");
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(PassCriteria))
                {
                    throw new Exception("Post URR job Timeout" + output);
                }


                sshClient.Connect();
                cmd = sshClient.RunCommand("submit scrip$com:auto_wrapup_urr /priority=0 /queue=lnx6");
                output = cmd.Result;

                ReportJobNumber = output;
                int start = ReportJobNumber.IndexOf("entry ") + 6;
                int end = ReportJobNumber.IndexOf(")", start);
                ReportJobNumber = ReportJobNumber.Substring(start, end - start);


                sw.Start();
                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                {
                    cmd = sshClient.RunCommand("sh ent " + ReportJobNumber);
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();
                if (!output.Contains(table.Rows[0]["PassCriteria"]))
                {
                    throw new Exception("Post URR job Timeout or failed criteria was found" + output);
                }
            }
        }


        //This method is checking all the post urr jobs are completed before ftping the files
        [Then(@"I Submit Post URR Job Linux")]
        [When(@"I Submit Post URR Job Linux")]
        public void SubmitPostURRJobLinux(Table table)
        {
            table.Rows[0]["FailCriteria"] = "EXIT";
            table.Rows[0]["PassCriteria"] = "DONE";

            currentCOY = table.Rows[0]["COY"].ToLower();

            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            host = System.Environment.GetEnvironmentVariable("vmhost");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();

                var cmd = sshClient.RunCommand("job show --company "+ currentCOY+" --status \"HOLD, RUN\"");
                var output = cmd.Result;
                var jobStatus1 = "HOLD";
                var jobStatus2 = "RUN";
                var PassCriteria = "";

                Stopwatch sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && output.Contains(jobStatus1) && output.Contains(jobStatus2))
                {
                    cmd = sshClient.RunCommand("job show --company " + currentCOY + " --status \"HOLD, RUN\"");
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(PassCriteria))
                {
                    throw new Exception("Post URR job Timeout" + output);
                }
                sshClient.Connect();


                cmd = sshClient.RunCommand("job submit ${SCRIPROOT}/scripts/auto_wrapup_urr.sh \"" +currentCOY+"\" \""+ ReportTime+"\" --queue urr_ser_exe1 --priority 0 --jobname auto_wrapup_urr_" + currentCOY);
                output = cmd.Result;

                ReportJobNumber = output;
                int start = ReportJobNumber.IndexOf("<")+1;
                int end = ReportJobNumber.IndexOf(">", start);
                ReportJobNumber = ReportJobNumber.Substring(start, end - start);


                //Stopwatch sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                {
                    cmd = sshClient.RunCommand("job show  " + ReportJobNumber);
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(table.Rows[0]["PassCriteria"]))
                {
                    throw new Exception("Post URR job Timeout or failed criteria was found" + output);
                }
            }


        }

        [Then(@"I check Active jobs")]
        [When(@"I check Active jobs")]
        public void CheckActiveJobs(Table table)
        {
            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = System.Environment.GetEnvironmentVariable("VMHOST");
            }

            if (WinFormsTestSteps.Environment == null)
            {
                WinFormsTestSteps.Environment = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                CheckActiveJobsVMS(table);
            }
            else
            {
                CheckActiveJobsLinux(table);
            }
        }

        [Then(@"I check Active jobs VMS")]
        [When(@"I check Active jobs VMS")]
        public void CheckActiveJobsVMS(Table table)
        {
            currentCOY = table.Rows[0]["COY"].ToLower();
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                var jobStatus1 = "Executing";
                var jobStatus2 = "Pending";
                var PassCriteria = "";
                sshClient.Connect();
                var cmd = sshClient.RunCommand("@SCRIP$COM:RETURN_ACTIVE_JOBS \"" + currentCOY + "\"");
                var output = cmd.Result;

                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && output.Contains(jobStatus1) && output.Contains(jobStatus2))
                {
                    cmd = sshClient.RunCommand("@SCRIP$COM:RETURN_ACTIVE_JOBS \"" + currentCOY + "\"");
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(PassCriteria))
                {
                    throw new Exception("Active Jobs Timeout" + output);
                }

            }
        }

        [Then(@"I check Active jobs Linux")]
        [When(@"I check Active jobs Linux")]
        public void CheckActiveJobsLinux(Table table)
        {
            table.Rows[0]["FailCriteria"] = "EXIT";
            table.Rows[0]["PassCriteria"] = "DONE";

            currentCOY = table.Rows[0]["COY"].ToLower();

            var host = System.Environment.GetEnvironmentVariable("VMHOST");
            host = System.Environment.GetEnvironmentVariable("vmhost");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();

                var cmd = sshClient.RunCommand("job show --company " + currentCOY + " --status \"HOLD, RUN\"");
                var output = cmd.Result;
                var jobStatus1 = "HOLD";
                var jobStatus2 = "RUN";
                var PassCriteria = "";

                Stopwatch sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && output.Contains(jobStatus1) && output.Contains(jobStatus2))
                {
                    cmd = sshClient.RunCommand("job show --company " + currentCOY + " --status \"HOLD, RUN\"");
                    output = cmd.Result;
                    System.Threading.Thread.Sleep(100);
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(PassCriteria))
                {
                    throw new Exception("Active Jobs Timeout" + output);
                }
            }
        }
    }
}