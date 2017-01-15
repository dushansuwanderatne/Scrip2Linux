using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01086

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01086", "FormName");
		//Fields
        public static WinFormsField Xtract = new WinFormsField("XTRACT", "Xtract");
        public static WinFormsField XtractSuffix = new WinFormsField("XTRACT-SUFFIX", "XtractSuffix");
    }
}
