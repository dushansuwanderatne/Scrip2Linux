using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02803", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TotalUnvested = new WinFormsField("TOTAL-UNVESTED", "TotalUnvested");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField TotalVested = new WinFormsField("TOTAL-VESTED", "TotalVested");
        public static WinFormsField GrandTotal = new WinFormsField("GRAND-TOTAL", "GrandTotal");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
