using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FSTCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FSTCTL01", "FormName");
		//Fields


        public static WinFormsField FstctlKey0 = new WinFormsField("FSTCTL-KEY0", "FstctlKey0");
        public static WinFormsField FastStatementLine = new WinFormsField("FAST-STATEMENT-LINE", "FastStatementLine");
        public static WinFormsField IssuerDisclaimerLine = new WinFormsField("ISSUER-DISCLAIMER-LINE", "IssuerDisclaimerLine");
        public static WinFormsField NumberStatementRuns = new WinFormsField("NUMBER-STATEMENT-RUNS", "NumberStatementRuns");
        public static WinFormsField StatementRunArray1 = new WinFormsField("STATEMENT-RUN-ARRAY1", "StatementRunArray1");
        public static WinFormsField StatementRunArray2 = new WinFormsField("STATEMENT-RUN-ARRAY2", "StatementRunArray2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
