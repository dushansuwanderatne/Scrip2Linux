using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01036

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01036", "FormName");
		//Fields
        public static WinFormsField CurrUnitBal = new WinFormsField("CURR-UNIT-BAL", "CurrUnitBal");
        public static WinFormsField NbrCurrCerts = new WinFormsField("NBR-CURR-CERTS", "NbrCurrCerts");
        public static WinFormsField NbrNilCerts = new WinFormsField("NBR-NIL-CERTS", "NbrNilCerts");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
