using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSLT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSLT", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
