using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK03001", "FormName");
		//Fields


        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField SubPayrollInd = new WinFormsField("SUB-PAYROLL-IND", "SubPayrollInd");
        public static WinFormsField PayrollDesc = new WinFormsField("PAYROLL-DESC", "PayrollDesc");
        public static WinFormsField PayrollCountry = new WinFormsField("PAYROLL-COUNTRY", "PayrollCountry");
        public static WinFormsField TaxRemittanceID = new WinFormsField("TAX-REMITTANCE-ID", "TaxRemittanceID");
        public static WinFormsField EmpRemittanceID = new WinFormsField("EMP-REMITTANCE-ID", "EmpRemittanceID");
        public static WinFormsField AllowEmpPayment = new WinFormsField("ALLOW-EMP-PAYMENT", "AllowEmpPayment");
        public static WinFormsField PayrollStatus = new WinFormsField("PAYROLL-STATUS", "PayrollStatus");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField ForeignCurrency = new WinFormsField("FOREIGN-CURRENCY", "ForeignCurrency");
        public static WinFormsField SpecialChangeFlag = new WinFormsField("SPECIAL-CHANGE-FLAG", "SpecialChangeFlag");
        public static WinFormsField EmployeeGrade = new WinFormsField("EMPLOYEE-GRADE", "EmployeeGrade");
        public static WinFormsField NbrEligible = new WinFormsField("NBR-ELIGIBLE", "NbrEligible");
        public static WinFormsField Yn1 = new WinFormsField("YN1", "Yn1");
        public static WinFormsField Desc1 = new WinFormsField("DESC1", "Desc1");
        public static WinFormsField Yn2 = new WinFormsField("YN2", "Yn2");
        public static WinFormsField Desc2 = new WinFormsField("DESC2", "Desc2");
        public static WinFormsField Yn3 = new WinFormsField("YN3", "Yn3");
        public static WinFormsField Desc3 = new WinFormsField("DESC3", "Desc3");
        public static WinFormsField Yn4 = new WinFormsField("YN4", "Yn4");
        public static WinFormsField Desc4 = new WinFormsField("DESC4", "Desc4");
        public static WinFormsField Yn5 = new WinFormsField("YN5", "Yn5");
        public static WinFormsField Desc5 = new WinFormsField("DESC5", "Desc5");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
