using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TXSCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TXSCTL00", "FormName");
		//Fields


        public static WinFormsField TxsctlKey0 = new WinFormsField("TXSCTL-KEY0", "TxsctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
