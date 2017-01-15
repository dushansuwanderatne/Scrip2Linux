using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSAPR00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSAPR00", "FormName");
		//Fields


        public static WinFormsField EssaprKey0 = new WinFormsField("ESSAPR-KEY0", "EssaprKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
