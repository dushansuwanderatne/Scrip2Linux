using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDHIS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDHIS02", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradingNumber = new WinFormsField("TRADING-NUMBER", "TradingNumber");
        public static WinFormsField DlgTransNumber = new WinFormsField("DLG-TRANS-NUMBER", "DlgTransNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField CrtTransNumber = new WinFormsField("CRT-TRANS-NUMBER", "CrtTransNumber");
        public static WinFormsField CurrentEmployeeInd = new WinFormsField("CURRENT-EMPLOYEE-IND", "CurrentEmployeeInd");
        public static WinFormsField ResidentATGrantInd = new WinFormsField("RESIDENT-AT-GRANT-IND", "ResidentATGrantInd");
        public static WinFormsField CurrentResidentInd = new WinFormsField("CURRENT-RESIDENT-IND", "CurrentResidentInd");
        public static WinFormsField TaxFreeUnitsTraded = new WinFormsField("TAX-FREE-UNITS-TRADED", "TaxFreeUnitsTraded");
        public static WinFormsField TaxableUnitsTraded1 = new WinFormsField("TAXABLE-UNITS-TRADED-1", "TaxableUnitsTraded1");
        public static WinFormsField TaxableUnitsTraded2 = new WinFormsField("TAXABLE-UNITS-TRADED-2", "TaxableUnitsTraded2");
        public static WinFormsField MiddleMarketValue = new WinFormsField("MIDDLE-MARKET-VALUE", "MiddleMarketValue");
        public static WinFormsField ForfeitedUnits = new WinFormsField("FORFEITED-UNITS", "ForfeitedUnits");
        public static WinFormsField TotalAssessableUnits = new WinFormsField("TOTAL-ASSESSABLE-UNITS", "TotalAssessableUnits");
        public static WinFormsField AvgTaxRate = new WinFormsField("AVG-TAX-RATE", "AvgTaxRate");
        public static WinFormsField TotalAssessableAmount = new WinFormsField("TOTAL-ASSESSABLE-AMOUNT", "TotalAssessableAmount");
        public static WinFormsField TotalWithholdingTax = new WinFormsField("TOTAL-WITHHOLDING-TAX", "TotalWithholdingTax");
        public static WinFormsField WithholdingTaxRate = new WinFormsField("WITHHOLDING-TAX-RATE", "WithholdingTaxRate");
        public static WinFormsField NotificationInd = new WinFormsField("NOTIFICATION-IND", "NotificationInd");
        public static WinFormsField MobilePhone = new WinFormsField("MOBILE-PHONE", "MobilePhone");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
