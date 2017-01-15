using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTENQ02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTENQ02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderAlternateID = new WinFormsField("HOLDER-ALTERNATE-ID", "HolderAlternateID");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField HstDeceased = new WinFormsField("HST-DECEASED", "HstDeceased");
        public static WinFormsField HstStopTrade = new WinFormsField("HST-STOP-TRADE", "HstStopTrade");
        public static WinFormsField HstException = new WinFormsField("HST-EXCEPTION", "HstException");
        public static WinFormsField HstSuppress = new WinFormsField("HST-SUPPRESS", "HstSuppress");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField UpdateOption = new WinFormsField("UPDATE-OPTION", "UpdateOption");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
