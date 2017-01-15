using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08708

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08708", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField NettUnits = new WinFormsField("NETT-UNITS", "NettUnits");
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
        public static WinFormsField FromReasonDesc = new WinFormsField("FROM-REASON-DESC", "FromReasonDesc");
        public static WinFormsField FromCalcAdnInd = new WinFormsField("FROM-CALC-ADN-IND", "FromCalcAdnInd");
        public static WinFormsField FromWarningMsgL = new WinFormsField("FROM-WARNING-MSG-L", "FromWarningMsgL");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
