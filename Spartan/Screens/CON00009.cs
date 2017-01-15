using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00009", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode3 = new WinFormsField("OLD-CODE-3", "OldCode3");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField NewCode5 = new WinFormsField("NEW-CODE-5", "NewCode5");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField Taxable = new WinFormsField("TAXABLE", "Taxable");
        public static WinFormsField ImputationRate = new WinFormsField("IMPUTATION-RATE", "ImputationRate");
        public static WinFormsField TaxFree = new WinFormsField("TAX-FREE", "TaxFree");
        public static WinFormsField FrankingPercent = new WinFormsField("FRANKING-PERCENT", "FrankingPercent");
    }
}
