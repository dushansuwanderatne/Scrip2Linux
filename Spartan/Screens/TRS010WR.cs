using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS010WR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS010WR", "FormName");
		//Fields


        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField AddressLine1 = new WinFormsField("ADDRESS-LINE-1", "AddressLine1");
        public static WinFormsField AddressLine2 = new WinFormsField("ADDRESS-LINE-2", "AddressLine2");
        public static WinFormsField AddressLine3 = new WinFormsField("ADDRESS-LINE-3", "AddressLine3");
        public static WinFormsField ConfirmScreen = new WinFormsField("CONFIRM-SCREEN", "ConfirmScreen");
    }
}
