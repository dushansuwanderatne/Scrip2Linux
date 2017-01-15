using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOMBAC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOMBAC01", "FormName");
		//Fields


        public static WinFormsField NombacKey0 = new WinFormsField("NOMBAC-KEY0", "NombacKey0");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
