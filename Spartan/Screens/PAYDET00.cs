using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYDET00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYDET00", "FormName");
		//Fields


        public static WinFormsField PaydetKey0 = new WinFormsField("PAYDET-KEY0", "PaydetKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
