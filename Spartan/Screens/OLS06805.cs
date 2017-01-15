using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS06805

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS06805", "FormName");
		//Fields
        public static WinFormsField DeceasedHolderName = new WinFormsField("DECEASED-HOLDER-NAME", "DeceasedHolderName");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField YourReference = new WinFormsField("YOUR-REFERENCE", "YourReference");
        public static WinFormsField Salutation = new WinFormsField("SALUTATION", "Salutation");
        public static WinFormsField FIAddressLine = new WinFormsField("FI-ADDRESS-LINE", "FIAddressLine");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField FIPostcode = new WinFormsField("FI-POSTCODE", "FIPostcode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField EstateSizeInd = new WinFormsField("ESTATE-SIZE-IND", "EstateSizeInd");
        public static WinFormsField OveEstateSizeInd = new WinFormsField("OVE-ESTATE-SIZE-IND", "OveEstateSizeInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
