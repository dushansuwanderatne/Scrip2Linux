using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField InvProcessType = new WinFormsField("INV-PROCESS-TYPE", "InvProcessType");
        public static WinFormsField LastAllotPeriod = new WinFormsField("LAST-ALLOT-PERIOD", "LastAllotPeriod");
        public static WinFormsField LastAllotDate = new WinFormsField("LAST-ALLOT-DATE", "LastAllotDate");
        public static WinFormsField ProcCurrent = new WinFormsField("PROC-CURRENT", "ProcCurrent");
        public static WinFormsField More = new WinFormsField("MORE", "More");
        public static WinFormsField Preload = new WinFormsField("PRELOAD", "Preload");
        public static WinFormsField InputInvProcess = new WinFormsField("INPUT-INV-PROCESS", "InputInvProcess");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
