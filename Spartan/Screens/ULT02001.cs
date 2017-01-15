using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ULT02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ULT02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField PriceDate = new WinFormsField("PRICE-DATE", "PriceDate");
        public static WinFormsField ApplicationPrice = new WinFormsField("APPLICATION-PRICE", "ApplicationPrice");
        public static WinFormsField RedemptionPrice = new WinFormsField("REDEMPTION-PRICE", "RedemptionPrice");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField TaxFree = new WinFormsField("TAX-FREE", "TaxFree");
        public static WinFormsField FrankedDividend = new WinFormsField("FRANKED-DIVIDEND", "FrankedDividend");
        public static WinFormsField UnfrankedDividend = new WinFormsField("UNFRANKED-DIVIDEND", "UnfrankedDividend");
        public static WinFormsField IncomeRent = new WinFormsField("INCOME-RENT", "IncomeRent");
        public static WinFormsField Interest = new WinFormsField("INTEREST", "Interest");
        public static WinFormsField OSDividend = new WinFormsField("OS-DIVIDEND", "OSDividend");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION1", "Action1");
        public static WinFormsField SearchCode = new WinFormsField("SEARCH-CODE", "SearchCode");
        public static WinFormsField SearchDate = new WinFormsField("SEARCH-DATE", "SearchDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
