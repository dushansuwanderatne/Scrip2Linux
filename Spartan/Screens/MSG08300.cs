using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08300", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField SecurityNameKey = new WinFormsField("SECURITY-NAME-KEY", "SecurityNameKey");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
    }
}
