using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01506

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01506", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AutoAcknowledge = new WinFormsField("AUTO-ACKNOWLEDGE", "AutoAcknowledge");
        public static WinFormsField AutoFast = new WinFormsField("AUTO-FAST", "AutoFast");
        public static WinFormsField AutoNsn = new WinFormsField("AUTO-NSN", "AutoNsn");
        public static WinFormsField NsnFormName = new WinFormsField("NSN-FORM-NAME", "NsnFormName");
        public static WinFormsField AutospoolUrr = new WinFormsField("AUTOSPOOL-URR", "AutospoolUrr");
        public static WinFormsField Prt1 = new WinFormsField("PRT1", "Prt1");
        public static WinFormsField Prt2 = new WinFormsField("PRT2", "Prt2");
        public static WinFormsField Prt3 = new WinFormsField("PRT3", "Prt3");
        public static WinFormsField Prt4 = new WinFormsField("PRT4", "Prt4");
        public static WinFormsField PrinterName = new WinFormsField("PRINTER-NAME", "PrinterName");
        public static WinFormsField UpdateAutoCopies = new WinFormsField("UPDATE-AUTO-COPIES", "UpdateAutoCopies");
        public static WinFormsField AutoPdfOption = new WinFormsField("AUTO-PDF-OPTION", "AutoPdfOption");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
