using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG0200X

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG0200X", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Line1 = new WinFormsField("LINE1", "Line1");
        public static WinFormsField Line2 = new WinFormsField("LINE2", "Line2");
        public static WinFormsField Line3 = new WinFormsField("LINE3", "Line3");
        public static WinFormsField Line4 = new WinFormsField("LINE4", "Line4");
    }
}
