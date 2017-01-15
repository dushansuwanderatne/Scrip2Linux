using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL03901

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL03901", "FormName");
		//Fields


        public static WinFormsField CoyCode1 = new WinFormsField("COY-CODE-1", "CoyCode1");
        public static WinFormsField CoyCode2 = new WinFormsField("COY-CODE-2", "CoyCode2");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
