using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELP0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELP0102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField Classes = new WinFormsField("CLASSES", "Classes");
        public static WinFormsField TransCode = new WinFormsField("TRANS-CODE", "TransCode");
        public static WinFormsField PrintDivision = new WinFormsField("PRINT-DIVISION", "PrintDivision");
        public static WinFormsField DivisionFlag1 = new WinFormsField("DIVISION-FLAG1", "DivisionFlag1");
        public static WinFormsField DivisionFlag2 = new WinFormsField("DIVISION-FLAG2", "DivisionFlag2");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField MajorBreakup = new WinFormsField("MAJOR-BREAKUP", "MajorBreakup");
        public static WinFormsField SecndBreakup = new WinFormsField("SECND-BREAKUP", "SecndBreakup");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
