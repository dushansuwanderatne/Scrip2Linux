using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOM05010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOM05010", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField StmPeriodMM = new WinFormsField("STM-PERIOD-MM", "StmPeriodMM");
        public static WinFormsField StmPeriodCcyy = new WinFormsField("STM-PERIOD-CCYY", "StmPeriodCcyy");
        public static WinFormsField InclCoyNOEomSched = new WinFormsField("INCL-COY-NO-EOM-SCHED", "InclCoyNOEomSched");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField ShowDeletedRules = new WinFormsField("SHOW-DELETED-RULES", "ShowDeletedRules");
        public static WinFormsField ScreenName = new WinFormsField("SCREEN-NAME", "ScreenName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
