using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00801", "FormName");
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
        public static WinFormsField NINumber = new WinFormsField("NI-NUMBER", "NINumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField AvailUnits1 = new WinFormsField("AVAIL-UNITS-1", "AvailUnits1");
        public static WinFormsField ProRataUnits1 = new WinFormsField("PRO-RATA-UNITS-1", "ProRataUnits1");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField AvailUnits2 = new WinFormsField("AVAIL-UNITS-2", "AvailUnits2");
        public static WinFormsField ProRataUnits2 = new WinFormsField("PRO-RATA-UNITS-2", "ProRataUnits2");
        public static WinFormsField Register3 = new WinFormsField("REGISTER-3", "Register3");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField AvailUnits3 = new WinFormsField("AVAIL-UNITS-3", "AvailUnits3");
        public static WinFormsField ProRataUnits3 = new WinFormsField("PRO-RATA-UNITS-3", "ProRataUnits3");
        public static WinFormsField Register4 = new WinFormsField("REGISTER-4", "Register4");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField AvailUnits4 = new WinFormsField("AVAIL-UNITS-4", "AvailUnits4");
        public static WinFormsField ProRataUnits4 = new WinFormsField("PRO-RATA-UNITS-4", "ProRataUnits4");
        public static WinFormsField Register5 = new WinFormsField("REGISTER-5", "Register5");
        public static WinFormsField CertID5 = new WinFormsField("CERT-ID-5", "CertID5");
        public static WinFormsField AvailUnits5 = new WinFormsField("AVAIL-UNITS-5", "AvailUnits5");
        public static WinFormsField ProRataUnits5 = new WinFormsField("PRO-RATA-UNITS-5", "ProRataUnits5");
        public static WinFormsField Register6 = new WinFormsField("REGISTER-6", "Register6");
        public static WinFormsField CertID6 = new WinFormsField("CERT-ID-6", "CertID6");
        public static WinFormsField AvailUnits6 = new WinFormsField("AVAIL-UNITS-6", "AvailUnits6");
        public static WinFormsField ProRataUnits6 = new WinFormsField("PRO-RATA-UNITS-6", "ProRataUnits6");
        public static WinFormsField Register7 = new WinFormsField("REGISTER-7", "Register7");
        public static WinFormsField CertID7 = new WinFormsField("CERT-ID-7", "CertID7");
        public static WinFormsField AvailUnits7 = new WinFormsField("AVAIL-UNITS-7", "AvailUnits7");
        public static WinFormsField ProRataUnits7 = new WinFormsField("PRO-RATA-UNITS-7", "ProRataUnits7");
        public static WinFormsField Register8 = new WinFormsField("REGISTER-8", "Register8");
        public static WinFormsField CertID8 = new WinFormsField("CERT-ID-8", "CertID8");
        public static WinFormsField AvailUnits8 = new WinFormsField("AVAIL-UNITS-8", "AvailUnits8");
        public static WinFormsField ProRataUnits8 = new WinFormsField("PRO-RATA-UNITS-8", "ProRataUnits8");
        public static WinFormsField Register9 = new WinFormsField("REGISTER-9", "Register9");
        public static WinFormsField CertID9 = new WinFormsField("CERT-ID-9", "CertID9");
        public static WinFormsField AvailUnits9 = new WinFormsField("AVAIL-UNITS-9", "AvailUnits9");
        public static WinFormsField ProRataUnits9 = new WinFormsField("PRO-RATA-UNITS-9", "ProRataUnits9");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Register10 = new WinFormsField("REGISTER-10", "Register10");
        public static WinFormsField CertID10 = new WinFormsField("CERT-ID-10", "CertID10");
        public static WinFormsField AvailUnits10 = new WinFormsField("AVAIL-UNITS-10", "AvailUnits10");
        public static WinFormsField ProRataUnits10 = new WinFormsField("PRO-RATA-UNITS-10", "ProRataUnits10");
        public static WinFormsField TotalAvailUnits = new WinFormsField("TOTAL-AVAIL-UNITS", "TotalAvailUnits");
        public static WinFormsField TotalProRataUnits = new WinFormsField("TOTAL-PRO-RATA-UNITS", "TotalProRataUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
