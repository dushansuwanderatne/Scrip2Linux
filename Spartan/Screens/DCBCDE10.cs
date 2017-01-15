using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCBCDE10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCBCDE10", "FormName");
		//Fields


        public static WinFormsField DcbcdeKey0 = new WinFormsField("DCBCDE-KEY0", "DcbcdeKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
