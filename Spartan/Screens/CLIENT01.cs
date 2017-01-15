using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLIENT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLIENT01", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField BatchQueue = new WinFormsField("BATCH-QUEUE", "BatchQueue");
        public static WinFormsField DeferTime = new WinFormsField("DEFER-TIME", "DeferTime");
        public static WinFormsField Printer = new WinFormsField("PRINTER", "Printer");
        public static WinFormsField Model = new WinFormsField("MODEL", "Model");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HomeState = new WinFormsField("HOME-STATE", "HomeState");
        public static WinFormsField PubenqPw1 = new WinFormsField("PUBENQ-PW1", "PubenqPw1");
        public static WinFormsField PubenqPw2 = new WinFormsField("PUBENQ-PW2", "PubenqPw2");
        public static WinFormsField EwpPassword = new WinFormsField("EWP-PASSWORD", "EwpPassword");
        public static WinFormsField AtoClientName = new WinFormsField("ATO-CLIENT-NAME", "AtoClientName");
        public static WinFormsField FinPassword = new WinFormsField("FIN-PASSWORD", "FinPassword");
        public static WinFormsField ClientAddressLine = new WinFormsField("CLIENT-ADDRESS-LINE", "ClientAddressLine");
        public static WinFormsField CrestMode = new WinFormsField("CREST-MODE", "CrestMode");
        public static WinFormsField CrestBusinessDate = new WinFormsField("CREST-BUSINESS-DATE", "CrestBusinessDate");
        public static WinFormsField Suburb = new WinFormsField("SUBURB", "Suburb");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField CrestStatus = new WinFormsField("CREST-STATUS", "CrestStatus");
        public static WinFormsField CrestlinkClientInd = new WinFormsField("CRESTLINK-CLIENT-IND", "CrestlinkClientInd");
        public static WinFormsField AtoContactName = new WinFormsField("ATO-CONTACT-NAME", "AtoContactName");
        public static WinFormsField ReceivingAgentID = new WinFormsField("RECEIVING-AGENT-ID", "ReceivingAgentID");
        public static WinFormsField WPPrinter = new WinFormsField("WP-PRINTER", "WPPrinter");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField EssFaxNumber = new WinFormsField("ESS-FAX-NUMBER", "EssFaxNumber");
        public static WinFormsField NoticePrinter = new WinFormsField("NOTICE-PRINTER", "NoticePrinter");
        public static WinFormsField PhoneNumber = new WinFormsField("PHONE-NUMBER", "PhoneNumber");
        public static WinFormsField EssPhoneNumber = new WinFormsField("ESS-PHONE-NUMBER", "EssPhoneNumber");
        public static WinFormsField AsxDiaryGroup = new WinFormsField("ASX-DIARY-GROUP", "AsxDiaryGroup");
        public static WinFormsField TaxAlgorithmInd = new WinFormsField("TAX-ALGORITHM-IND", "TaxAlgorithmInd");
        public static WinFormsField MsgEnableFlag = new WinFormsField("MSG-ENABLE-FLAG", "MsgEnableFlag");
        public static WinFormsField CleansingReq = new WinFormsField("CLEANSING-REQ", "CleansingReq");
        public static WinFormsField InternodeClients = new WinFormsField("INTERNODE-CLIENTS", "InternodeClients");
        public static WinFormsField WPEnableFlag = new WinFormsField("WP-ENABLE-FLAG", "WPEnableFlag");
        public static WinFormsField ProcessGroupFlag = new WinFormsField("PROCESS-GROUP-FLAG", "ProcessGroupFlag");
        public static WinFormsField CreateTraj35Ind = new WinFormsField("CREATE-TRAJ35-IND", "CreateTraj35Ind");
        public static WinFormsField EmailDomain = new WinFormsField("EMAIL-DOMAIN", "EmailDomain");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField ClientType = new WinFormsField("CLIENT-TYPE", "ClientType");
        public static WinFormsField BillerCode = new WinFormsField("BILLER-CODE", "BillerCode");
        public static WinFormsField EnableEmailFlag = new WinFormsField("ENABLE-EMAIL-FLAG", "EnableEmailFlag");
        public static WinFormsField AllowDealingAccessInd = new WinFormsField("ALLOW-DEALING-ACCESS-IND", "AllowDealingAccessInd");
        public static WinFormsField DateFormat = new WinFormsField("DATE-FORMAT", "DateFormat");
        public static WinFormsField BankExportDir = new WinFormsField("BANK-EXPORT-DIR", "BankExportDir");
        public static WinFormsField EssClientName = new WinFormsField("ESS-CLIENT-NAME", "EssClientName");
        public static WinFormsField EssAddressLine = new WinFormsField("ESS-ADDRESS-LINE", "EssAddressLine");
        public static WinFormsField EssSuburb = new WinFormsField("ESS-SUBURB", "EssSuburb");
        public static WinFormsField EssState = new WinFormsField("ESS-STATE", "EssState");
        public static WinFormsField EssCountry = new WinFormsField("ESS-COUNTRY", "EssCountry");
        public static WinFormsField EssContactName = new WinFormsField("ESS-CONTACT-NAME", "EssContactName");
        public static WinFormsField EssAtoFaxNumber = new WinFormsField("ESS-ATO-FAX-NUMBER", "EssAtoFaxNumber");
        public static WinFormsField EssAtoPhoneNumber = new WinFormsField("ESS-ATO-PHONE-NUMBER", "EssAtoPhoneNumber");
        public static WinFormsField EssEmailID = new WinFormsField("ESS-EMAIL-ID", "EssEmailID");
    }
}
