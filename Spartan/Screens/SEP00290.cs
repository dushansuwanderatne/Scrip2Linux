using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00290

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00290", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PrintFilename = new WinFormsField("PRINT-FILENAME", "PrintFilename");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
