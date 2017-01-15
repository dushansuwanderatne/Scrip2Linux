using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField OrderNO = new WinFormsField("ORDER-NO", "OrderNO");
        public static WinFormsField Ident = new WinFormsField("IDENT", "Ident");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField NbrBulks = new WinFormsField("NBR-BULKS", "NbrBulks");
        public static WinFormsField SettlementFrom = new WinFormsField("SETTLEMENT-FROM", "SettlementFrom");
        public static WinFormsField SettlementTO = new WinFormsField("SETTLEMENT-TO", "SettlementTO");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField AddConvRateInd = new WinFormsField("ADD-CONV-RATE-IND", "AddConvRateInd");
    }
}
