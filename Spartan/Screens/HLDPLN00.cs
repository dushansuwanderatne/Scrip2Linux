using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDPLN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDPLN00", "FormName");
		//Fields


        public static WinFormsField HldplnKey0 = new WinFormsField("HLDPLN-KEY0", "HldplnKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
