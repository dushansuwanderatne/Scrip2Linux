using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSPCE04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSPCE04", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField LUPresort = new WinFormsField("LU-PRESORT", "LUPresort");
        public static WinFormsField LUBarcodePresort = new WinFormsField("LU-BARCODE-PRESORT", "LUBarcodePresort");
    }
}
