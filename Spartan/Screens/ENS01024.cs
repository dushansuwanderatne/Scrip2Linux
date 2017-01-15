using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01024", "FormName");
		//Fields
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Method = new WinFormsField("METHOD", "Method");
    }
}
