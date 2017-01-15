using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SWFA0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SWFA0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ClgCon = new WinFormsField("CLG-CON", "ClgCon");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField WeekMonthRep = new WinFormsField("WEEK-MONTH-REP", "WeekMonthRep");
        public static WinFormsField IncEntrepot = new WinFormsField("INC-ENTREPOT", "IncEntrepot");
        public static WinFormsField PrintGrpDetails = new WinFormsField("PRINT-GRP-DETAILS", "PrintGrpDetails");
        public static WinFormsField MovementLevel = new WinFormsField("MOVEMENT-LEVEL", "MovementLevel");
        public static WinFormsField RunStart = new WinFormsField("RUN-START", "RunStart");
        public static WinFormsField CompareRun = new WinFormsField("COMPARE-RUN", "CompareRun");
        public static WinFormsField RunPrev12 = new WinFormsField("RUN-PREV-12", "RunPrev12");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
