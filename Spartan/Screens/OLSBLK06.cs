using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK06", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField Counterparty = new WinFormsField("COUNTERPARTY", "Counterparty");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField CounterAddressLine = new WinFormsField("COUNTER-ADDRESS-LINE", "CounterAddressLine");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField FractionAmount = new WinFormsField("FRACTION-AMOUNT", "FractionAmount");
        public static WinFormsField DeductionOther = new WinFormsField("DEDUCTION-OTHER", "DeductionOther");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField TotalCharges = new WinFormsField("TOTAL-CHARGES", "TotalCharges");
        public static WinFormsField TaxDeducted = new WinFormsField("TAX-DEDUCTED", "TaxDeducted");
        public static WinFormsField ChqCount = new WinFormsField("CHQ-COUNT", "ChqCount");
        public static WinFormsField ChqNettAmount = new WinFormsField("CHQ-NETT-AMOUNT", "ChqNettAmount");
        public static WinFormsField DcbCount = new WinFormsField("DCB-COUNT", "DcbCount");
        public static WinFormsField DcbNettAmount = new WinFormsField("DCB-NETT-AMOUNT", "DcbNettAmount");
        public static WinFormsField TaxONCharges = new WinFormsField("TAX-ON-CHARGES", "TaxONCharges");
        public static WinFormsField TotalSellUnits = new WinFormsField("TOTAL-SELL-UNITS", "TotalSellUnits");
        public static WinFormsField AccumCharges = new WinFormsField("ACCUM-CHARGES", "AccumCharges");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
