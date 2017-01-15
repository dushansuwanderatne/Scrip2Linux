using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS01101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS01101", "FormName");
		//Fields


        public static WinFormsField Job = new WinFormsField("JOB", "Job");
        public static WinFormsField JobName = new WinFormsField("JOB-NAME", "JobName");
        public static WinFormsField Value = new WinFormsField("VALUE", "Value");
        public static WinFormsField ActionFields = new WinFormsField("ACTION-FIELDS", "ActionFields");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
