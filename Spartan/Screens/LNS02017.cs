using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS02017

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS02017", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderAddressLine = new WinFormsField("HOLDER-ADDRESS-LINE", "HolderAddressLine");
        public static WinFormsField HolderPostcode = new WinFormsField("HOLDER-POSTCODE", "HolderPostcode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
