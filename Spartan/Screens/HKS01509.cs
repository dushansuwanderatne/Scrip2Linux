using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01509

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01509", "FormName");
		//Fields


        public static WinFormsField UrrStatementLine = new WinFormsField("URR-STATEMENT-LINE", "UrrStatementLine");
        public static WinFormsField MthlyStatementLine = new WinFormsField("MTHLY-STATEMENT-LINE", "MthlyStatementLine");
        public static WinFormsField SpecStatProg = new WinFormsField("SPEC-STAT-PROG", "SpecStatProg");
        public static WinFormsField EomstmAutomatedInd = new WinFormsField("EOMSTM-AUTOMATED-IND", "EomstmAutomatedInd");
        public static WinFormsField EomstmUpperLimit = new WinFormsField("EOMSTM-UPPER-LIMIT", "EomstmUpperLimit");
        public static WinFormsField EomstmLowerLimit = new WinFormsField("EOMSTM-LOWER-LIMIT", "EomstmLowerLimit");
        public static WinFormsField StatementRunArray1 = new WinFormsField("STATEMENT-RUN-ARRAY1", "StatementRunArray1");
        public static WinFormsField StatementRunArray2 = new WinFormsField("STATEMENT-RUN-ARRAY2", "StatementRunArray2");
        public static WinFormsField StatementRunArray3 = new WinFormsField("STATEMENT-RUN-ARRAY3", "StatementRunArray3");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
