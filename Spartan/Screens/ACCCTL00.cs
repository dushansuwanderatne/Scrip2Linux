using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCCTL00", "FormName");
		//Fields


        public static WinFormsField AccctlKey0 = new WinFormsField("ACCCTL-KEY0", "AccctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
