using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CSHTRN00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CSHTRN00", "FormName");
		//Fields


        public static WinFormsField CashReconciliationCode = new WinFormsField("CASH-RECONCILIATION-CODE", "CashReconciliationCode");
        public static WinFormsField CshtrnReference = new WinFormsField("CSHTRN-REFERENCE", "CshtrnReference");
        public static WinFormsField CashReconciliationCode1 = new WinFormsField("CASH-RECONCILIATION-CODE-1", "CashReconciliationCode1");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField CshtrnReferenceKey1 = new WinFormsField("CSHTRN-REFERENCE-KEY1", "CshtrnReferenceKey1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
