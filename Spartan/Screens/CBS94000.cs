using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS94000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS94000", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ParticipantName = new WinFormsField("PARTICIPANT-NAME", "ParticipantName");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField DisplayDesc = new WinFormsField("DISPLAY-DESC", "DisplayDesc");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        //public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        //public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        //public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        //public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField First = new WinFormsField("1ST", "1st");
        public static WinFormsField Pid = new WinFormsField("PID", "Pid");
        public static WinFormsField Delete = new WinFormsField("DELETE", "Delete");
        public static WinFormsField Security = new WinFormsField("SECURITY", "Security");
    }
}
