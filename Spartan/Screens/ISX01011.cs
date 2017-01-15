using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01011", "FormName");
		//Fields


        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField ExdomIssue = new WinFormsField("EXDOM-ISSUE", "ExdomIssue");
        public static WinFormsField ExdomIssueNum = new WinFormsField("EXDOM-ISSUE-NUM", "ExdomIssueNum");
        public static WinFormsField XtrFilname = new WinFormsField("XTR-FILNAME", "XtrFilname");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField CalcProgName = new WinFormsField("CALC-PROG-NAME", "CalcProgName");
        public static WinFormsField BuildRequired = new WinFormsField("BUILD-REQUIRED", "BuildRequired");
        public static WinFormsField CNEntNumbOpt = new WinFormsField("CN-ENT-NUMB-OPT", "CNEntNumbOpt");
        public static WinFormsField IssueType = new WinFormsField("ISSUE-TYPE", "IssueType");
        public static WinFormsField RenouncableIssue = new WinFormsField("RENOUNCABLE-ISSUE", "RenouncableIssue");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField PriceKnown = new WinFormsField("PRICE-KNOWN", "PriceKnown");
        public static WinFormsField EssReconstructionInd = new WinFormsField("ESS-RECONSTRUCTION-IND", "EssReconstructionInd");
        public static WinFormsField EssExclTsteeAcct = new WinFormsField("ESS-EXCL-TSTEE-ACCT", "EssExclTsteeAcct");
        public static WinFormsField RemittanceProcInd = new WinFormsField("REMITTANCE-PROC-IND", "RemittanceProcInd");
        public static WinFormsField NumberOffers = new WinFormsField("NUMBER-OFFERS", "NumberOffers");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
