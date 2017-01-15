using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL05000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL05000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
        public static WinFormsField PhoneBusiness = new WinFormsField("PHONE-BUSINESS", "PhoneBusiness");
        public static WinFormsField PhonePrivate = new WinFormsField("PHONE-PRIVATE", "PhonePrivate");
        public static WinFormsField Fax = new WinFormsField("FAX", "Fax");
        public static WinFormsField TitleDescription = new WinFormsField("TITLE-DESCRIPTION", "TitleDescription");
        public static WinFormsField Groups1 = new WinFormsField("GROUPS-1", "Groups1");
        public static WinFormsField Groups2 = new WinFormsField("GROUPS-2", "Groups2");
        public static WinFormsField Companies1 = new WinFormsField("COMPANIES-1", "Companies1");
        public static WinFormsField Companies2 = new WinFormsField("COMPANIES-2", "Companies2");
        public static WinFormsField Companies3 = new WinFormsField("COMPANIES-3", "Companies3");
        public static WinFormsField Companies4 = new WinFormsField("COMPANIES-4", "Companies4");
        public static WinFormsField Companies5 = new WinFormsField("COMPANIES-5", "Companies5");
        public static WinFormsField Companies6 = new WinFormsField("COMPANIES-6", "Companies6");
        public static WinFormsField Companies7 = new WinFormsField("COMPANIES-7", "Companies7");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
