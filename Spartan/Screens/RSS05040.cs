using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS05040", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField StatementRequest = new WinFormsField("STATEMENT-REQUEST", "StatementRequest");
        public static WinFormsField NilStatements = new WinFormsField("NIL-STATEMENTS", "NilStatements");
        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField TransactionType = new WinFormsField("TRANSACTION-TYPE", "TransactionType");
        public static WinFormsField TransactionTypeCodes = new WinFormsField("TRANSACTION-TYPE-CODES", "TransactionTypeCodes");
        public static WinFormsField NewTOPrint = new WinFormsField("NEW-TO-PRINT", "NewTOPrint");
        public static WinFormsField RunRangeFrom = new WinFormsField("RUN-RANGE-FROM", "RunRangeFrom");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField ClassGroupX = new WinFormsField("CLASS-GROUP-X", "ClassGroupX");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
