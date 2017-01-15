using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AMPMEN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AMPMEN01", "FormName");
		//Fields


        public static WinFormsField MembershipNumber = new WinFormsField("MEMBERSHIP-NUMBER", "MembershipNumber");
        public static WinFormsField EntitlementNumber = new WinFormsField("ENTITLEMENT-NUMBER", "EntitlementNumber");
        public static WinFormsField Position = new WinFormsField("POSITION", "Position");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
