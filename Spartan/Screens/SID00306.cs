using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00306

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00306", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DocSize = new WinFormsField("DOC-SIZE", "DocSize");
        public static WinFormsField FromFilename = new WinFormsField("FROM-FILENAME", "FromFilename");
        public static WinFormsField TOFilename = new WinFormsField("TO-FILENAME", "TOFilename");
    }
}
