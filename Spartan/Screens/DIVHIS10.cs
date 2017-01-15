using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVHIS10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVHIS10", "FormName");
		//Fields


        public static WinFormsField DivhisKey0 = new WinFormsField("DIVHIS-KEY0", "DivhisKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
