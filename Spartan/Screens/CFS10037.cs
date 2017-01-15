using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10037

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10037", "FormName");
		//Fields


        public static WinFormsField Title = new WinFormsField("TITLE", "Title");
        public static WinFormsField Parameter = new WinFormsField("PARAMETER", "Parameter");
    }
}
