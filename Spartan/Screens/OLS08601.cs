using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08601", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField SubsystemCode = new WinFormsField("SUBSYSTEM-CODE", "SubsystemCode");
        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ControlAccInd = new WinFormsField("CONTROL-ACC-IND", "ControlAccInd");
        public static WinFormsField PaymentSource = new WinFormsField("PAYMENT-SOURCE", "PaymentSource");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField CustomerRefNO = new WinFormsField("CUSTOMER-REF-NO", "CustomerRefNO");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentTimeHhmmss = new WinFormsField("PAYMENT-TIME-HHMMSS", "PaymentTimeHhmmss");
        public static WinFormsField SourceEntryMethod = new WinFormsField("SOURCE-ENTRY-METHOD", "SourceEntryMethod");
        public static WinFormsField TraceNO = new WinFormsField("TRACE-NO", "TraceNO");
        public static WinFormsField BpaySettleDate = new WinFormsField("BPAY-SETTLE-DATE", "BpaySettleDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
