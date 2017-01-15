using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS01010", "FormName");
		//Fields
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeCount = new WinFormsField("TRADE-COUNT", "TradeCount");
        public static WinFormsField TradeUnits = new WinFormsField("TRADE-UNITS", "TradeUnits");
        public static WinFormsField TradeMoney = new WinFormsField("TRADE-MONEY", "TradeMoney");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
        public static WinFormsField SessionUnits = new WinFormsField("SESSION-UNITS", "SessionUnits");
        public static WinFormsField SessionMoney = new WinFormsField("SESSION-MONEY", "SessionMoney");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransUnits = new WinFormsField("TRANS-UNITS", "TransUnits");
        public static WinFormsField TransMoney = new WinFormsField("TRANS-MONEY", "TransMoney");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField TOCertIdentifier = new WinFormsField("TO-CERT-IDENTIFIER", "TOCertIdentifier");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ReversedTradeInd = new WinFormsField("REVERSED-TRADE-IND", "ReversedTradeInd");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PaymentMethodDesc = new WinFormsField("PAYMENT-METHOD-DESC", "PaymentMethodDesc");
        public static WinFormsField PaymentOption = new WinFormsField("PAYMENT-OPTION", "PaymentOption");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField WireAccountNbr = new WinFormsField("WIRE-ACCOUNT-NBR", "WireAccountNbr");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField TradeUnitsDesc = new WinFormsField("TRADE-UNITS-DESC", "TradeUnitsDesc");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField ExerciseUnits = new WinFormsField("EXERCISE-UNITS", "ExerciseUnits");
        public static WinFormsField RemainingBalance = new WinFormsField("REMAINING-BALANCE", "RemainingBalance");
        public static WinFormsField WarnLine14 = new WinFormsField("WARN-LINE1-4", "WarnLine14");
        public static WinFormsField WarnLine58 = new WinFormsField("WARN-LINE5-8", "WarnLine58");
        public static WinFormsField WarnLineExceded1 = new WinFormsField("WARN-LINE-EXCEDED1", "WarnLineExceded1");
        public static WinFormsField FreeFormatNote = new WinFormsField("FREE-FORMAT-NOTE", "FreeFormatNote");
        public static WinFormsField WarnLineExceded2 = new WinFormsField("WARN-LINE-EXCEDED2", "WarnLineExceded2");
        public static WinFormsField Trs01010EventType = new WinFormsField("TRS01010-EVENT-TYPE", "Trs01010EventType");
        public static WinFormsField Trs01010EventCode = new WinFormsField("TRS01010-EVENT-CODE", "Trs01010EventCode");
        public static WinFormsField Trs01010EventDate = new WinFormsField("TRS01010-EVENT-DATE", "Trs01010EventDate");
        public static WinFormsField TransStatusDesc = new WinFormsField("TRANS-STATUS-DESC", "TransStatusDesc");
        public static WinFormsField EnquiryAction = new WinFormsField("ENQUIRY-ACTION", "EnquiryAction");
        public static WinFormsField AuditAction = new WinFormsField("AUDIT-ACTION", "AuditAction");
        public static WinFormsField UpdateAction = new WinFormsField("UPDATE-ACTION", "UpdateAction");
        public static WinFormsField SearchHolderID = new WinFormsField("SEARCH-HOLDER-ID", "SearchHolderID");
        public static WinFormsField SearchTransNbr = new WinFormsField("SEARCH-TRANS-NBR", "SearchTransNbr");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Line24 = new WinFormsField("LINE24", "Line24");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
