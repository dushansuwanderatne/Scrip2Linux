using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class USRSEC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("USRSEC01", "FormName");
		//Fields


        public static WinFormsField UsrsecKey0 = new WinFormsField("USRSEC-KEY0", "UsrsecKey0");
        public static WinFormsField LoginName = new WinFormsField("LOGIN-NAME", "LoginName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField UserSecurityGroup = new WinFormsField("USER-SECURITY-GROUP", "UserSecurityGroup");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
