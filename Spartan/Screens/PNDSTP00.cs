using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDSTP00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDSTP00", "FormName");
		//Fields


        public static WinFormsField PndstpKey0 = new WinFormsField("PNDSTP-KEY0", "PndstpKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}