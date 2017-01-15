using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLTRNPL

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLTRNPL", "FormName");
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
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField NINumber = new WinFormsField("NI-NUMBER", "NINumber");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField AvailUnits1 = new WinFormsField("AVAIL-UNITS-1", "AvailUnits1");
        public static WinFormsField SellUnits1 = new WinFormsField("SELL-UNITS-1", "SellUnits1");
        public static WinFormsField Register11 = new WinFormsField("REGISTER-11", "Register11");
        public static WinFormsField CertID11 = new WinFormsField("CERT-ID-11", "CertID11");
        public static WinFormsField AvailUnits11 = new WinFormsField("AVAIL-UNITS-11", "AvailUnits11");
        public static WinFormsField SellUnits11 = new WinFormsField("SELL-UNITS-11", "SellUnits11");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField AvailUnits2 = new WinFormsField("AVAIL-UNITS-2", "AvailUnits2");
        public static WinFormsField SellUnits2 = new WinFormsField("SELL-UNITS-2", "SellUnits2");
        public static WinFormsField Register12 = new WinFormsField("REGISTER-12", "Register12");
        public static WinFormsField CertID12 = new WinFormsField("CERT-ID-12", "CertID12");
        public static WinFormsField AvailUnits12 = new WinFormsField("AVAIL-UNITS-12", "AvailUnits12");
        public static WinFormsField SellUnits12 = new WinFormsField("SELL-UNITS-12", "SellUnits12");
        public static WinFormsField Register3 = new WinFormsField("REGISTER-3", "Register3");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField AvailUnits3 = new WinFormsField("AVAIL-UNITS-3", "AvailUnits3");
        public static WinFormsField SellUnits3 = new WinFormsField("SELL-UNITS-3", "SellUnits3");
        public static WinFormsField Register13 = new WinFormsField("REGISTER-13", "Register13");
        public static WinFormsField CertID13 = new WinFormsField("CERT-ID-13", "CertID13");
        public static WinFormsField AvailUnits13 = new WinFormsField("AVAIL-UNITS-13", "AvailUnits13");
        public static WinFormsField SellUnits13 = new WinFormsField("SELL-UNITS-13", "SellUnits13");
        public static WinFormsField Register4 = new WinFormsField("REGISTER-4", "Register4");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField AvailUnits4 = new WinFormsField("AVAIL-UNITS-4", "AvailUnits4");
        public static WinFormsField SellUnits4 = new WinFormsField("SELL-UNITS-4", "SellUnits4");
        public static WinFormsField Register14 = new WinFormsField("REGISTER-14", "Register14");
        public static WinFormsField CertID14 = new WinFormsField("CERT-ID-14", "CertID14");
        public static WinFormsField AvailUnits14 = new WinFormsField("AVAIL-UNITS-14", "AvailUnits14");
        public static WinFormsField SellUnits14 = new WinFormsField("SELL-UNITS-14", "SellUnits14");
        public static WinFormsField Register5 = new WinFormsField("REGISTER-5", "Register5");
        public static WinFormsField CertID5 = new WinFormsField("CERT-ID-5", "CertID5");
        public static WinFormsField AvailUnits5 = new WinFormsField("AVAIL-UNITS-5", "AvailUnits5");
        public static WinFormsField SellUnits5 = new WinFormsField("SELL-UNITS-5", "SellUnits5");
        public static WinFormsField Register15 = new WinFormsField("REGISTER-15", "Register15");
        public static WinFormsField CertID15 = new WinFormsField("CERT-ID-15", "CertID15");
        public static WinFormsField SellUnits15 = new WinFormsField("SELL-UNITS-15", "SellUnits15");
        //public static WinFormsField SellUnits15 = new WinFormsField("SELL-UNITS-15", "SellUnits15");
        public static WinFormsField Register6 = new WinFormsField("REGISTER-6", "Register6");
        public static WinFormsField CertID6 = new WinFormsField("CERT-ID-6", "CertID6");
        public static WinFormsField AvailUnits6 = new WinFormsField("AVAIL-UNITS-6", "AvailUnits6");
        public static WinFormsField SellUnits6 = new WinFormsField("SELL-UNITS-6", "SellUnits6");
        public static WinFormsField Register16 = new WinFormsField("REGISTER-16", "Register16");
        public static WinFormsField CertID16 = new WinFormsField("CERT-ID-16", "CertID16");
        public static WinFormsField AvailUnits16 = new WinFormsField("AVAIL-UNITS-16", "AvailUnits16");
        public static WinFormsField SellUnits16 = new WinFormsField("SELL-UNITS-16", "SellUnits16");
        public static WinFormsField Register7 = new WinFormsField("REGISTER-7", "Register7");
        public static WinFormsField CertID7 = new WinFormsField("CERT-ID-7", "CertID7");
        public static WinFormsField AvailUnits7 = new WinFormsField("AVAIL-UNITS-7", "AvailUnits7");
        public static WinFormsField SellUnits7 = new WinFormsField("SELL-UNITS-7", "SellUnits7");
        public static WinFormsField Register17 = new WinFormsField("REGISTER-17", "Register17");
        public static WinFormsField CertID17 = new WinFormsField("CERT-ID-17", "CertID17");
        public static WinFormsField AvailUnits17 = new WinFormsField("AVAIL-UNITS-17", "AvailUnits17");
        public static WinFormsField SellUnits17 = new WinFormsField("SELL-UNITS-17", "SellUnits17");
        public static WinFormsField Register8 = new WinFormsField("REGISTER-8", "Register8");
        public static WinFormsField CertID8 = new WinFormsField("CERT-ID-8", "CertID8");
        public static WinFormsField AvailUnits8 = new WinFormsField("AVAIL-UNITS-8", "AvailUnits8");
        public static WinFormsField SellUnits8 = new WinFormsField("SELL-UNITS-8", "SellUnits8");
        public static WinFormsField Register18 = new WinFormsField("REGISTER-18", "Register18");
        public static WinFormsField CertID18 = new WinFormsField("CERT-ID-18", "CertID18");
        public static WinFormsField AvailUnits18 = new WinFormsField("AVAIL-UNITS-18", "AvailUnits18");
        public static WinFormsField SellUnits18 = new WinFormsField("SELL-UNITS-18", "SellUnits18");
        public static WinFormsField Register9 = new WinFormsField("REGISTER-9", "Register9");
        public static WinFormsField CertID9 = new WinFormsField("CERT-ID-9", "CertID9");
        public static WinFormsField AvailUnits9 = new WinFormsField("AVAIL-UNITS-9", "AvailUnits9");
        public static WinFormsField SellUnits9 = new WinFormsField("SELL-UNITS-9", "SellUnits9");
        public static WinFormsField Register19 = new WinFormsField("REGISTER-19", "Register19");
        public static WinFormsField CertID19 = new WinFormsField("CERT-ID-19", "CertID19");
        public static WinFormsField AvailUnits19 = new WinFormsField("AVAIL-UNITS-19", "AvailUnits19");
        public static WinFormsField SellUnits19 = new WinFormsField("SELL-UNITS-19", "SellUnits19");
        public static WinFormsField Register10 = new WinFormsField("REGISTER-10", "Register10");
        public static WinFormsField CertID10 = new WinFormsField("CERT-ID-10", "CertID10");
        public static WinFormsField AvailUnits10 = new WinFormsField("AVAIL-UNITS-10", "AvailUnits10");
        public static WinFormsField SellUnits10 = new WinFormsField("SELL-UNITS-10", "SellUnits10");
        public static WinFormsField Register20 = new WinFormsField("REGISTER-20", "Register20");
        public static WinFormsField CertID20 = new WinFormsField("CERT-ID-20", "CertID20");
        public static WinFormsField AvailUnits20 = new WinFormsField("AVAIL-UNITS-20", "AvailUnits20");
        public static WinFormsField SellUnits20 = new WinFormsField("SELL-UNITS-20", "SellUnits20");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
