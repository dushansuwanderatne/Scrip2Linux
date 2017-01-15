using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS28

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS28", "FormName");
		//Fields
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField NumberMths = new WinFormsField("NUMBER-MTHS", "NumberMths");
        public static WinFormsField NumberDays = new WinFormsField("NUMBER-DAYS", "NumberDays");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
