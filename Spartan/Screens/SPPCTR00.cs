using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPCTR00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPCTR00", "FormName");
		//Fields


        public static WinFormsField SppctrKey0 = new WinFormsField("SPPCTR-KEY0", "SppctrKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
