using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01039

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01039", "FormName");
		//Fields
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgumentPln = new WinFormsField("LOCATE-ARGUMENT-PLN", "LocateArgumentPln");
        public static WinFormsField LocateArgumentSch = new WinFormsField("LOCATE-ARGUMENT-SCH", "LocateArgumentSch");
        public static WinFormsField LocateArgumentLvr = new WinFormsField("LOCATE-ARGUMENT-LVR", "LocateArgumentLvr");
        public static WinFormsField LocateArgumentEmp = new WinFormsField("LOCATE-ARGUMENT-EMP", "LocateArgumentEmp");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
