using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNKACC00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNKACC00", "FormName");
		//Fields


        public static WinFormsField BnkaccKey0 = new WinFormsField("BNKACC-KEY0", "BnkaccKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
