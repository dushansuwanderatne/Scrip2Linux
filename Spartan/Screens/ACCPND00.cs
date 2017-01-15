using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCPND00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCPND00", "FormName");
		//Fields


        public static WinFormsField AccpndKey0 = new WinFormsField("ACCPND-KEY0", "AccpndKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
