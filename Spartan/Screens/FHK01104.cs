using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01104", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField NextPayDate = new WinFormsField("NEXT-PAY-DATE", "NextPayDate");
        public static WinFormsField PayATEndOFMonth = new WinFormsField("PAY-AT-END-OF-MONTH", "PayATEndOFMonth");
        public static WinFormsField ONCallInd = new WinFormsField("ON-CALL-IND", "ONCallInd");
        public static WinFormsField ONCallRate = new WinFormsField("ON-CALL-RATE", "ONCallRate");
        public static WinFormsField IncludeMaturityDay = new WinFormsField("INCLUDE-MATURITY-DAY", "IncludeMaturityDay");
        public static WinFormsField IncludeIcfDay = new WinFormsField("INCLUDE-ICF-DAY", "IncludeIcfDay");
        public static WinFormsField IncludeLastPayDay = new WinFormsField("INCLUDE-LAST-PAY-DAY", "IncludeLastPayDay");
        public static WinFormsField IncludeThisPayDay = new WinFormsField("INCLUDE-THIS-PAY-DAY", "IncludeThisPayDay");
        public static WinFormsField LastCertStartRun = new WinFormsField("LAST-CERT-START-RUN", "LastCertStartRun");
        public static WinFormsField LastCertNumberUsed = new WinFormsField("LAST-CERT-NUMBER-USED", "LastCertNumberUsed");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
