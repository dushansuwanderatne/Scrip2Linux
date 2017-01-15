using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS05501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS05501", "FormName");
		//Fields


        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankDescription = new WinFormsField("BANK-DESCRIPTION", "BankDescription");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField BankCodePrefix = new WinFormsField("BANK-CODE-PREFIX", "BankCodePrefix");
        public static WinFormsField FileTransfer = new WinFormsField("FILE-TRANSFER", "FileTransfer");
        public static WinFormsField RemittanceProcessing = new WinFormsField("REMITTANCE-PROCESSING", "RemittanceProcessing");
        public static WinFormsField FgnChqAllowedInd = new WinFormsField("FGN-CHQ-ALLOWED-IND", "FgnChqAllowedInd");
        public static WinFormsField BillingInd = new WinFormsField("BILLING-IND", "BillingInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField SearchBankType = new WinFormsField("SEARCH-BANK-TYPE", "SearchBankType");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
