using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10038

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10038", "FormName");
		//Fields


        public static WinFormsField AnnualValues = new WinFormsField("ANNUAL-VALUES", "AnnualValues");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
