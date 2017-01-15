using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BACHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BACHIS01", "FormName");
		//Fields


        public static WinFormsField BachisKey0 = new WinFormsField("BACHIS-KEY0", "BachisKey0");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField Seq = new WinFormsField("SEQ", "Seq");
        public static WinFormsField RestOFData1 = new WinFormsField("REST-OF-DATA-1", "RestOFData1");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RestOFData2 = new WinFormsField("REST-OF-DATA-2", "RestOFData2");
        public static WinFormsField RestOFData3 = new WinFormsField("REST-OF-DATA-3", "RestOFData3");
        public static WinFormsField RestOFData4 = new WinFormsField("REST-OF-DATA-4", "RestOFData4");
        public static WinFormsField RestOFData5 = new WinFormsField("REST-OF-DATA-5", "RestOFData5");
        public static WinFormsField RestOFData6 = new WinFormsField("REST-OF-DATA-6", "RestOFData6");
        public static WinFormsField RestOFData7 = new WinFormsField("REST-OF-DATA-7", "RestOFData7");
        public static WinFormsField RestOFData8 = new WinFormsField("REST-OF-DATA-8", "RestOFData8");
    }
}
