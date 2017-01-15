using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT1700

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT1700", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField OverrideFlaggedApps = new WinFormsField("OVERRIDE-FLAGGED-APPS", "OverrideFlaggedApps");
        public static WinFormsField FlagNumUsed = new WinFormsField("FLAG-NUM-USED", "FlagNumUsed");
        public static WinFormsField FlagValueUsed = new WinFormsField("FLAG-VALUE-USED", "FlagValueUsed");
        public static WinFormsField ClearMismatchedHins = new WinFormsField("CLEAR-MISMATCHED-HINS", "ClearMismatchedHins");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
