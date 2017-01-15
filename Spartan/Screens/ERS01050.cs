using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01050", "FormName");
		//Fields
        public static WinFormsField CoyCode15 = new WinFormsField("COY-CODE-1-5", "CoyCode15");
        public static WinFormsField CoyCode610 = new WinFormsField("COY-CODE-6-10", "CoyCode610");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField TaxStatus = new WinFormsField("TAX-STATUS", "TaxStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
