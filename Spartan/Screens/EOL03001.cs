using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL03001", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDesc = new WinFormsField("EVENT-DESC", "EventDesc");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField NameSelection = new WinFormsField("NAME-SELECTION", "NameSelection");
        public static WinFormsField PCSelection = new WinFormsField("PC-SELECTION", "PCSelection");
        public static WinFormsField AddressMatching = new WinFormsField("ADDRESS-MATCHING", "AddressMatching");
        public static WinFormsField AllowBlankAddress = new WinFormsField("ALLOW-BLANK-ADDRESS", "AllowBlankAddress");
        public static WinFormsField UpdateAddrDetails = new WinFormsField("UPDATE-ADDR-DETAILS", "UpdateAddrDetails");
        public static WinFormsField AddressChangeModify = new WinFormsField("ADDRESS-CHANGE-MODIFY", "AddressChangeModify");
        public static WinFormsField UpdateEmpDetails = new WinFormsField("UPDATE-EMP-DETAILS", "UpdateEmpDetails");
        public static WinFormsField AutoGenEmpUnqID = new WinFormsField("AUTO-GEN-EMP-UNQ-ID", "AutoGenEmpUnqID");
        public static WinFormsField ClearEmpUnqID = new WinFormsField("CLEAR-EMP-UNQ-ID", "ClearEmpUnqID");
        public static WinFormsField UpdateContactDetails = new WinFormsField("UPDATE-CONTACT-DETAILS", "UpdateContactDetails");
        public static WinFormsField UploadTfn = new WinFormsField("UPLOAD-TFN", "UploadTfn");
        public static WinFormsField UpdateMandates = new WinFormsField("UPDATE-MANDATES", "UpdateMandates");
        public static WinFormsField BankDetailsChgMod = new WinFormsField("BANK-DETAILS-CHG-MOD", "BankDetailsChgMod");
        public static WinFormsField RunTrnedt = new WinFormsField("RUN-TRNEDT", "RunTrnedt");
        public static WinFormsField ReportFullTotals = new WinFormsField("REPORT-FULL-TOTALS", "ReportFullTotals");
        public static WinFormsField AutoFtpReportsInd = new WinFormsField("AUTO-FTP-REPORTS-IND", "AutoFtpReportsInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
