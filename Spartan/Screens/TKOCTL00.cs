using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKOCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKOCTL00", "FormName");
		//Fields


        public static WinFormsField TkoctlKey0 = new WinFormsField("TKOCTL-KEY0", "TkoctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
