using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEOY0105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEOY0105", "FormName");
		//Fields


        public static WinFormsField Account = new WinFormsField("ACCOUNT", "Account");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField AccountDesc = new WinFormsField("ACCOUNT-DESC", "AccountDesc");
        public static WinFormsField TaxDeferred = new WinFormsField("TAX-DEFERRED", "TaxDeferred");
        public static WinFormsField TaxFree = new WinFormsField("TAX-FREE", "TaxFree");
        public static WinFormsField Income = new WinFormsField("INCOME", "Income");
        public static WinFormsField Interest = new WinFormsField("INTEREST", "Interest");
        public static WinFormsField ForeignIncome = new WinFormsField("FOREIGN-INCOME", "ForeignIncome");
        public static WinFormsField ForeignIntInc = new WinFormsField("FOREIGN-INT-INC", "ForeignIntInc");
        public static WinFormsField ForeignDivInc = new WinFormsField("FOREIGN-DIV-INC", "ForeignDivInc");
        public static WinFormsField RentalIncome = new WinFormsField("RENTAL-INCOME", "RentalIncome");
        public static WinFormsField AttributedInc = new WinFormsField("ATTRIBUTED-INC", "AttributedInc");
        public static WinFormsField PrimProdInc = new WinFormsField("PRIM-PROD-INC", "PrimProdInc");
        public static WinFormsField NonprimProdInc = new WinFormsField("NONPRIM-PROD-INC", "NonprimProdInc");
        public static WinFormsField PassiveInc = new WinFormsField("PASSIVE-INC", "PassiveInc");
        public static WinFormsField DiscCapGain = new WinFormsField("DISC-CAP-GAIN", "DiscCapGain");
        public static WinFormsField NondiscCapGain = new WinFormsField("NONDISC-CAP-GAIN", "NondiscCapGain");
        public static WinFormsField OtherIncome = new WinFormsField("OTHER-INCOME", "OtherIncome");
        public static WinFormsField DistTaxCredit = new WinFormsField("DIST-TAX-CREDIT", "DistTaxCredit");
        public static WinFormsField MoreAccounts = new WinFormsField("MORE-ACCOUNTS", "MoreAccounts");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
