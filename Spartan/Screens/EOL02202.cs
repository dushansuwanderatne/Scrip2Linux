using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02202", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField LeaverCode = new WinFormsField("LEAVER-CODE", "LeaverCode");
        public static WinFormsField LeaverCodeDesc = new WinFormsField("LEAVER-CODE-DESC", "LeaverCodeDesc");
        public static WinFormsField LvrProcessingDate = new WinFormsField("LVR-PROCESSING-DATE", "LvrProcessingDate");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassCodeDesc = new WinFormsField("CLASS-CODE-DESC", "ClassCodeDesc");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField CurrBal = new WinFormsField("CURR-BAL", "CurrBal");
        public static WinFormsField RelImm1 = new WinFormsField("REL-IMM-1", "RelImm1");
        public static WinFormsField MaintRest1 = new WinFormsField("MAINT-REST-1", "MaintRest1");
        public static WinFormsField ForfNow1 = new WinFormsField("FORF-NOW-1", "ForfNow1");
        public static WinFormsField AvailUnits1 = new WinFormsField("AVAIL-UNITS-1", "AvailUnits1");
        public static WinFormsField AvailDate1 = new WinFormsField("AVAIL-DATE-1", "AvailDate1");
        public static WinFormsField RestEndDate = new WinFormsField("REST-END-DATE", "RestEndDate");
        public static WinFormsField RelImm2 = new WinFormsField("REL-IMM-2", "RelImm2");
        public static WinFormsField MaintRest2 = new WinFormsField("MAINT-REST-2", "MaintRest2");
        public static WinFormsField ForfNow2 = new WinFormsField("FORF-NOW-2", "ForfNow2");
        public static WinFormsField AvailUnits2 = new WinFormsField("AVAIL-UNITS-2", "AvailUnits2");
        public static WinFormsField AvailDate2 = new WinFormsField("AVAIL-DATE-2", "AvailDate2");
        public static WinFormsField RelImm3 = new WinFormsField("REL-IMM-3", "RelImm3");
        public static WinFormsField MaintRest3 = new WinFormsField("MAINT-REST-3", "MaintRest3");
        public static WinFormsField ForfNow3 = new WinFormsField("FORF-NOW-3", "ForfNow3");
        public static WinFormsField AvailUnits3 = new WinFormsField("AVAIL-UNITS-3", "AvailUnits3");
        public static WinFormsField AvailDate3 = new WinFormsField("AVAIL-DATE-3", "AvailDate3");
        public static WinFormsField RelImm4 = new WinFormsField("REL-IMM-4", "RelImm4");
        public static WinFormsField MaintRest4 = new WinFormsField("MAINT-REST-4", "MaintRest4");
        public static WinFormsField ForfNow4 = new WinFormsField("FORF-NOW-4", "ForfNow4");
        public static WinFormsField AvailUnits4 = new WinFormsField("AVAIL-UNITS-4", "AvailUnits4");
        public static WinFormsField AvailDate4 = new WinFormsField("AVAIL-DATE-4", "AvailDate4");
        public static WinFormsField RelImm5 = new WinFormsField("REL-IMM-5", "RelImm5");
        public static WinFormsField MaintRest5 = new WinFormsField("MAINT-REST-5", "MaintRest5");
        public static WinFormsField ForfNow5 = new WinFormsField("FORF-NOW-5", "ForfNow5");
        public static WinFormsField AvailUnits5 = new WinFormsField("AVAIL-UNITS-5", "AvailUnits5");
        public static WinFormsField AvailDate5 = new WinFormsField("AVAIL-DATE-5", "AvailDate5");
        public static WinFormsField RelImm6 = new WinFormsField("REL-IMM-6", "RelImm6");
        public static WinFormsField MaintRest6 = new WinFormsField("MAINT-REST-6", "MaintRest6");
        public static WinFormsField ForfNow6 = new WinFormsField("FORF-NOW-6", "ForfNow6");
        public static WinFormsField AvailUnits6 = new WinFormsField("AVAIL-UNITS-6", "AvailUnits6");
        public static WinFormsField AvailDate6 = new WinFormsField("AVAIL-DATE-6", "AvailDate6");
        public static WinFormsField RelImm7 = new WinFormsField("REL-IMM-7", "RelImm7");
        public static WinFormsField MaintRest7 = new WinFormsField("MAINT-REST-7", "MaintRest7");
        public static WinFormsField ForfNow7 = new WinFormsField("FORF-NOW-7", "ForfNow7");
        public static WinFormsField AvailUnits7 = new WinFormsField("AVAIL-UNITS-7", "AvailUnits7");
        public static WinFormsField AvailDate7 = new WinFormsField("AVAIL-DATE-7", "AvailDate7");
        public static WinFormsField RelImm8 = new WinFormsField("REL-IMM-8", "RelImm8");
        public static WinFormsField MaintRest8 = new WinFormsField("MAINT-REST-8", "MaintRest8");
        public static WinFormsField ForfNow8 = new WinFormsField("FORF-NOW-8", "ForfNow8");
        public static WinFormsField AvailUnits8 = new WinFormsField("AVAIL-UNITS-8", "AvailUnits8");
        public static WinFormsField AvailDate8 = new WinFormsField("AVAIL-DATE-8", "AvailDate8");
        public static WinFormsField RelImm9 = new WinFormsField("REL-IMM-9", "RelImm9");
        public static WinFormsField MaintRest9 = new WinFormsField("MAINT-REST-9", "MaintRest9");
        public static WinFormsField ForfNow9 = new WinFormsField("FORF-NOW-9", "ForfNow9");
        public static WinFormsField AvailUnits9 = new WinFormsField("AVAIL-UNITS-9", "AvailUnits9");
        public static WinFormsField AvailDate9 = new WinFormsField("AVAIL-DATE-9", "AvailDate9");
        public static WinFormsField RelImm10 = new WinFormsField("REL-IMM-10", "RelImm10");
        public static WinFormsField MaintRest10 = new WinFormsField("MAINT-REST-10", "MaintRest10");
        public static WinFormsField ForfNow10 = new WinFormsField("FORF-NOW-10", "ForfNow10");
        public static WinFormsField AvailUnits10 = new WinFormsField("AVAIL-UNITS-10", "AvailUnits10");
        public static WinFormsField AvailDate10 = new WinFormsField("AVAIL-DATE-10", "AvailDate10");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
