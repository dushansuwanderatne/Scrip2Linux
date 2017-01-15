using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10202", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PayDesc = new WinFormsField("PAY-DESC", "PayDesc");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField Amount1Desc = new WinFormsField("AMOUNT-1-DESC", "Amount1Desc");
        public static WinFormsField Amount1 = new WinFormsField("AMOUNT-1", "Amount1");
        public static WinFormsField Amount2Desc = new WinFormsField("AMOUNT-2-DESC", "Amount2Desc");
        public static WinFormsField Amount2 = new WinFormsField("AMOUNT-2", "Amount2");
        public static WinFormsField WitholdTax = new WinFormsField("WITHOLD-TAX", "WitholdTax");
        public static WinFormsField WHTaxInd = new WinFormsField("WH-TAX-IND", "WHTaxInd");
    }
}
