using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CONDTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CONDTL00", "FormName");
		//Fields


        public static WinFormsField CondtlKey0 = new WinFormsField("CONDTL-KEY0", "CondtlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
