using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0910

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0910", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField ApplicationNumber = new WinFormsField("APPLICATION-NUMBER", "ApplicationNumber");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField MoneyDeposited = new WinFormsField("MONEY-DEPOSITED", "MoneyDeposited");
        public static WinFormsField BranchCode = new WinFormsField("BRANCH-CODE", "BranchCode");
        public static WinFormsField BranchDesc = new WinFormsField("BRANCH-DESC", "BranchDesc");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TransactionNumber = new WinFormsField("TRANSACTION-NUMBER", "TransactionNumber");
        public static WinFormsField AgentCode = new WinFormsField("AGENT-CODE", "AgentCode");
        public static WinFormsField AgentDesc = new WinFormsField("AGENT-DESC", "AgentDesc");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField SharesAllocated = new WinFormsField("SHARES-ALLOCATED", "SharesAllocated");
        public static WinFormsField AlternateID = new WinFormsField("ALTERNATE-ID", "AlternateID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Hvf1 = new WinFormsField("HVF-1", "Hvf1");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField Hvf2 = new WinFormsField("HVF-2", "Hvf2");
        public static WinFormsField Hvf3 = new WinFormsField("HVF-3", "Hvf3");
        public static WinFormsField Hvf4 = new WinFormsField("HVF-4", "Hvf4");
        public static WinFormsField Hvf5 = new WinFormsField("HVF-5", "Hvf5");
        public static WinFormsField IpnSpnNumber = new WinFormsField("IPN-SPN-NUMBER", "IpnSpnNumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Dpid = new WinFormsField("DPID", "Dpid");
        public static WinFormsField HinNumber = new WinFormsField("HIN-NUMBER", "HinNumber");
        public static WinFormsField ResidencyIndicator = new WinFormsField("RESIDENCY-INDICATOR", "ResidencyIndicator");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField Rejection = new WinFormsField("REJECTION", "Rejection");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
