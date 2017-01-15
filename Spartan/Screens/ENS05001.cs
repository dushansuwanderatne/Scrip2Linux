using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS05001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS05001", "FormName");
		//Fields


        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField ReportBYReg = new WinFormsField("REPORT-BY-REG", "ReportBYReg");
        public static WinFormsField Class1 = new WinFormsField("CLASS-1", "Class1");
        public static WinFormsField Class2 = new WinFormsField("CLASS-2", "Class2");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
