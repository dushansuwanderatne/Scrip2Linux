using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NMS01090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NMS01090", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
