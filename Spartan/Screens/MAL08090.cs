using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL08090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL08090", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
    }
}
