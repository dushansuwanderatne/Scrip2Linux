using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00116

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00116", "FormName");
		//Fields
        public static WinFormsField AppropDesc = new WinFormsField("APPROP-DESC", "AppropDesc");
        public static WinFormsField AppropDate = new WinFormsField("APPROP-DATE", "AppropDate");
    }
}
