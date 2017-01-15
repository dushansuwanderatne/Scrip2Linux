using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYIAT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYIAT00", "FormName");
		//Fields


        public static WinFormsField PayiatKey0 = new WinFormsField("PAYIAT-KEY0", "PayiatKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
