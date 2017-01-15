using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00511

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00511", "FormName");
		//Fields
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField DurationType = new WinFormsField("DURATION-TYPE", "DurationType");
        public static WinFormsField Duration = new WinFormsField("DURATION", "Duration");
        public static WinFormsField EstMarketValue = new WinFormsField("EST-MARKET-VALUE", "EstMarketValue");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
    }
}
