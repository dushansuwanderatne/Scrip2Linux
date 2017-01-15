using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08702", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField OrigRunNumber = new WinFormsField("ORIG-RUN-NUMBER", "OrigRunNumber");
        public static WinFormsField OrigTransNumber = new WinFormsField("ORIG-TRANS-NUMBER", "OrigTransNumber");
        public static WinFormsField OrigTranTypeCode = new WinFormsField("ORIG-TRAN-TYPE-CODE", "OrigTranTypeCode");
        public static WinFormsField OrigTranTypeDesc = new WinFormsField("ORIG-TRAN-TYPE-DESC", "OrigTranTypeDesc");
        public static WinFormsField OrigTransDate = new WinFormsField("ORIG-TRANS-DATE", "OrigTransDate");
        public static WinFormsField SubsystemDesc = new WinFormsField("SUBSYSTEM-DESC", "SubsystemDesc");
        public static WinFormsField FromSubsystemID = new WinFormsField("FROM-SUBSYSTEM-ID", "FromSubsystemID");
        public static WinFormsField FromClassCode = new WinFormsField("FROM-CLASS-CODE", "FromClassCode");
        public static WinFormsField FromClassDesc = new WinFormsField("FROM-CLASS-DESC", "FromClassDesc");
        public static WinFormsField FromRegisterCode = new WinFormsField("FROM-REGISTER-CODE", "FromRegisterCode");
        public static WinFormsField FromRegisterDesc = new WinFormsField("FROM-REGISTER-DESC", "FromRegisterDesc");
        public static WinFormsField FromBroker = new WinFormsField("FROM-BROKER", "FromBroker");
        public static WinFormsField FromBrokerDesc = new WinFormsField("FROM-BROKER-DESC", "FromBrokerDesc");
        public static WinFormsField FromReference = new WinFormsField("FROM-REFERENCE", "FromReference");
        public static WinFormsField FromHolderID = new WinFormsField("FROM-HOLDER-ID", "FromHolderID");
        public static WinFormsField FromAddressLine = new WinFormsField("FROM-ADDRESS-LINE", "FromAddressLine");
        public static WinFormsField FromPaymentSource = new WinFormsField("FROM-PAYMENT-SOURCE", "FromPaymentSource");
        public static WinFormsField FromCustomerRefNO = new WinFormsField("FROM-CUSTOMER-REF-NO", "FromCustomerRefNO");
        public static WinFormsField FromPaymentDate = new WinFormsField("FROM-PAYMENT-DATE", "FromPaymentDate");
        public static WinFormsField FromPaymentTime = new WinFormsField("FROM-PAYMENT-TIME", "FromPaymentTime");
        public static WinFormsField FromCaptureMode = new WinFormsField("FROM-CAPTURE-MODE", "FromCaptureMode");
        public static WinFormsField FromTraceNO = new WinFormsField("FROM-TRACE-NO", "FromTraceNO");
        public static WinFormsField FromBpaySettleDT = new WinFormsField("FROM-BPAY-SETTLE-DT", "FromBpaySettleDT");
        public static WinFormsField FromTransDate = new WinFormsField("FROM-TRANS-DATE", "FromTransDate");
        public static WinFormsField FromReasonDesc = new WinFormsField("FROM-REASON-DESC", "FromReasonDesc");
        public static WinFormsField TOSubsystemID = new WinFormsField("TO-SUBSYSTEM-ID", "TOSubsystemID");
        public static WinFormsField TOClassCode = new WinFormsField("TO-CLASS-CODE", "TOClassCode");
        public static WinFormsField TOClassDesc = new WinFormsField("TO-CLASS-DESC", "TOClassDesc");
        public static WinFormsField TORegisterCode = new WinFormsField("TO-REGISTER-CODE", "TORegisterCode");
        public static WinFormsField TORegisterDesc = new WinFormsField("TO-REGISTER-DESC", "TORegisterDesc");
        public static WinFormsField TOBroker = new WinFormsField("TO-BROKER", "TOBroker");
        public static WinFormsField TOBrokerDesc = new WinFormsField("TO-BROKER-DESC", "TOBrokerDesc");
        public static WinFormsField TOReference = new WinFormsField("TO-REFERENCE", "TOReference");
        public static WinFormsField TOHolderID = new WinFormsField("TO-HOLDER-ID", "TOHolderID");
        public static WinFormsField TOAddressLine = new WinFormsField("TO-ADDRESS-LINE", "TOAddressLine");
        public static WinFormsField TOPaymentSource = new WinFormsField("TO-PAYMENT-SOURCE", "TOPaymentSource");
        public static WinFormsField TOCustomerRefNO = new WinFormsField("TO-CUSTOMER-REF-NO", "TOCustomerRefNO");
        public static WinFormsField TOPaymentDate = new WinFormsField("TO-PAYMENT-DATE", "TOPaymentDate");
        public static WinFormsField TOPaymentTime = new WinFormsField("TO-PAYMENT-TIME", "TOPaymentTime");
        public static WinFormsField TOCaptureMode = new WinFormsField("TO-CAPTURE-MODE", "TOCaptureMode");
        public static WinFormsField TOTraceNO = new WinFormsField("TO-TRACE-NO", "TOTraceNO");
        public static WinFormsField TOBpaySettleDT = new WinFormsField("TO-BPAY-SETTLE-DT", "TOBpaySettleDT");
        public static WinFormsField TOTransDate = new WinFormsField("TO-TRANS-DATE", "TOTransDate");
        public static WinFormsField TOReasonDesc = new WinFormsField("TO-REASON-DESC", "TOReasonDesc");
        public static WinFormsField FromOrgReasonDesc = new WinFormsField("FROM-ORG-REASON-DESC", "FromOrgReasonDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
