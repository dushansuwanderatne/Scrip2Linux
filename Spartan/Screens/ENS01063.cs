using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01063

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01063", "FormName");
		//Fields
        public static WinFormsField ExtraDetailLines = new WinFormsField("EXTRA-DETAIL-LINES", "ExtraDetailLines");
    }
}
