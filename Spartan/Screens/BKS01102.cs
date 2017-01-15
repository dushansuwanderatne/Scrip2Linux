using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS01102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS01102", "FormName");
		//Fields


        public static WinFormsField JobName = new WinFormsField("JOB-NAME", "JobName");
        public static WinFormsField JobDescription1 = new WinFormsField("JOB-DESCRIPTION1", "JobDescription1");
        public static WinFormsField JobDescription2 = new WinFormsField("JOB-DESCRIPTION2", "JobDescription2");
        public static WinFormsField JobDescription3 = new WinFormsField("JOB-DESCRIPTION3", "JobDescription3");
        public static WinFormsField JobDescription4 = new WinFormsField("JOB-DESCRIPTION4", "JobDescription4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
