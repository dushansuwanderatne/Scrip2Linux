using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSREF01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSREF01", "FormName");
		//Fields


        public static WinFormsField EssrefKey0 = new WinFormsField("ESSREF-KEY0", "EssrefKey0");
        public static WinFormsField EssrefKey1 = new WinFormsField("ESSREF-KEY1", "EssrefKey1");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField BeforeMaturityDate = new WinFormsField("BEFORE-MATURITY-DATE", "BeforeMaturityDate");
        public static WinFormsField AfterMaturityDate = new WinFormsField("AFTER-MATURITY-DATE", "AfterMaturityDate");
        public static WinFormsField BeforeSavingsAmount = new WinFormsField("BEFORE-SAVINGS-AMOUNT", "BeforeSavingsAmount");
        public static WinFormsField AfterSavingsAmount = new WinFormsField("AFTER-SAVINGS-AMOUNT", "AfterSavingsAmount");
        public static WinFormsField BeforeResidualInd = new WinFormsField("BEFORE-RESIDUAL-IND", "BeforeResidualInd");
        public static WinFormsField AfterResidualInd = new WinFormsField("AFTER-RESIDUAL-IND", "AfterResidualInd");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField RevRunNumber = new WinFormsField("REV-RUN-NUMBER", "RevRunNumber");
        public static WinFormsField RevTransNumber = new WinFormsField("REV-TRANS-NUMBER", "RevTransNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
