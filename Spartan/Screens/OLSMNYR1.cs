using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSMNYR1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSMNYR1", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField PayeeBankID = new WinFormsField("PAYEE-BANK-ID", "PayeeBankID");
        public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField BalanceInstruction = new WinFormsField("BALANCE-INSTRUCTION", "BalanceInstruction");
    }
}
