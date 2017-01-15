using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PLNCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PLNCTL00", "FormName");
		//Fields


        public static WinFormsField PlnctlKey0 = new WinFormsField("PLNCTL-KEY0", "PlnctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
