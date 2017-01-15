using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FSTCTL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FSTCTL00", "FormName");
		//Fields


        public static WinFormsField FstctlKey0 = new WinFormsField("FSTCTL-KEY0", "FstctlKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
