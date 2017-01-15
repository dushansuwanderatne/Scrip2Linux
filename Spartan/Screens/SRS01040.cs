using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01040", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Filename1 = new WinFormsField("FILENAME1", "Filename1");
        public static WinFormsField Filename2 = new WinFormsField("FILENAME2", "Filename2");
    }
}
