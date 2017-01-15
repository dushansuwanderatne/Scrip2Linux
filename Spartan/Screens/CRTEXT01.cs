using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRTEXT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRTEXT01", "FormName");
		//Fields


        public static WinFormsField CrtextKey0 = new WinFormsField("CRTEXT-KEY0", "CrtextKey0");
        public static WinFormsField Balance = new WinFormsField("BALANCE", "Balance");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField CashAmount = new WinFormsField("CASH-AMOUNT", "CashAmount");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField MgmtFeeApp = new WinFormsField("MGMT-FEE-APP", "MgmtFeeApp");
        public static WinFormsField CrtTrnCount = new WinFormsField("CRT-TRN-COUNT", "CrtTrnCount");
        public static WinFormsField MgmtFee = new WinFormsField("MGMT-FEE", "MgmtFee");
        public static WinFormsField CommFeeApp = new WinFormsField("COMM-FEE-APP", "CommFeeApp");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField Origin = new WinFormsField("ORIGIN", "Origin");
        public static WinFormsField Commission = new WinFormsField("COMMISSION", "Commission");
        public static WinFormsField TaxFreeAmt = new WinFormsField("TAX-FREE-AMT", "TaxFreeAmt");
        public static WinFormsField BrkRebate = new WinFormsField("BRK-REBATE", "BrkRebate");
        public static WinFormsField FrankedDividendAmt = new WinFormsField("FRANKED-DIVIDEND-AMT", "FrankedDividendAmt");
        public static WinFormsField FirstAllotment = new WinFormsField("1ST-ALLOTMENT", "1stAllotment");
        public static WinFormsField UnfrankedDividendAmt = new WinFormsField("UNFRANKED-DIVIDEND-AMT", "UnfrankedDividendAmt");
        public static WinFormsField SecondAllotment = new WinFormsField("2ND-ALLOTMENT", "2ndAllotment");
        public static WinFormsField IncomeRentAmt = new WinFormsField("INCOME-RENT-AMT", "IncomeRentAmt");
        public static WinFormsField InterestAmt = new WinFormsField("INTEREST-AMT", "InterestAmt");
        public static WinFormsField NettCapitalAmt = new WinFormsField("NETT-CAPITAL-AMT", "NettCapitalAmt");
        public static WinFormsField OSDividendAmt = new WinFormsField("OS-DIVIDEND-AMT", "OSDividendAmt");
        public static WinFormsField NettTaxAmt = new WinFormsField("NETT-TAX-AMT", "NettTaxAmt");
        public static WinFormsField UnitDays = new WinFormsField("UNIT-DAYS", "UnitDays");
        public static WinFormsField PaymentDetails = new WinFormsField("PAYMENT-DETAILS", "PaymentDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
