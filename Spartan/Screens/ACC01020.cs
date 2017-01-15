using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01020", "FormName");
		//Fields


        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
