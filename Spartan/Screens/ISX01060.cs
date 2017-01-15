using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01060", "FormName");
		//Fields


        public static WinFormsField IssueScrip = new WinFormsField("ISSUE-SCRIP", "IssueScrip");
        public static WinFormsField ScripSeq = new WinFormsField("SCRIP-SEQ", "ScripSeq");
        public static WinFormsField TranTypeIndicator = new WinFormsField("TRAN-TYPE-INDICATOR", "TranTypeIndicator");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField ScripComments = new WinFormsField("SCRIP-COMMENTS", "ScripComments");
        public static WinFormsField ExcludedCountry = new WinFormsField("EXCLUDED-COUNTRY", "ExcludedCountry");
        public static WinFormsField Excdcd01 = new WinFormsField("EXCDCD01", "Excdcd01");
        public static WinFormsField Excdcd02 = new WinFormsField("EXCDCD02", "Excdcd02");
        public static WinFormsField Excdcd03 = new WinFormsField("EXCDCD03", "Excdcd03");
        public static WinFormsField Excdcd04 = new WinFormsField("EXCDCD04", "Excdcd04");
        public static WinFormsField Excdcd05 = new WinFormsField("EXCDCD05", "Excdcd05");
        public static WinFormsField Excdcd06 = new WinFormsField("EXCDCD06", "Excdcd06");
        public static WinFormsField Excdcd07 = new WinFormsField("EXCDCD07", "Excdcd07");
        public static WinFormsField Excdcd08 = new WinFormsField("EXCDCD08", "Excdcd08");
        public static WinFormsField Excdcd09 = new WinFormsField("EXCDCD09", "Excdcd09");
        public static WinFormsField Excdcd10 = new WinFormsField("EXCDCD10", "Excdcd10");
        public static WinFormsField ExcdcdIssue = new WinFormsField("EXCDCD-ISSUE", "ExcdcdIssue");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
