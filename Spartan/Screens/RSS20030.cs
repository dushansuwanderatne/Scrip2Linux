using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS20030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS20030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
