using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCMF0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCMF0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField CapitalGain = new WinFormsField("CAPITAL-GAIN", "CapitalGain");
        public static WinFormsField PayCode = new WinFormsField("PAY-CODE", "PayCode");
        public static WinFormsField PayDate = new WinFormsField("PAY-DATE", "PayDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
