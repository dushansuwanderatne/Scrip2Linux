using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01014", "FormName");
		//Fields
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField EventCurrentInd = new WinFormsField("EVENT-CURRENT-IND", "EventCurrentInd");
        public static WinFormsField EventClosedInd = new WinFormsField("EVENT-CLOSED-IND", "EventClosedInd");
        public static WinFormsField EventDescription = new WinFormsField("EVENT-DESCRIPTION", "EventDescription");
        public static WinFormsField EvtPeriodSta = new WinFormsField("EVT-PERIOD-STA", "EvtPeriodSta");
        public static WinFormsField EvtPeriodEnd = new WinFormsField("EVT-PERIOD-END", "EvtPeriodEnd");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField IncludeLeaversInd = new WinFormsField("INCLUDE-LEAVERS-IND", "IncludeLeaversInd");
        public static WinFormsField IncldBlktHldrInd = new WinFormsField("INCLD-BLKT-HLDR-IND", "IncldBlktHldrInd");
        public static WinFormsField HolderSelctnInd = new WinFormsField("HOLDER-SELCTN-IND", "HolderSelctnInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateEventType = new WinFormsField("LOCATE-EVENT-TYPE", "LocateEventType");
        public static WinFormsField LocateEventCode = new WinFormsField("LOCATE-EVENT-CODE", "LocateEventCode");
        public static WinFormsField LocateEventDate = new WinFormsField("LOCATE-EVENT-DATE", "LocateEventDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
