using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT2000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT2000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField TransactionNumber = new WinFormsField("TRANSACTION-NUMBER", "TransactionNumber");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ApplicationNumber = new WinFormsField("APPLICATION-NUMBER", "ApplicationNumber");
        public static WinFormsField MoneyDeposited = new WinFormsField("MONEY-DEPOSITED", "MoneyDeposited");
        public static WinFormsField SharesApplied = new WinFormsField("SHARES-APPLIED", "SharesApplied");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ApplicationCategory = new WinFormsField("APPLICATION-CATEGORY", "ApplicationCategory");
        public static WinFormsField HinNumber = new WinFormsField("HIN-NUMBER", "HinNumber");
        public static WinFormsField IpnSpnNumber = new WinFormsField("IPN-SPN-NUMBER", "IpnSpnNumber");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField AgentCode = new WinFormsField("AGENT-CODE", "AgentCode");
        public static WinFormsField AgentDesc = new WinFormsField("AGENT-DESC", "AgentDesc");
        public static WinFormsField Rejection = new WinFormsField("REJECTION", "Rejection");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchBatch = new WinFormsField("SEARCH-BATCH", "SearchBatch");
        public static WinFormsField SearchTrans = new WinFormsField("SEARCH-TRANS", "SearchTrans");
        public static WinFormsField SearchHolder = new WinFormsField("SEARCH-HOLDER", "SearchHolder");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
