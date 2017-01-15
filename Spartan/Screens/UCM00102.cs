using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UCM00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UCM00102", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ConferenceNameLine = new WinFormsField("CONFERENCE-NAME-LINE", "ConferenceNameLine");
        public static WinFormsField AccommAddressLine = new WinFormsField("ACCOMM-ADDRESS-LINE", "AccommAddressLine");
        public static WinFormsField VenueContact = new WinFormsField("VENUE-CONTACT", "VenueContact");
        public static WinFormsField VenuePhoneCode = new WinFormsField("VENUE-PHONE-CODE", "VenuePhoneCode");
        public static WinFormsField VenuePhoneNumber = new WinFormsField("VENUE-PHONE-NUMBER", "VenuePhoneNumber");
        public static WinFormsField VenueFaxCode = new WinFormsField("VENUE-FAX-CODE", "VenueFaxCode");
        public static WinFormsField VenueFaxNumber = new WinFormsField("VENUE-FAX-NUMBER", "VenueFaxNumber");
        public static WinFormsField AccommDateFrom = new WinFormsField("ACCOMM-DATE-FROM", "AccommDateFrom");
        public static WinFormsField AccommDateTO = new WinFormsField("ACCOMM-DATE-TO", "AccommDateTO");
        public static WinFormsField RoomCost = new WinFormsField("ROOM-COST", "RoomCost");
        public static WinFormsField InvoicePrintDate = new WinFormsField("INVOICE-PRINT-DATE", "InvoicePrintDate");
        public static WinFormsField CommentLine = new WinFormsField("COMMENT-LINE", "CommentLine");
    }
}
