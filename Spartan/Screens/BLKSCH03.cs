using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKSCH03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKSCH03", "FormName");
		//Fields


        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField UnitsCalc = new WinFormsField("UNITS-CALC", "UnitsCalc");
        public static WinFormsField CostOFShares = new WinFormsField("COST-OF-SHARES", "CostOFShares");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDesc = new WinFormsField("CHARGE-DESC", "ChargeDesc");
        public static WinFormsField TotalCharges = new WinFormsField("TOTAL-CHARGES", "TotalCharges");
        public static WinFormsField TotalCost = new WinFormsField("TOTAL-COST", "TotalCost");
        public static WinFormsField ResidueKept = new WinFormsField("RESIDUE-KEPT", "ResidueKept");
        public static WinFormsField ResidueRefunded = new WinFormsField("RESIDUE-REFUNDED", "ResidueRefunded");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField ExerciseAmount = new WinFormsField("EXERCISE-AMOUNT", "ExerciseAmount");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField TaxONCharges = new WinFormsField("TAX-ON-CHARGES", "TaxONCharges");
        public static WinFormsField FractionAmount = new WinFormsField("FRACTION-AMOUNT", "FractionAmount");
        public static WinFormsField AccumCharges = new WinFormsField("ACCUM-CHARGES", "AccumCharges");
        public static WinFormsField DeductionOther = new WinFormsField("DEDUCTION-OTHER", "DeductionOther");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField TotalTaxAmount = new WinFormsField("TOTAL-TAX-AMOUNT", "TotalTaxAmount");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField NicDeducted = new WinFormsField("NIC-DEDUCTED", "NicDeducted");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField ChqCount = new WinFormsField("CHQ-COUNT", "ChqCount");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField ChqNettAmount = new WinFormsField("CHQ-NETT-AMOUNT", "ChqNettAmount");
        public static WinFormsField DcbCount = new WinFormsField("DCB-COUNT", "DcbCount");
        public static WinFormsField ExercisePrice = new WinFormsField("EXERCISE-PRICE", "ExercisePrice");
        public static WinFormsField DcbNettAmount = new WinFormsField("DCB-NETT-AMOUNT", "DcbNettAmount");
        public static WinFormsField TotalSellUnits = new WinFormsField("TOTAL-SELL-UNITS", "TotalSellUnits");
        public static WinFormsField ChqNbrFrom = new WinFormsField("CHQ-NBR-FROM", "ChqNbrFrom");
        public static WinFormsField ChqNbrTO = new WinFormsField("CHQ-NBR-TO", "ChqNbrTO");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
