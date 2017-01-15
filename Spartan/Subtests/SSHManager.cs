using System;
using System.Configuration;
using System.IO;
using Renci.SshNet;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class SSHManager
    {
        private SshClient client;
        private ShellStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private String[] resultArray;
        public String strTestCaseFailReason;
        private string host;
        private string username;
        private string pwd;
        public Boolean failCriteriaMet;
        public Boolean passCriteriaMet;
        public string jobNumber;

        public SSHManager()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
        }
        public WinFormsTestSteps WinFormsTestSteps { get; set; }

        /// <summary>
        /// Sends a command to the OpenVMS input stream
        /// </summary>
        /// <param name="command"></param>
        public void SendShellCommand(string command, string host, List<String> passCriteria, List<String> failCriteria)
        {
            host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }

            var writer = new StreamWriter(stream);
            try
            {
                //issuedCommand = command;
                stream.Flush();
                writer.AutoFlush = true;
                if (host.ToLower() == "csshyc")
                    writer.WriteLine(command);
                else
                    writer.Write(command + "\r");
            }
            catch (Exception exm)
            {
                Console.WriteLine(exm.Message);

            }

            try
            {
                //List<String> passCriteria;
                //List<String> failCriteria;
                // passCriteria = new List<String>();
                // failCriteria = new List<String>();

                //passCriteria.Add(passCriteria);
                //failCriteria.Add(failCriteria);

                if (ValidateShellResults(passCriteria))
                {
                    Console.WriteLine("Pass Criteria met");
                }
                else
                {
                    throw new Exception("could not find passCriteria");
                }

            }
            catch
            {
                throw new Exception("could not find passCriteria");
            }



        }

        /// <summary>
        /// Validates the output from the OpenVMS output stream using specified pass criteria
        /// </summary>
        /// <param name="passCriteria"></param>
        /// <param name="timeout"></param>
        public Boolean ValidateShellResults(List<string> passCriteria, List<String> failCriteria = null)
        {
            TimeSpan timeout = new TimeSpan(0, 0, 20); // 20 seconds timeout

            int numOfPassCriteriaMet = 0;
            int numOfPassCriteriaExpected = 1;
            passCriteriaMet = false;
            failCriteriaMet = false;
            string line = "";
            String[] output;
            List<string> passCriteriaResults = new List<string>();

            StopClock myStopClock = new StopClock();

            try
            {
                myStopClock.Start();
                line = "";

                while (myStopClock.CheckTime(timeout) && passCriteriaMet == false && failCriteriaMet == false)
                {
                    Thread.Sleep(2000);
                    string read = reader.ReadToEnd();

                    line = line + read;
                    output = line.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    resultArray = output;

                    foreach (string value in passCriteria)
                    {
                        foreach (string outputValue in output)
                        {
                            if (outputValue.IndexOf(value, StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                numOfPassCriteriaMet++;
                                passCriteriaResults.Add(value);

                                //this is to get the job number from a release job 
                                // command send from the SendShellCommand
                                if (value == "started" || value == "queue default")
                                    jobNumber = outputValue;
                            }
                            if (numOfPassCriteriaMet == numOfPassCriteriaExpected)
                            {
                                passCriteriaMet = true;
                            }
                        }
                    }

                    if (failCriteria != null)
                    {
                        foreach (string value in failCriteria)
                        {
                            foreach (string outputValue in output)
                            {
                                if (outputValue.IndexOf(value, StringComparison.OrdinalIgnoreCase) > -1)
                                {
                                    failCriteriaMet = true;
                                }
                            }
                        } // end of failCriteria1=null
                    } // end of foreach(string value in passCriteria)

                    int passCriteriaCount = passCriteria.Count;
                    //int failCriteriaCount = failCriteria.Count;

                    if (passCriteriaCount == 0)
                    {
                        passCriteriaMet = true;
                        Console.WriteLine("passCriteria Count is 0");
                    }


                    System.Threading.Thread.Sleep(50);
                }

                stream.Flush();

                if (passCriteriaMet)
                {
                    return true; // pass criteria met, so successful
                }
                else if (failCriteriaMet == true)
                {
                    return false; // fail criteria met, so unsuccessful
                }
                else
                {
                    Console.WriteLine(resultArray);
                    return false; // timeout, so unsuccessful
                }
            }
            catch (Exception)
            {
                throw new Exception("ERROR> AutomationSystem> Could not verify the pass criteria");
            }
        }


        //URR Capture Rollback
        public void Connect(ref String strTestCaseFailReason)
        {

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
            try
            {
                PasswordAuthenticationMethod authMethod = new PasswordAuthenticationMethod(username, pwd);
                ConnectionInfo connectionInfo = new ConnectionInfo(host, username, authMethod);
                client = new SshClient(connectionInfo);
                client.Connect();

                if (client.IsConnected)
                {
                    stream = client.CreateShellStream("vt100", 150, 51, 180, 147, 1024);

                    reader = new StreamReader(stream);
                    writer = new StreamWriter(stream);
                    bool actionComplete = false;
                    String[] output;

                    writer.AutoFlush = true;

                    string line = "";

                    TimeSpan timeout = new TimeSpan(0, 0, 60); //60 second timeout

                    StopClock myStopClock = new StopClock();
                    myStopClock.Start();

                    while (myStopClock.CheckTime(timeout) & actionComplete == false)
                    {
                        string read = reader.ReadToEnd();

                        line = line + read;
                        output = line.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        resultArray = output;

                        foreach (String value in output)
                        {
                            if (value.IndexOf(@"Search Rules", StringComparison.OrdinalIgnoreCase) > -1 ||
                                value.IndexOf(username + "@", StringComparison.OrdinalIgnoreCase) > -1)
                            {
                                actionComplete = true;
                                break;
                            }
                        }
                        System.Threading.Thread.Sleep(50);
                    }
                }
                else
                {
                    throw new Exception("ERROR> AutomationSystem> Could not create an SSH session to the backend.");
                }
            }
            catch (Exception)
            {
                throw new Exception("ERROR> AutomationSystem> Could not create an SSH session to the backend.");
            }

        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void WaitForJobcompleteVMS(Table table)
        {
            //jobNumber = "Job ALT1_CALC_QBE_AUTO(queue ICR1, entry 5646) started on ICR1";
            //jobNumber = "Job ALT1_CALC_QBE_AUTO(queue ICR1, entry 1001255) started on ICR1";

            int jobIndex2 = jobNumber.IndexOf(")");
            jobNumber = jobNumber.Substring(0, jobIndex2);
            int jobIndex1 = jobNumber.IndexOf("entry");
            jobNumber = jobNumber.Substring(jobIndex1 + 6);



            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                var cmd = sshClient.RunCommand("sh ent " + jobNumber);
                var output = cmd.Result;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                {
                    cmd = sshClient.RunCommand("sh ent " + jobNumber);
                    output = cmd.Result;
                }
                sw.Stop();
                sshClient.Disconnect();
                if (!output.Contains(table.Rows[0]["PassCriteria"]))
                {
                    throw new Exception("Timeout or failed criteria was found" + output);
                }


            }
        }


        public void WaitForJobcompleteLinux(Table table)
        {

            host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            
            //jobNumber = "Job <383> 'alt1_calc_qbe_auto' (queue default)";

            int start = jobNumber.IndexOf("<") + 1;
            int end = jobNumber.IndexOf(">", start);
            jobNumber = jobNumber.Substring(start, end - start);


            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                var cmd = sshClient.RunCommand("job show  " + jobNumber);
                var output = cmd.Result;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["timeout"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteriaLinux"]) && !output.Contains(table.Rows[0]["FailCriteriaLinux"]))
                {
                    cmd = sshClient.RunCommand("job show  " + jobNumber);
                    output = cmd.Result;
                }
                sw.Stop();
                sshClient.Disconnect();

                if (!output.Contains(table.Rows[0]["PassCriteriaLinux"]))
                {
                    throw new Exception("Timeout or failed criteria was found" + output);
                }
            }

        }


    }
}