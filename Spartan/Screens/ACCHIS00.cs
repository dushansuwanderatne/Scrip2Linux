using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCHIS00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCHIS00", "FormName");
		//Fields


        public static WinFormsField AcchisKey0 = new WinFormsField("ACCHIS-KEY0", "AcchisKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
