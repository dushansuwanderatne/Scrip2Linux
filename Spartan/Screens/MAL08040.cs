using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL08040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL08040", "FormName");
		//Fields


        public static WinFormsField CoyFrom = new WinFormsField("COY-FROM", "CoyFrom");
        public static WinFormsField CoyTO = new WinFormsField("COY-TO", "CoyTO");
    }
}
