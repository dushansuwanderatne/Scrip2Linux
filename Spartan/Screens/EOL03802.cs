using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL03802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL03802", "FormName");
		//Fields


        public static WinFormsField WarningText1 = new WinFormsField("WARNING-TEXT-1", "WarningText1");
        public static WinFormsField WarningText2 = new WinFormsField("WARNING-TEXT-2", "WarningText2");
        public static WinFormsField WarningText3 = new WinFormsField("WARNING-TEXT-3", "WarningText3");
        public static WinFormsField WarningText4 = new WinFormsField("WARNING-TEXT-4", "WarningText4");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
