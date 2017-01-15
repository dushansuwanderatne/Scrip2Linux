using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03603", "FormName");
		//Fields


        public static WinFormsField AccessCode = new WinFormsField("ACCESS-CODE", "AccessCode");
        public static WinFormsField CustodianName = new WinFormsField("CUSTODIAN-NAME", "CustodianName");
        public static WinFormsField LegalEntityCode = new WinFormsField("LEGAL-ENTITY-CODE", "LegalEntityCode");
        public static WinFormsField LegalEntityName = new WinFormsField("LEGAL-ENTITY-NAME", "LegalEntityName");
        public static WinFormsField ActiveFromDate = new WinFormsField("ACTIVE-FROM-DATE", "ActiveFromDate");
        public static WinFormsField ActiveTODate = new WinFormsField("ACTIVE-TO-DATE", "ActiveTODate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField HldrAcctDesignation = new WinFormsField("HLDR-ACCT-DESIGNATION", "HldrAcctDesignation");
        public static WinFormsField HolderAddress = new WinFormsField("HOLDER-ADDRESS", "HolderAddress");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL ADDRESS", "EmailAddress");
        public static WinFormsField AdditionalEmail = new WinFormsField("ADDITIONAL-EMAIL", "AdditionalEmail");
        public static WinFormsField SupressNspInd = new WinFormsField("SUPRESS-NSP-IND", "SupressNspInd");
        public static WinFormsField SupressPayRepInd = new WinFormsField("SUPRESS-PAY-REP-IND", "SupressPayRepInd");
        public static WinFormsField SupressAnnRepInd = new WinFormsField("SUPRESS-ANN-REP-IND", "SupressAnnRepInd");
        public static WinFormsField SupressExtractInd = new WinFormsField("SUPRESS-EXTRACT-IND", "SupressExtractInd");
        public static WinFormsField RestrictAccessBYLogin = new WinFormsField("RESTRICT ACCESS BY LOGIN", "RestrictAccessBYLogin");
        public static WinFormsField BulkImageInd = new WinFormsField("BULK-IMAGE-IND", "BulkImageInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField ActionEnquire = new WinFormsField("ACTION-ENQUIRE", "ActionEnquire");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
