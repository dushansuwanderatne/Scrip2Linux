using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLTRNCF

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLTRNCF", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TotalPooled = new WinFormsField("TOTAL-POOLED", "TotalPooled");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField NINumber = new WinFormsField("NI-NUMBER", "NINumber");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField PoolInd1 = new WinFormsField("POOL-IND-1", "PoolInd1");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField AvailUnits1 = new WinFormsField("AVAIL-UNITS-1", "AvailUnits1");
        public static WinFormsField SellUnits1 = new WinFormsField("SELL-UNITS-1", "SellUnits1");
        public static WinFormsField Tax1 = new WinFormsField("TAX-1", "Tax1");
        public static WinFormsField PoolInd11 = new WinFormsField("POOL-IND-11", "PoolInd11");
        public static WinFormsField Register11 = new WinFormsField("REGISTER-11", "Register11");
        public static WinFormsField CertID11 = new WinFormsField("CERT-ID-11", "CertID11");
        public static WinFormsField AvailUnits11 = new WinFormsField("AVAIL-UNITS-11", "AvailUnits11");
        public static WinFormsField SellUnits11 = new WinFormsField("SELL-UNITS-11", "SellUnits11");
        public static WinFormsField Tax11 = new WinFormsField("TAX-11", "Tax11");
        public static WinFormsField PoolInd2 = new WinFormsField("POOL-IND-2", "PoolInd2");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField AvailUnits2 = new WinFormsField("AVAIL-UNITS-2", "AvailUnits2");
        public static WinFormsField SellUnits2 = new WinFormsField("SELL-UNITS-2", "SellUnits2");
        public static WinFormsField Tax2 = new WinFormsField("TAX-2", "Tax2");
        public static WinFormsField PoolInd12 = new WinFormsField("POOL-IND-12", "PoolInd12");
        public static WinFormsField Register12 = new WinFormsField("REGISTER-12", "Register12");
        public static WinFormsField CertID12 = new WinFormsField("CERT-ID-12", "CertID12");
        public static WinFormsField AvailUnits12 = new WinFormsField("AVAIL-UNITS-12", "AvailUnits12");
        public static WinFormsField SellUnits12 = new WinFormsField("SELL-UNITS-12", "SellUnits12");
        public static WinFormsField Tax12 = new WinFormsField("TAX-12", "Tax12");
        public static WinFormsField PoolInd3 = new WinFormsField("POOL-IND-3", "PoolInd3");
        public static WinFormsField Register3 = new WinFormsField("REGISTER-3", "Register3");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField AvailUnits3 = new WinFormsField("AVAIL-UNITS-3", "AvailUnits3");
        public static WinFormsField SellUnits3 = new WinFormsField("SELL-UNITS-3", "SellUnits3");
        public static WinFormsField Tax3 = new WinFormsField("TAX-3", "Tax3");
        public static WinFormsField PoolInd13 = new WinFormsField("POOL-IND-13", "PoolInd13");
        public static WinFormsField Register13 = new WinFormsField("REGISTER-13", "Register13");
        public static WinFormsField CertID13 = new WinFormsField("CERT-ID-13", "CertID13");
        public static WinFormsField AvailUnits13 = new WinFormsField("AVAIL-UNITS-13", "AvailUnits13");
        public static WinFormsField SellUnits13 = new WinFormsField("SELL-UNITS-13", "SellUnits13");
        public static WinFormsField Tax13 = new WinFormsField("TAX-13", "Tax13");
        public static WinFormsField PoolInd4 = new WinFormsField("POOL-IND-4", "PoolInd4");
        public static WinFormsField Register4 = new WinFormsField("REGISTER-4", "Register4");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField AvailUnits4 = new WinFormsField("AVAIL-UNITS-4", "AvailUnits4");
        public static WinFormsField SellUnits4 = new WinFormsField("SELL-UNITS-4", "SellUnits4");
        public static WinFormsField Tax4 = new WinFormsField("TAX-4", "Tax4");
        public static WinFormsField PoolInd14 = new WinFormsField("POOL-IND-14", "PoolInd14");
        public static WinFormsField Register14 = new WinFormsField("REGISTER-14", "Register14");
        public static WinFormsField CertID14 = new WinFormsField("CERT-ID-14", "CertID14");
        public static WinFormsField AvailUnits14 = new WinFormsField("AVAIL-UNITS-14", "AvailUnits14");
        public static WinFormsField SellUnits14 = new WinFormsField("SELL-UNITS-14", "SellUnits14");
        public static WinFormsField Tax14 = new WinFormsField("TAX-14", "Tax14");
        public static WinFormsField PoolInd5 = new WinFormsField("POOL-IND-5", "PoolInd5");
        public static WinFormsField Register5 = new WinFormsField("REGISTER-5", "Register5");
        public static WinFormsField CertID5 = new WinFormsField("CERT-ID-5", "CertID5");
        public static WinFormsField AvailUnits5 = new WinFormsField("AVAIL-UNITS-5", "AvailUnits5");
        public static WinFormsField SellUnits5 = new WinFormsField("SELL-UNITS-5", "SellUnits5");
        public static WinFormsField Tax5 = new WinFormsField("TAX-5", "Tax5");
        public static WinFormsField PoolInd15 = new WinFormsField("POOL-IND-15", "PoolInd15");
        public static WinFormsField Register15 = new WinFormsField("REGISTER-15", "Register15");
        public static WinFormsField CertID15 = new WinFormsField("CERT-ID-15", "CertID15");
        public static WinFormsField AvailUnits15 = new WinFormsField("AVAIL-UNITS-15", "AvailUnits15");
        public static WinFormsField SellUnits15 = new WinFormsField("SELL-UNITS-15", "SellUnits15");
        public static WinFormsField Tax15 = new WinFormsField("TAX-15", "Tax15");
        public static WinFormsField PoolInd6 = new WinFormsField("POOL-IND-6", "PoolInd6");
        public static WinFormsField Register6 = new WinFormsField("REGISTER-6", "Register6");
        public static WinFormsField CertID6 = new WinFormsField("CERT-ID-6", "CertID6");
        public static WinFormsField AvailUnits6 = new WinFormsField("AVAIL-UNITS-6", "AvailUnits6");
        public static WinFormsField SellUnits6 = new WinFormsField("SELL-UNITS-6", "SellUnits6");
        public static WinFormsField Tax6 = new WinFormsField("TAX-6", "Tax6");
        public static WinFormsField PoolInd16 = new WinFormsField("POOL-IND-16", "PoolInd16");
        public static WinFormsField Register16 = new WinFormsField("REGISTER-16", "Register16");
        public static WinFormsField CertID16 = new WinFormsField("CERT-ID-16", "CertID16");
        public static WinFormsField AvailUnits16 = new WinFormsField("AVAIL-UNITS-16", "AvailUnits16");
        public static WinFormsField SellUnits16 = new WinFormsField("SELL-UNITS-16", "SellUnits16");
        public static WinFormsField Tax16 = new WinFormsField("TAX-16", "Tax16");
        public static WinFormsField PoolInd7 = new WinFormsField("POOL-IND-7", "PoolInd7");
        public static WinFormsField Register7 = new WinFormsField("REGISTER-7", "Register7");
        public static WinFormsField CertID7 = new WinFormsField("CERT-ID-7", "CertID7");
        public static WinFormsField AvailUnits7 = new WinFormsField("AVAIL-UNITS-7", "AvailUnits7");
        public static WinFormsField SellUnits7 = new WinFormsField("SELL-UNITS-7", "SellUnits7");
        public static WinFormsField Tax7 = new WinFormsField("TAX-7", "Tax7");
        public static WinFormsField PoolInd17 = new WinFormsField("POOL-IND-17", "PoolInd17");
        public static WinFormsField Register17 = new WinFormsField("REGISTER-17", "Register17");
        public static WinFormsField CertID17 = new WinFormsField("CERT-ID-17", "CertID17");
        public static WinFormsField AvailUnits17 = new WinFormsField("AVAIL-UNITS-17", "AvailUnits17");
        public static WinFormsField SellUnits17 = new WinFormsField("SELL-UNITS-17", "SellUnits17");
        public static WinFormsField Tax17 = new WinFormsField("TAX-17", "Tax17");
        public static WinFormsField PoolInd8 = new WinFormsField("POOL-IND-8", "PoolInd8");
        public static WinFormsField Register8 = new WinFormsField("REGISTER-8", "Register8");
        public static WinFormsField CertID8 = new WinFormsField("CERT-ID-8", "CertID8");
        public static WinFormsField AvailUnits8 = new WinFormsField("AVAIL-UNITS-8", "AvailUnits8");
        public static WinFormsField SellUnits8 = new WinFormsField("SELL-UNITS-8", "SellUnits8");
        public static WinFormsField Tax8 = new WinFormsField("TAX-8", "Tax8");
        public static WinFormsField PoolInd18 = new WinFormsField("POOL-IND-18", "PoolInd18");
        public static WinFormsField Register18 = new WinFormsField("REGISTER-18", "Register18");
        public static WinFormsField CertID18 = new WinFormsField("CERT-ID-18", "CertID18");
        public static WinFormsField AvailUnits18 = new WinFormsField("AVAIL-UNITS-18", "AvailUnits18");
        public static WinFormsField SellUnits18 = new WinFormsField("SELL-UNITS-18", "SellUnits18");
        public static WinFormsField Tax18 = new WinFormsField("TAX-18", "Tax18");
        public static WinFormsField PoolInd9 = new WinFormsField("POOL-IND-9", "PoolInd9");
        public static WinFormsField Register9 = new WinFormsField("REGISTER-9", "Register9");
        public static WinFormsField CertID9 = new WinFormsField("CERT-ID-9", "CertID9");
        public static WinFormsField AvailUnits9 = new WinFormsField("AVAIL-UNITS-9", "AvailUnits9");
        public static WinFormsField SellUnits9 = new WinFormsField("SELL-UNITS-9", "SellUnits9");
        public static WinFormsField Tax9 = new WinFormsField("TAX-9", "Tax9");
        public static WinFormsField PoolInd19 = new WinFormsField("POOL-IND-19", "PoolInd19");
        public static WinFormsField Register19 = new WinFormsField("REGISTER-19", "Register19");
        public static WinFormsField CertID19 = new WinFormsField("CERT-ID-19", "CertID19");
        public static WinFormsField AvailUnits19 = new WinFormsField("AVAIL-UNITS-19", "AvailUnits19");
        public static WinFormsField SellUnits19 = new WinFormsField("SELL-UNITS-19", "SellUnits19");
        public static WinFormsField Tax19 = new WinFormsField("TAX-19", "Tax19");
        public static WinFormsField PoolInd10 = new WinFormsField("POOL-IND-10", "PoolInd10");
        public static WinFormsField Register10 = new WinFormsField("REGISTER-10", "Register10");
        public static WinFormsField CertID10 = new WinFormsField("CERT-ID-10", "CertID10");
        public static WinFormsField AvailUnits10 = new WinFormsField("AVAIL-UNITS-10", "AvailUnits10");
        public static WinFormsField SellUnits10 = new WinFormsField("SELL-UNITS-10", "SellUnits10");
        public static WinFormsField Tax10 = new WinFormsField("TAX-10", "Tax10");
        public static WinFormsField PoolInd20 = new WinFormsField("POOL-IND-20", "PoolInd20");
        public static WinFormsField Register20 = new WinFormsField("REGISTER-20", "Register20");
        public static WinFormsField CertID20 = new WinFormsField("CERT-ID-20", "CertID20");
        public static WinFormsField AvailUnits20 = new WinFormsField("AVAIL-UNITS-20", "AvailUnits20");
        public static WinFormsField SellUnits20 = new WinFormsField("SELL-UNITS-20", "SellUnits20");
        public static WinFormsField Tax20 = new WinFormsField("TAX-20", "Tax20");
        public static WinFormsField TaxAmountDue = new WinFormsField("TAX-AMOUNT-DUE", "TaxAmountDue");
        public static WinFormsField ForwardingIns = new WinFormsField("FORWARDING-INS", "ForwardingIns");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
