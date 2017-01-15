using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TESTTIER

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TESTTIER", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField ID = new WinFormsField("ID", "ID");
        public static WinFormsField Address = new WinFormsField("ADDRESS", "Address");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Tfn = new WinFormsField("TFN", "Tfn");
        public static WinFormsField Group = new WinFormsField("GROUP", "Group");
        //public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Deceased = new WinFormsField("DECEASED", "Deceased");
        public static WinFormsField Trade = new WinFormsField("TRADE", "Trade");
        public static WinFormsField Flags = new WinFormsField("FLAGS", "Flags");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField Report = new WinFormsField("REPORT", "Report");
        public static WinFormsField Suppress = new WinFormsField("SUPPRESS", "Suppress");
        public static WinFormsField Intent = new WinFormsField("INTENT", "Intent");
        public static WinFormsField UnclDT = new WinFormsField("UNCL-DT", "UnclDT");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
