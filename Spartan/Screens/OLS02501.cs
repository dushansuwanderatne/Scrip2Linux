using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02501", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField HolderFin = new WinFormsField("HOLDER-FIN", "HolderFin");
        public static WinFormsField ReservationFin = new WinFormsField("RESERVATION-FIN", "ReservationFin");
        public static WinFormsField ReservationFinX9 = new WinFormsField("RESERVATION-FIN-X9", "ReservationFinX9");
        public static WinFormsField ReservationStatus = new WinFormsField("RESERVATION-STATUS", "ReservationStatus");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField FreeFormatNote = new WinFormsField("FREE-FORMAT-NOTE", "FreeFormatNote");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField ReservationDeal = new WinFormsField("RESERVATION-DEAL", "ReservationDeal");
        public static WinFormsField NomParticipant = new WinFormsField("NOM-PARTICIPANT", "NomParticipant");
        public static WinFormsField BrokerReference = new WinFormsField("BROKER-REFERENCE", "BrokerReference");
        public static WinFormsField CancelReference = new WinFormsField("CANCEL-REFERENCE", "CancelReference");
        public static WinFormsField EnquiryAction = new WinFormsField("ENQUIRY-ACTION", "EnquiryAction");
        public static WinFormsField UpdateAction = new WinFormsField("UPDATE-ACTION", "UpdateAction");
        public static WinFormsField SearchHin = new WinFormsField("SEARCH-HIN", "SearchHin");
        public static WinFormsField SearchFinX = new WinFormsField("SEARCH-FIN-X", "SearchFinX");
        public static WinFormsField SearchClass = new WinFormsField("SEARCH-CLASS", "SearchClass");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Line24 = new WinFormsField("LINE24", "Line24");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
