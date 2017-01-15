using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS00105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS00105", "FormName");
		//Fields


        public static WinFormsField MenuItemIE = new WinFormsField("MENU-ITEM-IE", "IE.  Investor Enquiry", "InvestorEnquiry");
        public static WinFormsField MenuItemCL = new WinFormsField("MENU-ITEM-CL", "CL.  Credit Card Lookup", "CreditCardLookup");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit ENQUIRY System", "ExitENQUIRYSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
