using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP9101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP9101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField OldCentreCodeCol1 = new WinFormsField("OLD-CENTRE-CODE-COL1", "OldCentreCodeCol1");
        public static WinFormsField NewCentreCodeCol1 = new WinFormsField("NEW-CENTRE-CODE-COL1", "NewCentreCodeCol1");
        public static WinFormsField OldCentreCodeCol2 = new WinFormsField("OLD-CENTRE-CODE-COL2", "OldCentreCodeCol2");
        public static WinFormsField NewCentreCodeCol2 = new WinFormsField("NEW-CENTRE-CODE-COL2", "NewCentreCodeCol2");
        public static WinFormsField OldCentreCodeCol3 = new WinFormsField("OLD-CENTRE-CODE-COL3", "OldCentreCodeCol3");
        public static WinFormsField NewCentreCodeCol3 = new WinFormsField("NEW-CENTRE-CODE-COL3", "NewCentreCodeCol3");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
