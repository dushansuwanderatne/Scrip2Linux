using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00704", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField UnitsExercise = new WinFormsField("UNITS-EXERCISE", "UnitsExercise");
        public static WinFormsField UnitsSell = new WinFormsField("UNITS-SELL", "UnitsSell");
        public static WinFormsField EstMarketValue = new WinFormsField("EST-MARKET-VALUE", "EstMarketValue");
        public static WinFormsField MarketValue = new WinFormsField("MARKET-VALUE", "MarketValue");
        public static WinFormsField PurchResidueAmt = new WinFormsField("PURCH-RESIDUE-AMT", "PurchResidueAmt");
        public static WinFormsField PurchResidueSign = new WinFormsField("PURCH-RESIDUE-SIGN", "PurchResidueSign");
        public static WinFormsField FederalTaxWithheld = new WinFormsField("FEDERAL-TAX-WITHHELD", "FederalTaxWithheld");
        public static WinFormsField OptionCost = new WinFormsField("OPTION-COST", "OptionCost");
        public static WinFormsField LoanEmployer = new WinFormsField("LOAN-EMPLOYER", "LoanEmployer");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField ChargeAmount = new WinFormsField("CHARGE-AMOUNT", "ChargeAmount");
        public static WinFormsField ConfirmNilProceeds = new WinFormsField("CONFIRM-NIL-PROCEEDS", "ConfirmNilProceeds");
        public static WinFormsField TotalGst = new WinFormsField("TOTAL-GST", "TotalGst");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField EstimatedProceeds = new WinFormsField("ESTIMATED-PROCEEDS", "EstimatedProceeds");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
