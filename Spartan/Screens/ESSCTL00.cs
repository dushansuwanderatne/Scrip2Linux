using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSCTL00", "FormName");
		//Fields


        public static WinFormsField EssctlKey0 = new WinFormsField("ESSCTL-KEY0", "EssctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
