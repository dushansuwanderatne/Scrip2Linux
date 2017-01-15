using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TFNNOT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TFNNOT00", "FormName");
		//Fields


        public static WinFormsField TfnnotKey0 = new WinFormsField("TFNNOT-KEY0", "TfnnotKey0");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
