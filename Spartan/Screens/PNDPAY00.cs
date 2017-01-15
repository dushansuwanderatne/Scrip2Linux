using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDPAY00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDPAY00", "FormName");
		//Fields


        public static WinFormsField PndpayKey0 = new WinFormsField("PNDPAY-KEY0", "PndpayKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
