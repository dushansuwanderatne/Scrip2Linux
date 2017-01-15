using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS02016

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS02016", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField GlobalAddressLine = new WinFormsField("GLOBAL-ADDRESS-LINE", "GlobalAddressLine");
        public static WinFormsField DiffIndicator = new WinFormsField("DIFF-INDICATOR", "DiffIndicator");
        public static WinFormsField HolderAddressLine = new WinFormsField("HOLDER-ADDRESS-LINE", "HolderAddressLine");
        public static WinFormsField GlobalPostcode = new WinFormsField("GLOBAL-POSTCODE", "GlobalPostcode");
        public static WinFormsField HolderPostcode = new WinFormsField("HOLDER-POSTCODE", "HolderPostcode");
        public static WinFormsField GlobalDomicileCode = new WinFormsField("GLOBAL-DOMICILE-CODE", "GlobalDomicileCode");
        public static WinFormsField HolderDomicileCode = new WinFormsField("HOLDER-DOMICILE-CODE", "HolderDomicileCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
