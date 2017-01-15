using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS068CS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS068CS", "FormName");
		//Fields
        public static WinFormsField TransDesc = new WinFormsField("TRANS-DESC", "TransDesc");
        public static WinFormsField DeceasedHolderName = new WinFormsField("DECEASED-HOLDER-NAME", "DeceasedHolderName");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField Actions = new WinFormsField("ACTIONS", "Actions");
        public static WinFormsField NewHnaLine = new WinFormsField("NEW-HNA-LINE", "NewHnaLine");
        public static WinFormsField NewPostcode = new WinFormsField("NEW-POSTCODE", "NewPostcode");
        public static WinFormsField OrigHnaLine = new WinFormsField("ORIG-HNA-LINE", "OrigHnaLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField CheckIndicators = new WinFormsField("CHECK-INDICATORS", "CheckIndicators");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
