using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using WinSCP;

namespace SCRIPAU.Automation.Subtests
{
    internal class Terminator
    {
        public static int Guts()
        {
            try
            {
                // Setup session options
                SessionOptions sessionOptions = new SessionOptions
                {
                    //Password = ;
                    //Environment = System.Environment.GetEnvironmentVariable("VMHOST");
                    Protocol = Protocol.Sftp,
                    HostName = System.Environment.GetEnvironmentVariable("VMHOST"),
                    UserName = ConfigurationManager.AppSettings["WinformsUsername"],
                    Password = ConfigurationManager.AppSettings["WinformsPassword"],
                    GiveUpSecurityAndAcceptAnySshHostKey = true
                };

                using (Session session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    string stamp = DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    string fileName = "export_" + stamp + ".txt";
                    string remotePath = "DATADISK65:[COMPANY.QBE_AUTO.PRN]" + fileName;
                    string localPath = ConfigurationManager.AppSettings["LocalDownloadFolder"] + fileName;

                    // Manual "remote to local" synchronization.

                    // You can achieve the same using:
                    // session.SynchronizeDirectories(
                    //     SynchronizationMode.Local, localPath, remotePath, false, false, SynchronizationCriteria.Time,
                    //     new TransferOptions { FileMask = fileName }).Check();
                    if (session.FileExists(remotePath))
                    {
                        bool download;
                        if (!File.Exists(localPath))
                        {
                            Console.WriteLine("File {0} exists, local backup {1} does not", remotePath, localPath);
                            download = true;
                        }
                        else
                        {
                            DateTime remoteWriteTime = session.GetFileInfo(remotePath).LastWriteTime;
                            DateTime localWriteTime = File.GetLastWriteTime(localPath);

                            if (remoteWriteTime > localWriteTime)
                            {
                                Console.WriteLine(
                                    "File {0} as well as local backup {1} exist, " +
                                    "but remote file is newer ({2}) than local backup ({3})",
                                    remotePath, localPath, remoteWriteTime, localWriteTime);
                                download = true;
                            }
                            else
                            {
                                Console.WriteLine(
                                    "File {0} as well as local backup {1} exist, " +
                                    "but remote file is not newer ({2}) than local backup ({3})",
                                    remotePath, localPath, remoteWriteTime, localWriteTime);
                                download = false;
                            }
                        }

                        if (download)
                        {
                            // Download the file and throw on any error
                            session.GetFiles(remotePath, localPath).Check();

                            Console.WriteLine("Download to backup done.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("File {0} does not exist yet", remotePath);
                    }
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                return 1;
            }
        }
    }
}