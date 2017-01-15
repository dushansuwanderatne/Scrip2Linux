using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDTRN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDTRN00", "FormName");
		//Fields


        public static WinFormsField FidtrnKey0 = new WinFormsField("FIDTRN-KEY0", "FidtrnKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
