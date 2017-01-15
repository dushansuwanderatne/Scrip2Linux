using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLPPP1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLPPP1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField RegistrationRequestDropNum = new WinFormsField("REGISTRATION-REQUEST-DROP-NUM", "RegistrationRequestDropNum");
        public static WinFormsField PartyStockID = new WinFormsField("PARTY-STOCK-ID", "PartyStockID");
        //public static WinFormsField PartyStockID = new WinFormsField("PARTY-STOCK-ID", "PartyStockID");
        public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        //public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        public static WinFormsField NationalityDeclaration = new WinFormsField("NATIONALITY-DECLARATION", "NationalityDeclaration");
        //public static WinFormsField NationalityDeclaration = new WinFormsField("NATIONALITY-DECLARATION", "NationalityDeclaration");
        public static WinFormsField TransactionType = new WinFormsField("TRANSACTION-TYPE", "TransactionType");
        public static WinFormsField RegistrationRequestStatus = new WinFormsField("REGISTRATION-REQUEST-STATUS", "RegistrationRequestStatus");
        public static WinFormsField Quantity = new WinFormsField("QUANTITY", "Quantity");
        public static WinFormsField AvailableTimestamp = new WinFormsField("AVAILABLE-TIMESTAMP", "AvailableTimestamp");
        public static WinFormsField Timestamp = new WinFormsField("TIMESTAMP", "Timestamp");
        //public static WinFormsField Timestamp = new WinFormsField("TIMESTAMP", "Timestamp");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField ID = new WinFormsField("ID", "ID");
        public static WinFormsField RegisteredDate = new WinFormsField("REGISTERED-DATE", "RegisteredDate");
        public static WinFormsField DeliveryReason = new WinFormsField("DELIVERY-REASON", "DeliveryReason");
        public static WinFormsField RegisteredTime = new WinFormsField("REGISTERED-TIME", "RegisteredTime");
        public static WinFormsField DeliveryStatus = new WinFormsField("DELIVERY-STATUS", "DeliveryStatus");
        public static WinFormsField BYCirclesTimestamp = new WinFormsField("BY-CIRCLES-TIMESTAMP", "BYCirclesTimestamp");
        public static WinFormsField RespondedTimestamp = new WinFormsField("RESPONDED-TIMESTAMP", "RespondedTimestamp");
    }
}
