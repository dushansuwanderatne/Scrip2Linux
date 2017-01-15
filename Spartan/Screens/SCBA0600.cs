using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0600", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField MinOSDays = new WinFormsField("MIN-OS-DAYS", "MinOSDays");
        public static WinFormsField MinApplications = new WinFormsField("MIN-APPLICATIONS", "MinApplications");
        public static WinFormsField CutOff = new WinFormsField("CUT-OFF", "CutOff");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}