using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00301", "FormName");
		//Fields


        public static WinFormsField BankJuris = new WinFormsField("BANK-JURIS", "BankJuris");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAccount = new WinFormsField("BANK-ACCOUNT", "BankAccount");
        public static WinFormsField BankingCurrency = new WinFormsField("BANKING-CURRENCY", "BankingCurrency");
        public static WinFormsField Entity = new WinFormsField("ENTITY", "Entity");
        public static WinFormsField CompanyCountry = new WinFormsField("COMPANY-COUNTRY", "CompanyCountry");
        public static WinFormsField SubSystem = new WinFormsField("SUB-SYSTEM", "SubSystem");
        public static WinFormsField FreeFormat = new WinFormsField("FREE-FORMAT", "FreeFormat");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField SearchBankJuris = new WinFormsField("SEARCH-BANK-JURIS", "SearchBankJuris");
        public static WinFormsField SearchBankCode = new WinFormsField("SEARCH-BANK-CODE", "SearchBankCode");
        public static WinFormsField SearchBankAccount = new WinFormsField("SEARCH-BANK-ACCOUNT", "SearchBankAccount");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BankJurisDesc = new WinFormsField("BANK-JURIS-DESC", "BankJurisDesc");
        public static WinFormsField BankCodeDesc = new WinFormsField("BANK-CODE-DESC", "BankCodeDesc");
        public static WinFormsField BankingCurrencyDesc = new WinFormsField("BANKING-CURRENCY-DESC", "BankingCurrencyDesc");
        public static WinFormsField CompanyCountryDesc = new WinFormsField("COMPANY-COUNTRY-DESC", "CompanyCountryDesc");
        public static WinFormsField BankAccountAvail = new WinFormsField("BANK-ACCOUNT-AVAIL", "BankAccountAvail");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
