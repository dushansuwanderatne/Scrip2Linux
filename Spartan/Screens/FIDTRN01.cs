using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDTRN01", "FormName");
		//Fields


        public static WinFormsField FidtrnKey0 = new WinFormsField("FIDTRN-KEY0", "FidtrnKey0");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField ReferenceNumber = new WinFormsField("REFERENCE-NUMBER", "ReferenceNumber");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField TranSequence = new WinFormsField("TRAN-SEQUENCE", "TranSequence");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField PrincipalTraded = new WinFormsField("PRINCIPAL-TRADED", "PrincipalTraded");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField InstalmentTraded = new WinFormsField("INSTALMENT-TRADED", "InstalmentTraded");
        public static WinFormsField AccrCompInd = new WinFormsField("ACCR-COMP-IND", "AccrCompInd");
        public static WinFormsField AccrCompTraded = new WinFormsField("ACCR-COMP-TRADED", "AccrCompTraded");
        public static WinFormsField CrtTrnCount = new WinFormsField("CRT-TRN-COUNT", "CrtTrnCount");
        public static WinFormsField ConsiderationAmount = new WinFormsField("CONSIDERATION-AMOUNT", "ConsiderationAmount");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField FidOwing = new WinFormsField("FID-OWING", "FidOwing");
        public static WinFormsField TradingHolderID = new WinFormsField("TRADING-HOLDER-ID", "TradingHolderID");
        public static WinFormsField FidTORecover = new WinFormsField("FID-TO-RECOVER", "FidTORecover");
        public static WinFormsField SourceOFFunds = new WinFormsField("SOURCE-OF-FUNDS", "SourceOFFunds");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ReversedInd = new WinFormsField("REVERSED-IND", "ReversedInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
