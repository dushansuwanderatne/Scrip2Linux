using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYTRN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYTRN00", "FormName");
		//Fields


        public static WinFormsField PaytrnKey0 = new WinFormsField("PAYTRN-KEY0", "PaytrnKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
