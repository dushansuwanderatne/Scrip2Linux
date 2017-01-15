using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS14000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS14000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField TakeoverInd = new WinFormsField("TAKEOVER-IND", "TakeoverInd");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField TkoNum = new WinFormsField("TKO-NUM", "TkoNum");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField CalcMethod = new WinFormsField("CALC-METHOD", "CalcMethod");
        public static WinFormsField TypeSecurity = new WinFormsField("TYPE-SECURITY", "TypeSecurity");
        public static WinFormsField ExtractName = new WinFormsField("EXTRACT-NAME", "ExtractName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
