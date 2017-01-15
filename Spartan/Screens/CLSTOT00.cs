using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLSTOT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLSTOT00", "FormName");
		//Fields


        public static WinFormsField ClstotKey0 = new WinFormsField("CLSTOT-KEY0", "ClstotKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
