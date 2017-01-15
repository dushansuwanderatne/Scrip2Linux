using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDFM0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDFM0102", "FormName");
		//Fields


        public static WinFormsField ExtractFilename = new WinFormsField("EXTRACT-FILENAME", "ExtractFilename");
        public static WinFormsField NilStatements = new WinFormsField("NIL-STATEMENTS", "NilStatements");
        public static WinFormsField TransTypeInd = new WinFormsField("TRANS-TYPE-IND", "TransTypeInd");
        public static WinFormsField TransTypeCode = new WinFormsField("TRANS-TYPE-CODE", "TransTypeCode");
        public static WinFormsField DateRangeFrom = new WinFormsField("DATE-RANGE-FROM", "DateRangeFrom");
        public static WinFormsField DateRangeTO = new WinFormsField("DATE-RANGE-TO", "DateRangeTO");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
