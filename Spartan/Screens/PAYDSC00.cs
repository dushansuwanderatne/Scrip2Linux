using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYDSC00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYDSC00", "FormName");
		//Fields


        public static WinFormsField PaydscKey0 = new WinFormsField("PAYDSC-KEY0", "PaydscKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
