using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EISPID01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EISPID01", "FormName");
		//Fields


        public static WinFormsField EispidKey0 = new WinFormsField("EISPID-KEY0", "EispidKey0");
        public static WinFormsField PayrollDesc = new WinFormsField("PAYROLL-DESC", "PayrollDesc");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField EmployeeGrade = new WinFormsField("EMPLOYEE-GRADE", "EmployeeGrade");
        public static WinFormsField NbrEligible = new WinFormsField("NBR-ELIGIBLE", "NbrEligible");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PayeeNameLine = new WinFormsField("PAYEE-NAME-LINE", "PayeeNameLine");
        public static WinFormsField VFUsedInd = new WinFormsField("VF-USED-IND", "VFUsedInd");
        public static WinFormsField VFDesc = new WinFormsField("VF-DESC", "VFDesc");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField PayrollStatus = new WinFormsField("PAYROLL-STATUS", "PayrollStatus");
        public static WinFormsField ForeignCurrency = new WinFormsField("FOREIGN-CURRENCY", "ForeignCurrency");
        public static WinFormsField SpecialChangeFlag = new WinFormsField("SPECIAL-CHANGE-FLAG", "SpecialChangeFlag");
        public static WinFormsField AllowEmployerPaymentInd = new WinFormsField("ALLOW-EMPLOYER-PAYMENT-IND", "AllowEmployerPaymentInd");
        public static WinFormsField SubPayrollInd = new WinFormsField("SUB-PAYROLL-IND", "SubPayrollInd");
        public static WinFormsField PayrollCountry = new WinFormsField("PAYROLL-COUNTRY", "PayrollCountry");
        public static WinFormsField EmpRemittanceIdentifier = new WinFormsField("EMP-REMITTANCE-IDENTIFIER", "EmpRemittanceIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField TaxRemittanceIdentifier = new WinFormsField("TAX-REMITTANCE-IDENTIFIER", "TaxRemittanceIdentifier");
    }
}
