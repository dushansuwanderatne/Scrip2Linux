using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS06501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS06501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ProviderNameKey = new WinFormsField("PROVIDER-NAME-KEY", "ProviderNameKey");
        public static WinFormsField ProviderCode = new WinFormsField("PROVIDER-CODE", "ProviderCode");
        public static WinFormsField ProvFacilFlag = new WinFormsField("PROV-FACIL-FLAG", "ProvFacilFlag");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField NA = new WinFormsField("NA", "NA");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TelephoneNumber = new WinFormsField("TELEPHONE-NUMBER", "TelephoneNumber");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField AssociatedProvider = new WinFormsField("ASSOCIATED-PROVIDER", "AssociatedProvider");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField FacilityType = new WinFormsField("FACILITY-TYPE", "FacilityType");
        public static WinFormsField Action1 = new WinFormsField("ACTION1", "Action1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
