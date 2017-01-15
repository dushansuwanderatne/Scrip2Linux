using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00414

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00414", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField VoteRangeRes = new WinFormsField("VOTE-RANGE-RES", "VoteRangeRes");
        public static WinFormsField VoteFrom = new WinFormsField("VOTE-FROM", "VoteFrom");
        public static WinFormsField VoteTO = new WinFormsField("VOTE-TO", "VoteTO");
        public static WinFormsField FromRun = new WinFormsField("FROM-RUN", "FromRun");
        public static WinFormsField TORun = new WinFormsField("TO-RUN", "TORun");
        public static WinFormsField RevokedHolderInd = new WinFormsField("REVOKED-HOLDER-IND", "RevokedHolderInd");
        public static WinFormsField GenerateCsvInd = new WinFormsField("GENERATE-CSV-IND", "GenerateCsvInd");
        public static WinFormsField XtractName = new WinFormsField("XTRACT-NAME", "XtractName");
        public static WinFormsField UserNumber = new WinFormsField("USER-NUMBER", "UserNumber");
        public static WinFormsField NameAddressTOPrint = new WinFormsField("NAME-ADDRESS-TO-PRINT", "NameAddressTOPrint");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
