using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYATD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYATD01", "FormName");
		//Fields


        public static WinFormsField PayatdKey0 = new WinFormsField("PAYATD-KEY0", "PayatdKey0");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PayOrigRepl = new WinFormsField("PAY-ORIG-REPL", "PayOrigRepl");
        public static WinFormsField CreatedDate = new WinFormsField("CREATED-DATE", "CreatedDate");
        public static WinFormsField CreatedTime = new WinFormsField("CREATED-TIME", "CreatedTime");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
