using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCGH0400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCGH0400", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCodeLineOne = new WinFormsField("CLASS-CODE-LINE-ONE", "ClassCodeLineOne");
        public static WinFormsField ClassCodeLineTwo = new WinFormsField("CLASS-CODE-LINE-TWO", "ClassCodeLineTwo");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField XtractFilename = new WinFormsField("XTRACT-FILENAME", "XtractFilename");
    }
}
