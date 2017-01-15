using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00200", "FormName");
		//Fields


        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField CurrentStatus = new WinFormsField("CURRENT-STATUS", "CurrentStatus");
        public static WinFormsField SignificantChange = new WinFormsField("SIGNIFICANT-CHANGE", "SignificantChange");
        public static WinFormsField AccountNameReqd = new WinFormsField("ACCOUNT-NAME-REQD", "AccountNameReqd");
        public static WinFormsField AlphaINAccountNbr = new WinFormsField("ALPHA-IN-ACCOUNT-NBR", "AlphaINAccountNbr");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchBulkPay = new WinFormsField("SEARCH-BULK-PAY", "SearchBulkPay");
        public static WinFormsField SearchBankCode = new WinFormsField("SEARCH-BANK-CODE", "SearchBankCode");
    }
}
