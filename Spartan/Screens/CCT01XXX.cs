using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01XXX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01XXX", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
