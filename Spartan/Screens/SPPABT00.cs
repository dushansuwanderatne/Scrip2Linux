using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPABT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPABT00", "FormName");
		//Fields


        public static WinFormsField SppabtKey0 = new WinFormsField("SPPABT-KEY0", "SppabtKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
