using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CALCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CALCTL00", "FormName");
		//Fields


        public static WinFormsField CalctlKey0 = new WinFormsField("CALCTL-KEY0", "CalctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
