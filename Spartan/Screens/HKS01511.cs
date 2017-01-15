using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01511

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01511", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BhpPoolingAccount = new WinFormsField("BHP-POOLING-ACCOUNT", "BhpPoolingAccount");
        public static WinFormsField NbrDaysAdvanceLapse = new WinFormsField("NBR-DAYS-ADVANCE-LAPSE", "NbrDaysAdvanceLapse");
        public static WinFormsField LapseLastRunDate = new WinFormsField("LAPSE-LAST-RUN-DATE", "LapseLastRunDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}