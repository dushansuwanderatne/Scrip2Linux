using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSVALDT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSVALDT", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DaysDiff = new WinFormsField("DAYS-DIFF", "DaysDiff");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
