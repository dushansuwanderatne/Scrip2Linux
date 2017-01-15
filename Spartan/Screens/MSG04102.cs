using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG04102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG04102", "FormName");
		//Fields


        public static WinFormsField BankCodeDebit = new WinFormsField("BANK-CODE-DEBIT", "BankCodeDebit");
        public static WinFormsField AccountDebit = new WinFormsField("ACCOUNT-DEBIT", "AccountDebit");
        public static WinFormsField BankCodeCredit = new WinFormsField("BANK-CODE-CREDIT", "BankCodeCredit");
        public static WinFormsField AccountCredit = new WinFormsField("ACCOUNT-CREDIT", "AccountCredit");
        public static WinFormsField DescDebit = new WinFormsField("DESC-DEBIT", "DescDebit");
        public static WinFormsField DescCredit = new WinFormsField("DESC-CREDIT", "DescCredit");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
