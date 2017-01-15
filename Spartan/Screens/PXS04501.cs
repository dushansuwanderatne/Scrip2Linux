using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04501", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField StatusLit = new WinFormsField("STATUS-LIT", "StatusLit");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField AtdType = new WinFormsField("ATD-TYPE", "AtdType");
        public static WinFormsField AtdNumber = new WinFormsField("ATD-NUMBER", "AtdNumber");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField PresentYN = new WinFormsField("PRESENT-YN", "PresentYN");
        public static WinFormsField ResolutionLine = new WinFormsField("RESOLUTION-LINE", "ResolutionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField HolderSearchKey = new WinFormsField("HOLDER-SEARCH-KEY", "HolderSearchKey");
        public static WinFormsField HolderSearchHin = new WinFormsField("HOLDER-SEARCH-HIN", "HolderSearchHin");
        public static WinFormsField SearchNomCode = new WinFormsField("SEARCH-NOM-CODE", "SearchNomCode");
        public static WinFormsField FilterClass = new WinFormsField("FILTER-CLASS", "FilterClass");
        public static WinFormsField UnitCurrency = new WinFormsField("UNIT-CURRENCY", "UnitCurrency");
        public static WinFormsField ActionPre = new WinFormsField("ACTION-PRE", "ActionPre");
        public static WinFormsField SearchNomCodePre = new WinFormsField("SEARCH-NOM-CODE-PRE", "SearchNomCodePre");
        public static WinFormsField FilterClassPre = new WinFormsField("FILTER-CLASS-PRE", "FilterClassPre");
        public static WinFormsField UnitCurrencyPre = new WinFormsField("UNIT-CURRENCY-PRE", "UnitCurrencyPre");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
