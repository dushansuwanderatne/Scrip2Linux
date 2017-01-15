using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS010DB

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS010DB", "FormName");
		//Fields


        public static WinFormsField TradePaySystemNarr = new WinFormsField("TRADE-PAY-SYSTEM-NARR", "TradePaySystemNarr");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField ConfirmScreen = new WinFormsField("CONFIRM-SCREEN", "ConfirmScreen");
    }
}
