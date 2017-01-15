using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17501", "FormName");
		//Fields


        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField StatementFromDate = new WinFormsField("STATEMENT-FROM-DATE", "StatementFromDate");
        public static WinFormsField StatementTODate = new WinFormsField("STATEMENT-TO-DATE", "StatementTODate");
        public static WinFormsField StatementType = new WinFormsField("STATEMENT-TYPE", "StatementType");
        public static WinFormsField SelectionStartDate = new WinFormsField("SELECTION-START-DATE", "SelectionStartDate");
        public static WinFormsField SelectFinancialYR = new WinFormsField("SELECT-FINANCIAL-YR", "SelectFinancialYR");
        public static WinFormsField UseInputFileInd = new WinFormsField("USE-INPUT-FILE-IND", "UseInputFileInd");
        public static WinFormsField InputFileName = new WinFormsField("INPUT-FILE-NAME", "InputFileName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
