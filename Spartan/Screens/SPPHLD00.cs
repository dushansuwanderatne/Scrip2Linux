using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPPHLD00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPPHLD00", "FormName");
		//Fields


        public static WinFormsField SpphldKey0 = new WinFormsField("SPPHLD-KEY0", "SpphldKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
