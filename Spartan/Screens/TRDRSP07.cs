using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP07", "FormName");
		//Fields


        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField PaymentCurrencyInd = new WinFormsField("PAYMENT-CURRENCY-IND", "PaymentCurrencyInd");
        public static WinFormsField PaymentTotals = new WinFormsField("PAYMENT-TOTALS", "PaymentTotals");
        public static WinFormsField PaymentAmounts = new WinFormsField("PAYMENT-AMOUNTS", "PaymentAmounts");
        public static WinFormsField LocalChqs = new WinFormsField("LOCAL-CHQS", "LocalChqs");
        public static WinFormsField LocChqPymt = new WinFormsField("LOC-CHQ-PYMT", "LocChqPymt");
        public static WinFormsField DirectBanking = new WinFormsField("DIRECT-BANKING", "DirectBanking");
        public static WinFormsField DirBankPymt = new WinFormsField("DIR-BANK-PYMT", "DirBankPymt");
        public static WinFormsField ForeignChqs = new WinFormsField("FOREIGN-CHQS", "ForeignChqs");
        public static WinFormsField FrgnChqPymt = new WinFormsField("FRGN-CHQ-PYMT", "FrgnChqPymt");
        public static WinFormsField Wires = new WinFormsField("WIRES", "Wires");
        public static WinFormsField WirePymt = new WinFormsField("WIRE-PYMT", "WirePymt");
        public static WinFormsField EmployerPaid = new WinFormsField("EMPLOYER-PAID", "EmployerPaid");
        public static WinFormsField EmpPaidPymt = new WinFormsField("EMP-PAID-PYMT", "EmpPaidPymt");
        public static WinFormsField ChqNumberText = new WinFormsField("CHQ-NUMBER-TEXT", "ChqNumberText");
        public static WinFormsField ChqNumberRange = new WinFormsField("CHQ-NUMBER-RANGE", "ChqNumberRange");
        public static WinFormsField Charges = new WinFormsField("CHARGES", "Charges");
        public static WinFormsField TaxONCharges = new WinFormsField("TAX-ON-CHARGES", "TaxONCharges");
        public static WinFormsField Broker = new WinFormsField("BROKER", "Broker");
        public static WinFormsField BrokerTax = new WinFormsField("BROKER-TAX", "BrokerTax");
        public static WinFormsField Commission = new WinFormsField("COMMISSION", "Commission");
        public static WinFormsField CommissionTax = new WinFormsField("COMMISSION-TAX", "CommissionTax");
        public static WinFormsField StampDuty = new WinFormsField("STAMP-DUTY", "StampDuty");
        public static WinFormsField StampDutyTax = new WinFormsField("STAMP-DUTY-TAX", "StampDutyTax");
        public static WinFormsField HandlingFee = new WinFormsField("HANDLING-FEE", "HandlingFee");
        public static WinFormsField HandlingFeeTax = new WinFormsField("HANDLING-FEE-TAX", "HandlingFeeTax");
        public static WinFormsField Misc = new WinFormsField("MISC", "Misc");
        public static WinFormsField MiscTax = new WinFormsField("MISC-TAX", "MiscTax");
        public static WinFormsField WireCharge = new WinFormsField("WIRE-CHARGE", "WireCharge");
        public static WinFormsField WireTax = new WinFormsField("WIRE-TAX", "WireTax");
        public static WinFormsField DirBankCharge = new WinFormsField("DIR-BANK-CHARGE", "DirBankCharge");
        public static WinFormsField DirectBankTax = new WinFormsField("DIRECT-BANK-TAX", "DirectBankTax");
        public static WinFormsField LocChqCharge = new WinFormsField("LOC-CHQ-CHARGE", "LocChqCharge");
        public static WinFormsField LocChqTax = new WinFormsField("LOC-CHQ-TAX", "LocChqTax");
        public static WinFormsField FrgnChqCharge = new WinFormsField("FRGN-CHQ-CHARGE", "FrgnChqCharge");
        public static WinFormsField FrgnChqTax = new WinFormsField("FRGN-CHQ-TAX", "FrgnChqTax");
        public static WinFormsField ChargePaidBYInd = new WinFormsField("CHARGE-PAID-BY-IND", "ChargePaidBYInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
