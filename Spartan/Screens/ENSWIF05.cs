using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSWIF05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSWIF05", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AddressLine1 = new WinFormsField("ADDRESS-LINE-1", "AddressLine1");
        public static WinFormsField PayeeNbr = new WinFormsField("PAYEE-NBR", "PayeeNbr");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField AddressLine2 = new WinFormsField("ADDRESS-LINE-2", "AddressLine2");
        public static WinFormsField AddressLine3 = new WinFormsField("ADDRESS-LINE-3", "AddressLine3");
        public static WinFormsField WifUnits = new WinFormsField("WIF-UNITS", "WifUnits");
        public static WinFormsField WifUnitValue = new WinFormsField("WIF-UNIT-VALUE", "WifUnitValue");
        public static WinFormsField WifValue = new WinFormsField("WIF-VALUE", "WifValue");
        public static WinFormsField UnunitisedYear = new WinFormsField("UNUNITISED-YEAR", "UnunitisedYear");
        public static WinFormsField UnunitisedValue = new WinFormsField("UNUNITISED-VALUE", "UnunitisedValue");
        public static WinFormsField UnunitisedSign = new WinFormsField("UNUNITISED-SIGN", "UnunitisedSign");
        public static WinFormsField TotalValue = new WinFormsField("TOTAL-VALUE", "TotalValue");
        public static WinFormsField TotalSign = new WinFormsField("TOTAL-SIGN", "TotalSign");
        public static WinFormsField FYDesc1st5 = new WinFormsField("FY-DESC-1ST5", "FYDesc1st5");
        public static WinFormsField Units1st5 = new WinFormsField("UNITS-1ST5", "Units1st5");
        public static WinFormsField FYDesc2nd5 = new WinFormsField("FY-DESC-2ND5", "FYDesc2nd5");
        public static WinFormsField Units2nd5 = new WinFormsField("UNITS-2ND5", "Units2nd5");
        public static WinFormsField OSYear1st3 = new WinFormsField("OS-YEAR-1ST3", "OSYear1st3");
        public static WinFormsField OSUnits1st3 = new WinFormsField("OS-UNITS-1ST3", "OSUnits1st3");
        public static WinFormsField OSYear2nd3 = new WinFormsField("OS-YEAR-2ND3", "OSYear2nd3");
        public static WinFormsField OSUnits2nd3 = new WinFormsField("OS-UNITS-2ND3", "OSUnits2nd3");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
