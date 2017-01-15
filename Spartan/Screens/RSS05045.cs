using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS05045", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField LastStmtRunOutput = new WinFormsField("LAST-STMT-RUN-OUTPUT", "LastStmtRunOutput");
        public static WinFormsField LastStmtRunInput = new WinFormsField("LAST-STMT-RUN-INPUT", "LastStmtRunInput");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
    }
}
