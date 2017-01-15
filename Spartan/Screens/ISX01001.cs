using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01001", "FormName");
		//Fields


        public static WinFormsField IsxctlNum = new WinFormsField("ISXCTL-NUM", "IsxctlNum");
        public static WinFormsField IssueType = new WinFormsField("ISSUE-TYPE", "IssueType");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField EntCalcStatus = new WinFormsField("ENT-CALC-STATUS", "EntCalcStatus");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitFwd = new WinFormsField("LIT-FWD", "LitFwd");
        public static WinFormsField LitBwd = new WinFormsField("LIT-BWD", "LitBwd");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
