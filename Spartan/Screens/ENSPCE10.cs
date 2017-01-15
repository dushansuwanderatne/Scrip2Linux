using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSPCE10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSPCE10", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField Location = new WinFormsField("LOCATION", "Location");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Presort = new WinFormsField("PRESORT", "Presort");
        public static WinFormsField BarcodePresort = new WinFormsField("BARCODE-PRESORT", "BarcodePresort");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
