using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField CoyCodeFrom = new WinFormsField("COY-CODE-FROM", "CoyCodeFrom");
        public static WinFormsField CoyCodeTO = new WinFormsField("COY-CODE-TO", "CoyCodeTO");
    }
}
