using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0202", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DateConfirm = new WinFormsField("DATE-CONFIRM", "DateConfirm");
    }
}