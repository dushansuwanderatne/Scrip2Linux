using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08902", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SubsystemDesc = new WinFormsField("SUBSYSTEM-DESC", "SubsystemDesc");
        public static WinFormsField FromSubsystemID = new WinFormsField("FROM-SUBSYSTEM-ID", "FromSubsystemID");
        public static WinFormsField TOHolder = new WinFormsField("TO-HOLDER", "TOHolder");
        public static WinFormsField FromClassCode = new WinFormsField("FROM-CLASS-CODE", "FromClassCode");
        public static WinFormsField FromClassDesc = new WinFormsField("FROM-CLASS-DESC", "FromClassDesc");
        public static WinFormsField TOTradeRef = new WinFormsField("TO-TRADE-REF", "TOTradeRef");
        public static WinFormsField FromRegisterCode = new WinFormsField("FROM-REGISTER-CODE", "FromRegisterCode");
        public static WinFormsField FromRegisterDesc = new WinFormsField("FROM-REGISTER-DESC", "FromRegisterDesc");
        public static WinFormsField TOBroker = new WinFormsField("TO-BROKER", "TOBroker");
        public static WinFormsField FromBroker = new WinFormsField("FROM-BROKER", "FromBroker");
        public static WinFormsField FromBrokerDesc = new WinFormsField("FROM-BROKER-DESC", "FromBrokerDesc");
        public static WinFormsField TOAgentCode = new WinFormsField("TO-AGENT-CODE", "TOAgentCode");
        public static WinFormsField FromReference = new WinFormsField("FROM-REFERENCE", "FromReference");
        public static WinFormsField TOPaymentInd = new WinFormsField("TO-PAYMENT-IND", "TOPaymentInd");
        public static WinFormsField FromTradeRef = new WinFormsField("FROM-TRADE-REF", "FromTradeRef");
        public static WinFormsField FromHolderID = new WinFormsField("FROM-HOLDER-ID", "FromHolderID");
        public static WinFormsField FromAddressLine = new WinFormsField("FROM-ADDRESS-LINE", "FromAddressLine");
        public static WinFormsField TOTransNumber = new WinFormsField("TO-TRANS-NUMBER", "TOTransNumber");
        public static WinFormsField TOTotalMoney = new WinFormsField("TO-TOTAL-MONEY", "TOTotalMoney");
        public static WinFormsField TOPaymentSource = new WinFormsField("TO-PAYMENT-SOURCE", "TOPaymentSource");
        public static WinFormsField TOPaymentDate = new WinFormsField("TO-PAYMENT-DATE", "TOPaymentDate");
        public static WinFormsField WarningMsgLine = new WinFormsField("WARNING-MSG-LINE", "WarningMsgLine");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
