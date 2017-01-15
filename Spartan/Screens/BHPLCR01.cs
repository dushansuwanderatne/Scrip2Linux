using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BHPLCR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BHPLCR01", "FormName");
		//Fields


        public static WinFormsField RegisterCurrency = new WinFormsField("REGISTER-CURRENCY", "RegisterCurrency");
        public static WinFormsField BhplcrKey0 = new WinFormsField("BHPLCR-KEY0", "BhplcrKey0");
        public static WinFormsField LoanClassCode = new WinFormsField("LOAN-CLASS-CODE", "LoanClassCode");
        public static WinFormsField OrgLoanNumber = new WinFormsField("ORG-LOAN-NUMBER", "OrgLoanNumber");
        public static WinFormsField OrgLoanAmount = new WinFormsField("ORG-LOAN-AMOUNT", "OrgLoanAmount");
        public static WinFormsField OrgShares = new WinFormsField("ORG-SHARES", "OrgShares");
        public static WinFormsField AdjLoanNumber = new WinFormsField("ADJ-LOAN-NUMBER", "AdjLoanNumber");
        public static WinFormsField AdjLoanAmount = new WinFormsField("ADJ-LOAN-AMOUNT", "AdjLoanAmount");
        public static WinFormsField AdjShares = new WinFormsField("ADJ-SHARES", "AdjShares");
        public static WinFormsField IncLoanNumber = new WinFormsField("INC-LOAN-NUMBER", "IncLoanNumber");
        public static WinFormsField IncLoanAmount = new WinFormsField("INC-LOAN-AMOUNT", "IncLoanAmount");
        public static WinFormsField IncShares = new WinFormsField("INC-SHARES", "IncShares");
        public static WinFormsField DecLoanNumber = new WinFormsField("DEC-LOAN-NUMBER", "DecLoanNumber");
        public static WinFormsField DecLoanAmount = new WinFormsField("DEC-LOAN-AMOUNT", "DecLoanAmount");
        public static WinFormsField DecShares = new WinFormsField("DEC-SHARES", "DecShares");
        public static WinFormsField AmountPaid = new WinFormsField("AMOUNT-PAID", "AmountPaid");
        public static WinFormsField OverdueAmount = new WinFormsField("OVERDUE-AMOUNT", "OverdueAmount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
