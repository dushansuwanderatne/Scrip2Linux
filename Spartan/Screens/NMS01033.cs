using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NMS01033

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NMS01033", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField Hin = new WinFormsField("HIN", "Hin");
        public static WinFormsField Address1 = new WinFormsField("ADDRESS1", "Address1");
        public static WinFormsField Address2 = new WinFormsField("ADDRESS2", "Address2");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Address3 = new WinFormsField("ADDRESS3", "Address3");
        public static WinFormsField Address4 = new WinFormsField("ADDRESS4", "Address4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
