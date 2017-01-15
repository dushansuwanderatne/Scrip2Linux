using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS03020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS03020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CurrentRun = new WinFormsField("CURRENT-RUN", "CurrentRun");
        public static WinFormsField LastEomStatsRun = new WinFormsField("LAST-EOM-STATS-RUN", "LastEomStatsRun");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ClgCon = new WinFormsField("CLG-CON", "ClgCon");
        public static WinFormsField MparcelTO = new WinFormsField("MPARCEL-TO", "MparcelTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
