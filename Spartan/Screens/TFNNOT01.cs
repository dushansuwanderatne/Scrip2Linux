using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TFNNOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TFNNOT01", "FormName");
		//Fields


        public static WinFormsField TfnnotKey0 = new WinFormsField("TFNNOT-KEY0", "TfnnotKey0");
        public static WinFormsField ReasonRequired = new WinFormsField("REASON-REQUIRED", "ReasonRequired");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
