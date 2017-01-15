using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ASXTHS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ASXTHS01", "FormName");
		//Fields


        public static WinFormsField AsxthsKey0 = new WinFormsField("ASXTHS-KEY0", "AsxthsKey0");
        public static WinFormsField CompanyAsxCode = new WinFormsField("COMPANY-ASX-CODE", "CompanyAsxCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField LowestPrice = new WinFormsField("LOWEST-PRICE", "LowestPrice");
        public static WinFormsField HighestPrice = new WinFormsField("HIGHEST-PRICE", "HighestPrice");
        public static WinFormsField ClosingPrice = new WinFormsField("CLOSING-PRICE", "ClosingPrice");
        public static WinFormsField TradeVolume = new WinFormsField("TRADE-VOLUME", "TradeVolume");
        public static WinFormsField NumberTransactions = new WinFormsField("NUMBER-TRANSACTIONS", "NumberTransactions");
        public static WinFormsField DenominationType = new WinFormsField("DENOMINATION-TYPE", "DenominationType");
        public static WinFormsField FloorValue = new WinFormsField("FLOOR-VALUE", "FloorValue");
        public static WinFormsField FloorVolume = new WinFormsField("FLOOR-VOLUME", "FloorVolume");
        public static WinFormsField PriceSourceInd = new WinFormsField("PRICE-SOURCE-IND", "PriceSourceInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
