using System;
using System.Diagnostics;
using Renci.SshNet;
using TechTalk.SpecFlow;

namespace VMSTestSteps
{
    [Binding]
    public class VMSTestSteps
    {
        [Given(@"I have connected to VMS and Restore Company")]
        public void ConnectedToVMSAndRestoreCompany(Table table)
        {
            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    System.Threading.Thread.Sleep(5000);
                    //Command to run the companyresroe DCL
                    var cmd = sshClient.RunCommand("sub_nab2_au");
                    var output = cmd.Result;

                    //eg: output = "Job REFRESH_NAB2_AU (queue LNX1, entry 5442) started on LNX1";
                    int entryIndex = output.IndexOf("entry ");
                    int closingBracketIndex = output.IndexOf(")", entryIndex);
                    int entryNumberIndex = entryIndex + 6;
                    string entryNumber = output.Substring(entryNumberIndex, closingBracketIndex - entryNumberIndex);

                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    while (sw.ElapsedMilliseconds <= Int32.Parse(table.Rows[0]["TimeOut"]) * 1000 && !output.Contains(table.Rows[0]["PassCriteria"]) && !output.Contains(table.Rows[0]["FailCriteria"]))
                    {
                        cmd = sshClient.RunCommand("show ent " + entryNumber);
                        output = cmd.Result;
                        System.Threading.Thread.Sleep(5000);
                    }
                    sw.Stop();

                    if (!output.Contains(table.Rows[0]["PassCriteria"]))
                    {
                        throw new Exception("Company Refresh Job Failed:   " + output);
                    }
                }
            }
        }
    }
}