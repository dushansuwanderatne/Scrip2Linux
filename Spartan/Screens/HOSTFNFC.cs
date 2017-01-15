using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFNFC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFNFC", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField FileGroupDesc = new WinFormsField("FILE-GROUP-DESC", "FileGroupDesc");
        public static WinFormsField FtpDestCode = new WinFormsField("FTP-DEST-CODE", "FtpDestCode");
        public static WinFormsField FtpName = new WinFormsField("FTP-NAME", "FtpName");
        public static WinFormsField FtpFrom = new WinFormsField("FTP-FROM", "FtpFrom");
        public static WinFormsField FtpExportDirectory = new WinFormsField("FTP-EXPORT-DIRECTORY", "FtpExportDirectory");
        public static WinFormsField FtpZipFileInd = new WinFormsField("FTP-ZIP-FILE-IND", "FtpZipFileInd");
        public static WinFormsField DssIndexedInd = new WinFormsField("DSS-INDEXED-IND", "DssIndexedInd");
        public static WinFormsField ReqName = new WinFormsField("REQ-NAME", "ReqName");
        public static WinFormsField FtpFileName = new WinFormsField("FTP-FILE-NAME", "FtpFileName");
        public static WinFormsField DestName = new WinFormsField("DEST-NAME", "DestName");
        public static WinFormsField RecordCount = new WinFormsField("RECORD-COUNT", "RecordCount");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
