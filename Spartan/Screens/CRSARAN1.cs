using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSARAN1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSARAN1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField TransactionRef = new WinFormsField("TRANSACTION-REF", "TransactionRef");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        //public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ID = new WinFormsField("ID", "ID");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Quantity = new WinFormsField("QUANTITY", "Quantity");
        public static WinFormsField ParticipantNote = new WinFormsField("PARTICIPANT-NOTE", "ParticipantNote");
        public static WinFormsField Note = new WinFormsField("NOTE", "Note");
        public static WinFormsField PartyStockID = new WinFormsField("PARTY-STOCK-ID", "PartyStockID");
        //public static WinFormsField PartyStockID = new WinFormsField("PARTY-STOCK-ID", "PartyStockID");
        public static WinFormsField CorporateActionNumber = new WinFormsField("CORPORATE-ACTION-NUMBER", "CorporateActionNumber");
        public static WinFormsField CorporateActionIsin = new WinFormsField("CORPORATE-ACTION-ISIN", "CorporateActionIsin");
    }
}
