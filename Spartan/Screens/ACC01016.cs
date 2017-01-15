using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01016

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01016", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField ExtractFilename = new WinFormsField("EXTRACT-FILENAME", "ExtractFilename");
    }
}
