using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01001", "FormName");
		//Fields


        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField SubsystemType = new WinFormsField("SUBSYSTEM-TYPE", "SubsystemType");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField ActiveTODate = new WinFormsField("ACTIVE-TO-DATE", "ActiveTODate");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField LitFwd = new WinFormsField("LIT-FWD", "LitFwd");
        public static WinFormsField LitBwd = new WinFormsField("LIT-BWD", "LitBwd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
