using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04802", "FormName");
		//Fields


        public static WinFormsField FtpDestCode = new WinFormsField("FTP-DEST-CODE", "FtpDestCode");
        public static WinFormsField FtpName = new WinFormsField("FTP-NAME", "FtpName");
        public static WinFormsField FtpExportDirectory = new WinFormsField("FTP-EXPORT-DIRECTORY", "FtpExportDirectory");
        public static WinFormsField FtpAction = new WinFormsField("FTP-ACTION", "FtpAction");
        public static WinFormsField FtpZipFileInd = new WinFormsField("FTP-ZIP-FILE-IND", "FtpZipFileInd");
        public static WinFormsField SpecialProcessInd = new WinFormsField("SPECIAL-PROCESS-IND", "SpecialProcessInd");
        public static WinFormsField DssIndexedInd = new WinFormsField("DSS-INDEXED-IND", "DssIndexedInd");
        public static WinFormsField SpecialDcl = new WinFormsField("SPECIAL-DCL", "SpecialDcl");
        public static WinFormsField FtpCurrentInd = new WinFormsField("FTP-CURRENT-IND", "FtpCurrentInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
