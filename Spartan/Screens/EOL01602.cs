using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01602", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField SellUnits1 = new WinFormsField("SELL-UNITS-1", "SellUnits1");
        public static WinFormsField LoanAmt1 = new WinFormsField("LOAN-AMT-1", "LoanAmt1");
        public static WinFormsField BonusUnits1 = new WinFormsField("BONUS-UNITS-1", "BonusUnits1");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField SellUnits2 = new WinFormsField("SELL-UNITS-2", "SellUnits2");
        public static WinFormsField LoanAmt2 = new WinFormsField("LOAN-AMT-2", "LoanAmt2");
        public static WinFormsField BonusUnits2 = new WinFormsField("BONUS-UNITS-2", "BonusUnits2");
        public static WinFormsField Register3 = new WinFormsField("REGISTER-3", "Register3");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField SellUnits3 = new WinFormsField("SELL-UNITS-3", "SellUnits3");
        public static WinFormsField LoanAmt3 = new WinFormsField("LOAN-AMT-3", "LoanAmt3");
        public static WinFormsField BonusUnits3 = new WinFormsField("BONUS-UNITS-3", "BonusUnits3");
        public static WinFormsField Register4 = new WinFormsField("REGISTER-4", "Register4");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField SellUnits4 = new WinFormsField("SELL-UNITS-4", "SellUnits4");
        public static WinFormsField LoanAmt4 = new WinFormsField("LOAN-AMT-4", "LoanAmt4");
        public static WinFormsField BonusUnits4 = new WinFormsField("BONUS-UNITS-4", "BonusUnits4");
        public static WinFormsField Register5 = new WinFormsField("REGISTER-5", "Register5");
        public static WinFormsField CertID5 = new WinFormsField("CERT-ID-5", "CertID5");
        public static WinFormsField SellUnits5 = new WinFormsField("SELL-UNITS-5", "SellUnits5");
        public static WinFormsField LoanAmt5 = new WinFormsField("LOAN-AMT-5", "LoanAmt5");
        public static WinFormsField BonusUnits5 = new WinFormsField("BONUS-UNITS-5", "BonusUnits5");
        public static WinFormsField Register6 = new WinFormsField("REGISTER-6", "Register6");
        public static WinFormsField CertID6 = new WinFormsField("CERT-ID-6", "CertID6");
        public static WinFormsField SellUnits6 = new WinFormsField("SELL-UNITS-6", "SellUnits6");
        public static WinFormsField LoanAmt6 = new WinFormsField("LOAN-AMT-6", "LoanAmt6");
        public static WinFormsField BonusUnits6 = new WinFormsField("BONUS-UNITS-6", "BonusUnits6");
        public static WinFormsField Register7 = new WinFormsField("REGISTER-7", "Register7");
        public static WinFormsField CertID7 = new WinFormsField("CERT-ID-7", "CertID7");
        public static WinFormsField SellUnits7 = new WinFormsField("SELL-UNITS-7", "SellUnits7");
        public static WinFormsField LoanAmt7 = new WinFormsField("LOAN-AMT-7", "LoanAmt7");
        public static WinFormsField BonusUnits7 = new WinFormsField("BONUS-UNITS-7", "BonusUnits7");
        public static WinFormsField Register8 = new WinFormsField("REGISTER-8", "Register8");
        public static WinFormsField CertID8 = new WinFormsField("CERT-ID-8", "CertID8");
        public static WinFormsField SellUnits8 = new WinFormsField("SELL-UNITS-8", "SellUnits8");
        public static WinFormsField LoanAmt8 = new WinFormsField("LOAN-AMT-8", "LoanAmt8");
        public static WinFormsField BonusUnits8 = new WinFormsField("BONUS-UNITS-8", "BonusUnits8");
        public static WinFormsField Register9 = new WinFormsField("REGISTER-9", "Register9");
        public static WinFormsField CertID9 = new WinFormsField("CERT-ID-9", "CertID9");
        public static WinFormsField SellUnits9 = new WinFormsField("SELL-UNITS-9", "SellUnits9");
        public static WinFormsField LoanAmt9 = new WinFormsField("LOAN-AMT-9", "LoanAmt9");
        public static WinFormsField BonusUnits9 = new WinFormsField("BONUS-UNITS-9", "BonusUnits9");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Register10 = new WinFormsField("REGISTER-10", "Register10");
        public static WinFormsField CertID10 = new WinFormsField("CERT-ID-10", "CertID10");
        public static WinFormsField SellUnits10 = new WinFormsField("SELL-UNITS-10", "SellUnits10");
        public static WinFormsField LoanAmt10 = new WinFormsField("LOAN-AMT-10", "LoanAmt10");
        public static WinFormsField BonusUnits10 = new WinFormsField("BONUS-UNITS-10", "BonusUnits10");
        public static WinFormsField TotalSellUnits = new WinFormsField("TOTAL-SELL-UNITS", "TotalSellUnits");
        public static WinFormsField TotalLoanAmt = new WinFormsField("TOTAL-LOAN-AMT", "TotalLoanAmt");
        public static WinFormsField TotalBonusUnits = new WinFormsField("TOTAL-BONUS-UNITS", "TotalBonusUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
