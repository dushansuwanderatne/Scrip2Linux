using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHSREJ01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHSREJ01", "FormName");
		//Fields


        public static WinFormsField ChsrejKey0 = new WinFormsField("CHSREJ-KEY0", "ChsrejKey0");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField MessageType = new WinFormsField("MESSAGE-TYPE", "MessageType");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BalanceInstruction = new WinFormsField("BALANCE-INSTRUCTION", "BalanceInstruction");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField PayeeAccountNumber = new WinFormsField("PAYEE-ACCOUNT-NUMBER", "PayeeAccountNumber");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField EmailAddressStd = new WinFormsField("EMAIL-ADDRESS-STD", "EmailAddressStd");
        public static WinFormsField EmailAddressExt = new WinFormsField("EMAIL-ADDRESS-EXT", "EmailAddressExt");
        public static WinFormsField RejectedReason = new WinFormsField("REJECTED-REASON", "RejectedReason");
        public static WinFormsField HolderOtherTaxCode = new WinFormsField("HOLDER-OTHER-TAX-CODE", "HolderOtherTaxCode");
        public static WinFormsField RejectedMessage = new WinFormsField("REJECTED-MESSAGE", "RejectedMessage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
