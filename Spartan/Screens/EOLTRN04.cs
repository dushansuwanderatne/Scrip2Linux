using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLTRN04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLTRN04", "FormName");
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
        public static WinFormsField Desc1 = new WinFormsField("DESC-1", "Desc1");
        public static WinFormsField SellUnits1 = new WinFormsField("SELL-UNITS-1", "SellUnits1");
        public static WinFormsField TaxableAmt1 = new WinFormsField("TAXABLE-AMT-1", "TaxableAmt1");
        public static WinFormsField Tax1 = new WinFormsField("TAX-1", "Tax1");
        public static WinFormsField Nic1 = new WinFormsField("NIC-1", "Nic1");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Desc2 = new WinFormsField("DESC-2", "Desc2");
        public static WinFormsField SellUnits2 = new WinFormsField("SELL-UNITS-2", "SellUnits2");
        public static WinFormsField TaxableAmt2 = new WinFormsField("TAXABLE-AMT-2", "TaxableAmt2");
        public static WinFormsField Tax2 = new WinFormsField("TAX-2", "Tax2");
        public static WinFormsField Nic2 = new WinFormsField("NIC-2", "Nic2");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Desc3 = new WinFormsField("DESC-3", "Desc3");
        public static WinFormsField SellUnits3 = new WinFormsField("SELL-UNITS-3", "SellUnits3");
        public static WinFormsField TaxableAmt3 = new WinFormsField("TAXABLE-AMT-3", "TaxableAmt3");
        public static WinFormsField Tax3 = new WinFormsField("TAX-3", "Tax3");
        public static WinFormsField Nic3 = new WinFormsField("NIC-3", "Nic3");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Desc4 = new WinFormsField("DESC-4", "Desc4");
        public static WinFormsField SellUnits4 = new WinFormsField("SELL-UNITS-4", "SellUnits4");
        public static WinFormsField TaxableAmt4 = new WinFormsField("TAXABLE-AMT-4", "TaxableAmt4");
        public static WinFormsField Tax4 = new WinFormsField("TAX-4", "Tax4");
        public static WinFormsField Nic4 = new WinFormsField("NIC-4", "Nic4");
        public static WinFormsField Desc5 = new WinFormsField("DESC-5", "Desc5");
        public static WinFormsField SellUnits5 = new WinFormsField("SELL-UNITS-5", "SellUnits5");
        public static WinFormsField TaxableAmt5 = new WinFormsField("TAXABLE-AMT-5", "TaxableAmt5");
        public static WinFormsField Tax5 = new WinFormsField("TAX-5", "Tax5");
        public static WinFormsField Nic5 = new WinFormsField("NIC-5", "Nic5");
        public static WinFormsField Desc6 = new WinFormsField("DESC-6", "Desc6");
        public static WinFormsField SellUnits6 = new WinFormsField("SELL-UNITS-6", "SellUnits6");
        public static WinFormsField TaxableAmt6 = new WinFormsField("TAXABLE-AMT-6", "TaxableAmt6");
        public static WinFormsField Tax6 = new WinFormsField("TAX-6", "Tax6");
        public static WinFormsField Nic6 = new WinFormsField("NIC-6", "Nic6");
        public static WinFormsField Desc7 = new WinFormsField("DESC-7", "Desc7");
        public static WinFormsField SellUnits7 = new WinFormsField("SELL-UNITS-7", "SellUnits7");
        public static WinFormsField TaxableAmt7 = new WinFormsField("TAXABLE-AMT-7", "TaxableAmt7");
        public static WinFormsField Tax7 = new WinFormsField("TAX-7", "Tax7");
        public static WinFormsField Nic7 = new WinFormsField("NIC-7", "Nic7");
        public static WinFormsField Desc8 = new WinFormsField("DESC-8", "Desc8");
        public static WinFormsField SellUnits8 = new WinFormsField("SELL-UNITS-8", "SellUnits8");
        public static WinFormsField TaxableAmt8 = new WinFormsField("TAXABLE-AMT-8", "TaxableAmt8");
        public static WinFormsField Tax8 = new WinFormsField("TAX-8", "Tax8");
        public static WinFormsField Nic8 = new WinFormsField("NIC-8", "Nic8");
        public static WinFormsField ForfeitureUnits = new WinFormsField("FORFEITURE-UNITS", "ForfeitureUnits");
        public static WinFormsField TotalTransUnits = new WinFormsField("TOTAL-TRANS-UNITS", "TotalTransUnits");
        public static WinFormsField TotalTaxableAmt = new WinFormsField("TOTAL-TAXABLE-AMT", "TotalTaxableAmt");
        public static WinFormsField TaxAmountDue = new WinFormsField("TAX-AMOUNT-DUE", "TaxAmountDue");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField TotalLiability = new WinFormsField("TOTAL-LIABILITY", "TotalLiability");
        public static WinFormsField DirectCreditIns = new WinFormsField("DIRECT-CREDIT-INS", "DirectCreditIns");
        public static WinFormsField ForwardingIns = new WinFormsField("FORWARDING-INS", "ForwardingIns");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Residue1 = new WinFormsField("RESIDUE-1", "Residue1");
        public static WinFormsField Residue2 = new WinFormsField("RESIDUE-2", "Residue2");
        public static WinFormsField Residue3 = new WinFormsField("RESIDUE-3", "Residue3");
        public static WinFormsField Residue4 = new WinFormsField("RESIDUE-4", "Residue4");
        public static WinFormsField Residue5 = new WinFormsField("RESIDUE-5", "Residue5");
        public static WinFormsField Residue6 = new WinFormsField("RESIDUE-6", "Residue6");
        public static WinFormsField Residue7 = new WinFormsField("RESIDUE-7", "Residue7");
        public static WinFormsField Residue8 = new WinFormsField("RESIDUE-8", "Residue8");
        public static WinFormsField TotalResidue = new WinFormsField("TOTAL-RESIDUE", "TotalResidue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
