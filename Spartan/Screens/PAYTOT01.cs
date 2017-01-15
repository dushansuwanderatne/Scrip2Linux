using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYTOT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYTOT01", "FormName");
		//Fields


        public static WinFormsField PaytotKey0 = new WinFormsField("PAYTOT-KEY0", "PaytotKey0");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField OrigRplcCode = new WinFormsField("ORIG-RPLC-CODE", "OrigRplcCode");
        public static WinFormsField PaymentStatus = new WinFormsField("PAYMENT-STATUS", "PaymentStatus");
        public static WinFormsField NbrPayments = new WinFormsField("NBR-PAYMENTS", "NbrPayments");
        public static WinFormsField TotalNettAmt = new WinFormsField("TOTAL-NETT-AMT", "TotalNettAmt");
        public static WinFormsField TotalDualAmt = new WinFormsField("TOTAL-DUAL-AMT", "TotalDualAmt");
    }
}
