using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRXCTL0D

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRXCTL0D", "FormName");
		//Fields


        public static WinFormsField PrxctlKey0 = new WinFormsField("PRXCTL-KEY0", "PrxctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
