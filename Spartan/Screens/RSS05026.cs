using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05026

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS05026", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
    }
}
