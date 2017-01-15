using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01016

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01016", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Ers01016LoanRegBreakupInd = new WinFormsField("ERS01016-LOAN-REG-BREAKUP-IND", "Ers01016LoanRegBreakupInd");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField AwardDate = new WinFormsField("AWARD-DATE", "AwardDate");
        public static WinFormsField ResidualXferDate = new WinFormsField("RESIDUAL-XFER-DATE", "ResidualXferDate");
        public static WinFormsField ResidualXferAmount = new WinFormsField("RESIDUAL-XFER-AMOUNT", "ResidualXferAmount");
        public static WinFormsField HoldingEndDate = new WinFormsField("HOLDING-END-DATE", "HoldingEndDate");
        public static WinFormsField TaxEndDate = new WinFormsField("TAX-END-DATE", "TaxEndDate");
        public static WinFormsField Ers01016ForfEndDate = new WinFormsField("ERS01016-FORF-END-DATE", "Ers01016ForfEndDate");
        public static WinFormsField Vwap = new WinFormsField("VWAP", "Vwap");
        public static WinFormsField ShareCost = new WinFormsField("SHARE-COST", "ShareCost");
        public static WinFormsField CurrentBalance = new WinFormsField("CURRENT-BALANCE", "CurrentBalance");
        public static WinFormsField OriginalBalance = new WinFormsField("ORIGINAL-BALANCE", "OriginalBalance");
        public static WinFormsField TotalCost = new WinFormsField("TOTAL-COST", "TotalCost");
        public static WinFormsField Usan = new WinFormsField("USAN", "Usan");
        public static WinFormsField SavingsAmount = new WinFormsField("SAVINGS-AMOUNT", "SavingsAmount");
        public static WinFormsField TotalSavings = new WinFormsField("TOTAL-SAVINGS", "TotalSavings");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField Residue = new WinFormsField("RESIDUE", "Residue");
        public static WinFormsField TaxAssessed = new WinFormsField("TAX-ASSESSED", "TaxAssessed");
        public static WinFormsField TerminationInd = new WinFormsField("TERMINATION-IND", "TerminationInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
