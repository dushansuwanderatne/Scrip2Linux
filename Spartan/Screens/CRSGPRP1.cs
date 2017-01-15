using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSGPRP1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSGPRP1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField Line1 = new WinFormsField("LINE-1", "Line1");
        public static WinFormsField Line2 = new WinFormsField("LINE-2", "Line2");
        public static WinFormsField Line3 = new WinFormsField("LINE-3", "Line3");
        public static WinFormsField Line4 = new WinFormsField("LINE-4", "Line4");
        public static WinFormsField Line5 = new WinFormsField("LINE-5", "Line5");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField OFAddressee = new WinFormsField("OF-ADDRESSEE", "OFAddressee");
    }
}
