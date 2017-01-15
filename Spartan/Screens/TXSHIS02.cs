using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TXSHIS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TXSHIS02", "FormName");
		//Fields


        public static WinFormsField TxshisKey0 = new WinFormsField("TXSHIS-KEY0", "TxshisKey0");
        public static WinFormsField IntAssigneeTaxRate = new WinFormsField("INT-ASSIGNEE-TAX-RATE", "IntAssigneeTaxRate");
        public static WinFormsField AtoReportableAmount = new WinFormsField("ATO-REPORTABLE-AMOUNT", "AtoReportableAmount");
        public static WinFormsField NetAssessableAmount = new WinFormsField("NET-ASSESSABLE-AMOUNT", "NetAssessableAmount");
        public static WinFormsField OrgTfnAmtWithheld = new WinFormsField("ORG-TFN-AMT-WITHHELD", "OrgTfnAmtWithheld");
        public static WinFormsField OrgAssessableAmount = new WinFormsField("ORG-ASSESSABLE-AMOUNT", "OrgAssessableAmount");
        public static WinFormsField OrgAtoReportableAmount = new WinFormsField("ORG-ATO-REPORTABLE-AMOUNT", "OrgAtoReportableAmount");
        public static WinFormsField OrgFgnNettAssessAmt = new WinFormsField("ORG-FGN-NETT-ASSESS-AMT", "OrgFgnNettAssessAmt");
        public static WinFormsField OrgNetAssessableAmount = new WinFormsField("ORG-NET-ASSESSABLE-AMOUNT", "OrgNetAssessableAmount");
        public static WinFormsField OrgTotalPurchaseCost = new WinFormsField("ORG-TOTAL-PURCHASE-COST", "OrgTotalPurchaseCost");
        public static WinFormsField Tfn = new WinFormsField("TFN", "Tfn");
        public static WinFormsField Abn = new WinFormsField("ABN", "Abn");
        public static WinFormsField EmployeeID = new WinFormsField("EMPLOYEE-ID", "EmployeeID");
        public static WinFormsField EmployeeDob = new WinFormsField("EMPLOYEE-DOB", "EmployeeDob");
        public static WinFormsField EmployeeSurname = new WinFormsField("EMPLOYEE-SURNAME", "EmployeeSurname");
        public static WinFormsField EmployeeFirstName = new WinFormsField("EMPLOYEE-FIRST-NAME", "EmployeeFirstName");
        public static WinFormsField EmployeeSecondName = new WinFormsField("EMPLOYEE-SECOND-NAME", "EmployeeSecondName");
        public static WinFormsField AddressLine1 = new WinFormsField("ADDRESS-LINE-1", "AddressLine1");
        public static WinFormsField AddressLine2 = new WinFormsField("ADDRESS-LINE-2", "AddressLine2");
        public static WinFormsField Suburb = new WinFormsField("SUBURB", "Suburb");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField HolderDomicileFlag = new WinFormsField("HOLDER-DOMICILE-FLAG", "HolderDomicileFlag");
    }
}
