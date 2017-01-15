using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLTRN03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLTRN03", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField NINumber = new WinFormsField("NI-NUMBER", "NINumber");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField SellUnits1 = new WinFormsField("SELL-UNITS-1", "SellUnits1");
        public static WinFormsField Residue1 = new WinFormsField("RESIDUE-1", "Residue1");
        public static WinFormsField TaxableAmt1 = new WinFormsField("TAXABLE-AMT-1", "TaxableAmt1");
        public static WinFormsField Tax1 = new WinFormsField("TAX-1", "Tax1");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField SellUnits2 = new WinFormsField("SELL-UNITS-2", "SellUnits2");
        public static WinFormsField Residue2 = new WinFormsField("RESIDUE-2", "Residue2");
        public static WinFormsField TaxableAmt2 = new WinFormsField("TAXABLE-AMT-2", "TaxableAmt2");
        public static WinFormsField Tax2 = new WinFormsField("TAX-2", "Tax2");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Register3 = new WinFormsField("REGISTER-3", "Register3");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField SellUnits3 = new WinFormsField("SELL-UNITS-3", "SellUnits3");
        public static WinFormsField Residue3 = new WinFormsField("RESIDUE-3", "Residue3");
        public static WinFormsField TaxableAmt3 = new WinFormsField("TAXABLE-AMT-3", "TaxableAmt3");
        public static WinFormsField Tax3 = new WinFormsField("TAX-3", "Tax3");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Register4 = new WinFormsField("REGISTER-4", "Register4");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField SellUnits4 = new WinFormsField("SELL-UNITS-4", "SellUnits4");
        public static WinFormsField Residue4 = new WinFormsField("RESIDUE-4", "Residue4");
        public static WinFormsField TaxableAmt4 = new WinFormsField("TAXABLE-AMT-4", "TaxableAmt4");
        public static WinFormsField Tax4 = new WinFormsField("TAX-4", "Tax4");
        public static WinFormsField Register5 = new WinFormsField("REGISTER-5", "Register5");
        public static WinFormsField CertID5 = new WinFormsField("CERT-ID-5", "CertID5");
        public static WinFormsField SellUnits5 = new WinFormsField("SELL-UNITS-5", "SellUnits5");
        public static WinFormsField Residue5 = new WinFormsField("RESIDUE-5", "Residue5");
        public static WinFormsField TaxableAmt5 = new WinFormsField("TAXABLE-AMT-5", "TaxableAmt5");
        public static WinFormsField Tax5 = new WinFormsField("TAX-5", "Tax5");
        public static WinFormsField Register6 = new WinFormsField("REGISTER-6", "Register6");
        public static WinFormsField CertID6 = new WinFormsField("CERT-ID-6", "CertID6");
        public static WinFormsField SellUnits6 = new WinFormsField("SELL-UNITS-6", "SellUnits6");
        public static WinFormsField Residue6 = new WinFormsField("RESIDUE-6", "Residue6");
        public static WinFormsField TaxableAmt6 = new WinFormsField("TAXABLE-AMT-6", "TaxableAmt6");
        public static WinFormsField Tax6 = new WinFormsField("TAX-6", "Tax6");
        public static WinFormsField Register7 = new WinFormsField("REGISTER-7", "Register7");
        public static WinFormsField CertID7 = new WinFormsField("CERT-ID-7", "CertID7");
        public static WinFormsField SellUnits7 = new WinFormsField("SELL-UNITS-7", "SellUnits7");
        public static WinFormsField Residue7 = new WinFormsField("RESIDUE-7", "Residue7");
        public static WinFormsField TaxableAmt7 = new WinFormsField("TAXABLE-AMT-7", "TaxableAmt7");
        public static WinFormsField Tax7 = new WinFormsField("TAX-7", "Tax7");
        public static WinFormsField Register8 = new WinFormsField("REGISTER-8", "Register8");
        public static WinFormsField CertID8 = new WinFormsField("CERT-ID-8", "CertID8");
        public static WinFormsField SellUnits8 = new WinFormsField("SELL-UNITS-8", "SellUnits8");
        public static WinFormsField Residue8 = new WinFormsField("RESIDUE-8", "Residue8");
        public static WinFormsField TaxableAmt8 = new WinFormsField("TAXABLE-AMT-8", "TaxableAmt8");
        public static WinFormsField Tax8 = new WinFormsField("TAX-8", "Tax8");
        public static WinFormsField Register9 = new WinFormsField("REGISTER-9", "Register9");
        public static WinFormsField CertID9 = new WinFormsField("CERT-ID-9", "CertID9");
        public static WinFormsField SellUnits9 = new WinFormsField("SELL-UNITS-9", "SellUnits9");
        public static WinFormsField Residue9 = new WinFormsField("RESIDUE-9", "Residue9");
        public static WinFormsField TaxableAmt9 = new WinFormsField("TAXABLE-AMT-9", "TaxableAmt9");
        public static WinFormsField Tax9 = new WinFormsField("TAX-9", "Tax9");
        public static WinFormsField Register10 = new WinFormsField("REGISTER-10", "Register10");
        public static WinFormsField CertID10 = new WinFormsField("CERT-ID-10", "CertID10");
        public static WinFormsField SellUnits10 = new WinFormsField("SELL-UNITS-10", "SellUnits10");
        public static WinFormsField Residue10 = new WinFormsField("RESIDUE-10", "Residue10");
        public static WinFormsField TaxableAmt10 = new WinFormsField("TAXABLE-AMT-10", "TaxableAmt10");
        public static WinFormsField Tax10 = new WinFormsField("TAX-10", "Tax10");
        public static WinFormsField TotalSellUnits = new WinFormsField("TOTAL-SELL-UNITS", "TotalSellUnits");
        public static WinFormsField TotalResidue = new WinFormsField("TOTAL-RESIDUE", "TotalResidue");
        public static WinFormsField TotalTaxableAmt = new WinFormsField("TOTAL-TAXABLE-AMT", "TotalTaxableAmt");
        public static WinFormsField TaxAmountDue = new WinFormsField("TAX-AMOUNT-DUE", "TaxAmountDue");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
