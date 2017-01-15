using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDNOT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDNOT00", "FormName");
		//Fields


        public static WinFormsField PndnotKey0 = new WinFormsField("PNDNOT-KEY0", "PndnotKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
