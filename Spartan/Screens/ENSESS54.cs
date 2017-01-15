using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS54

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS54", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField DsptchRunsOnlyInd = new WinFormsField("DSPTCH-RUNS-ONLY-IND", "DsptchRunsOnlyInd");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
