using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISINV01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISINV01", "FormName");
		//Fields


        public static WinFormsField EisinvKey0 = new WinFormsField("EISINV-KEY0", "EisinvKey0");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField CommenceDate = new WinFormsField("COMMENCE-DATE", "CommenceDate");
        public static WinFormsField TermPendingVestFlag = new WinFormsField("TERM-PENDING-VEST-FLAG", "TermPendingVestFlag");
        public static WinFormsField ContribType = new WinFormsField("CONTRIB-TYPE", "ContribType");
        public static WinFormsField CoyVestFlag = new WinFormsField("COY-VEST-FLAG", "CoyVestFlag");
        public static WinFormsField CoyVestPeriod = new WinFormsField("COY-VEST-PERIOD", "CoyVestPeriod");
        public static WinFormsField RTEmpRetainFlag = new WinFormsField("RT-EMP-RETAIN-FLAG", "RTEmpRetainFlag");
        public static WinFormsField RTVestedRetainFlag = new WinFormsField("RT-VESTED-RETAIN-FLAG", "RTVestedRetainFlag");
        public static WinFormsField RTUnvestedRetainFlag = new WinFormsField("RT-UNVESTED-RETAIN-FLAG", "RTUnvestedRetainFlag");
        public static WinFormsField FCCurrencyDesc = new WinFormsField("FC-CURRENCY-DESC", "FCCurrencyDesc");
        public static WinFormsField FCAmtINWordsInd = new WinFormsField("FC-AMT-IN-WORDS-IND", "FCAmtINWordsInd");
        public static WinFormsField CoyVestClass = new WinFormsField("COY-VEST-CLASS", "CoyVestClass");
        public static WinFormsField CoyUnvestClass = new WinFormsField("COY-UNVEST-CLASS", "CoyUnvestClass");
        public static WinFormsField CoyUnvestTaxCat = new WinFormsField("COY-UNVEST-TAX-CAT", "CoyUnvestTaxCat");
        public static WinFormsField VTEmpRetainFlag = new WinFormsField("VT-EMP-RETAIN-FLAG", "VTEmpRetainFlag");
        public static WinFormsField VTVestedRetainFlag = new WinFormsField("VT-VESTED-RETAIN-FLAG", "VTVestedRetainFlag");
        public static WinFormsField VTUnvestedRetainFlag = new WinFormsField("VT-UNVESTED-RETAIN-FLAG", "VTUnvestedRetainFlag");
        public static WinFormsField PayrollTapeFlag = new WinFormsField("PAYROLL-TAPE-FLAG", "PayrollTapeFlag");
        public static WinFormsField PayrollTranType = new WinFormsField("PAYROLL-TRAN-TYPE", "PayrollTranType");
        public static WinFormsField CoyVestTaxCat = new WinFormsField("COY-VEST-TAX-CAT", "CoyVestTaxCat");
        public static WinFormsField CoyVestTranType = new WinFormsField("COY-VEST-TRAN-TYPE", "CoyVestTranType");
        public static WinFormsField ITEmpRetainFlag = new WinFormsField("IT-EMP-RETAIN-FLAG", "ITEmpRetainFlag");
        public static WinFormsField ITVestedRetainFlag = new WinFormsField("IT-VESTED-RETAIN-FLAG", "ITVestedRetainFlag");
        public static WinFormsField ITUnvestedRetainFlag = new WinFormsField("IT-UNVESTED-RETAIN-FLAG", "ITUnvestedRetainFlag");
        public static WinFormsField EmpContribMin = new WinFormsField("EMP-CONTRIB-MIN", "EmpContribMin");
        public static WinFormsField WdlEmpRetainFlag = new WinFormsField("WDL-EMP-RETAIN-FLAG", "WdlEmpRetainFlag");
        public static WinFormsField WdlVestedRetainFlag = new WinFormsField("WDL-VESTED-RETAIN-FLAG", "WdlVestedRetainFlag");
        public static WinFormsField WdlUnvestedRetainFlag = new WinFormsField("WDL-UNVESTED-RETAIN-FLAG", "WdlUnvestedRetainFlag");
        public static WinFormsField EmpContribMult = new WinFormsField("EMP-CONTRIB-MULT", "EmpContribMult");
        public static WinFormsField FirstAllotPeriod = new WinFormsField("FIRST-ALLOT-PERIOD", "FirstAllotPeriod");
        public static WinFormsField SaleForfeitUnvestFlag = new WinFormsField("SALE-FORFEIT-UNVEST-FLAG", "SaleForfeitUnvestFlag");
        public static WinFormsField EmpContribMaxInd = new WinFormsField("EMP-CONTRIB-MAX-IND", "EmpContribMaxInd");
        public static WinFormsField EmpContribMax = new WinFormsField("EMP-CONTRIB-MAX", "EmpContribMax");
        public static WinFormsField LastAllotDate = new WinFormsField("LAST-ALLOT-DATE", "LastAllotDate");
        public static WinFormsField SaleVestB4Flag = new WinFormsField("SALE-VEST-B4-FLAG", "SaleVestB4Flag");
        public static WinFormsField EmpClassCode = new WinFormsField("EMP-CLASS-CODE", "EmpClassCode");
        public static WinFormsField EmpTaxCategory = new WinFormsField("EMP-TAX-CATEGORY", "EmpTaxCategory");
        public static WinFormsField LastAllotPeriod = new WinFormsField("LAST-ALLOT-PERIOD", "LastAllotPeriod");
        public static WinFormsField EmpMaxCFMoneyInd = new WinFormsField("EMP-MAX-CF-MONEY-IND", "EmpMaxCFMoneyInd");
        public static WinFormsField CurrAllotPeriod = new WinFormsField("CURR-ALLOT-PERIOD", "CurrAllotPeriod");
        public static WinFormsField EmpMoneyRefundFlag = new WinFormsField("EMP-MONEY-REFUND-FLAG", "EmpMoneyRefundFlag");
        public static WinFormsField CoyMatchFlag = new WinFormsField("COY-MATCH-FLAG", "CoyMatchFlag");
        public static WinFormsField AllotFreqInd = new WinFormsField("ALLOT-FREQ-IND", "AllotFreqInd");
        public static WinFormsField AllotRoundInd = new WinFormsField("ALLOT-ROUND-IND", "AllotRoundInd");
        public static WinFormsField VestedUnitsAccInd = new WinFormsField("VESTED-UNITS-ACC-IND", "VestedUnitsAccInd");
        public static WinFormsField CoyMatchOfferX = new WinFormsField("COY-MATCH-OFFER-X", "CoyMatchOfferX");
        public static WinFormsField UnvestUnitsAccInd = new WinFormsField("UNVEST-UNITS-ACC-IND", "UnvestUnitsAccInd");
        public static WinFormsField CoyMatchOfferY = new WinFormsField("COY-MATCH-OFFER-Y", "CoyMatchOfferY");
        public static WinFormsField AllotPoolHid = new WinFormsField("ALLOT-POOL-HID", "AllotPoolHid");
        public static WinFormsField CoyMatchRoundInd = new WinFormsField("COY-MATCH-ROUND-IND", "CoyMatchRoundInd");
        public static WinFormsField AllotPoolClass = new WinFormsField("ALLOT-POOL-CLASS", "AllotPoolClass");
        public static WinFormsField ReserveHid = new WinFormsField("RESERVE-HID", "ReserveHid");
        public static WinFormsField ReserveClass = new WinFormsField("RESERVE-CLASS", "ReserveClass");
        public static WinFormsField LimitRequiredInd = new WinFormsField("LIMIT-REQUIRED-IND", "LimitRequiredInd");
        public static WinFormsField AllotRollingPoolFlag = new WinFormsField("ALLOT-ROLLING-POOL-FLAG", "AllotRollingPoolFlag");
        public static WinFormsField ReserveEmpMoneyClass = new WinFormsField("RESERVE-EMP-MONEY-CLASS", "ReserveEmpMoneyClass");
        public static WinFormsField ReserveCoyMoneyClass = new WinFormsField("RESERVE-COY-MONEY-CLASS", "ReserveCoyMoneyClass");
        public static WinFormsField CoyMatchLimit = new WinFormsField("COY-MATCH-LIMIT", "CoyMatchLimit");
        public static WinFormsField AllotMoneyCFFlag = new WinFormsField("ALLOT-MONEY-CF-FLAG", "AllotMoneyCFFlag");
        public static WinFormsField UsingEmpctlInd = new WinFormsField("USING-EMPCTL-IND", "UsingEmpctlInd");
        public static WinFormsField EmpctlClass = new WinFormsField("EMPCTL-CLASS", "EmpctlClass");
        public static WinFormsField EmpctlHid = new WinFormsField("EMPCTL-HID", "EmpctlHid");
        public static WinFormsField CoyMatchCFMoneyInd = new WinFormsField("COY-MATCH-CF-MONEY-IND", "CoyMatchCFMoneyInd");
        public static WinFormsField AllotTranType = new WinFormsField("ALLOT-TRAN-TYPE", "AllotTranType");
        public static WinFormsField LastStatementRun = new WinFormsField("LAST-STATEMENT-RUN", "LastStatementRun");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField TotalCashONFile = new WinFormsField("TOTAL-CASH-ON-FILE", "TotalCashONFile");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
