using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLSPRC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLSPRC01", "FormName");
		//Fields


        public static WinFormsField ClsprcKey0 = new WinFormsField("CLSPRC-KEY0", "ClsprcKey0");
        public static WinFormsField ApplicationPrice = new WinFormsField("APPLICATION-PRICE", "ApplicationPrice");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RedemptionPrice = new WinFormsField("REDEMPTION-PRICE", "RedemptionPrice");
        public static WinFormsField PriceDate = new WinFormsField("PRICE-DATE", "PriceDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField TaxFree = new WinFormsField("TAX-FREE", "TaxFree");
        public static WinFormsField FrankedDividend = new WinFormsField("FRANKED-DIVIDEND", "FrankedDividend");
        public static WinFormsField UnfrankedDividend = new WinFormsField("UNFRANKED-DIVIDEND", "UnfrankedDividend");
        public static WinFormsField IncomeRent = new WinFormsField("INCOME-RENT", "IncomeRent");
        public static WinFormsField Interest = new WinFormsField("INTEREST", "Interest");
        public static WinFormsField OSDividend = new WinFormsField("OS-DIVIDEND", "OSDividend");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
