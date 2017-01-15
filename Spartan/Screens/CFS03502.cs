using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03502", "FormName");
		//Fields


        public static WinFormsField YSourceDomicile = new WinFormsField("Y-SOURCE-DOMICILE", "YSourceDomicile");
        public static WinFormsField YSourceDesc = new WinFormsField("Y-SOURCE-DESC", "YSourceDesc");
        public static WinFormsField FromDomicile = new WinFormsField("FROM-DOMICILE", "FromDomicile");
        public static WinFormsField RecipientDomicile = new WinFormsField("RECIPIENT-DOMICILE", "RecipientDomicile");
        public static WinFormsField DivTaxRateInd = new WinFormsField("DIV-TAX-RATE-IND", "DivTaxRateInd");
        public static WinFormsField DivTaxRateCoy = new WinFormsField("DIV-TAX-RATE-COY", "DivTaxRateCoy");
        public static WinFormsField IntTaxRateInd = new WinFormsField("INT-TAX-RATE-IND", "IntTaxRateInd");
        public static WinFormsField IntTaxRateCoy = new WinFormsField("INT-TAX-RATE-COY", "IntTaxRateCoy");
        public static WinFormsField SaleTaxRateInd = new WinFormsField("SALE-TAX-RATE-IND", "SaleTaxRateInd");
        public static WinFormsField SaleTaxRateCoy = new WinFormsField("SALE-TAX-RATE-COY", "SaleTaxRateCoy");
    }
}
