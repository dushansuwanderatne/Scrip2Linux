using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSZHDR0

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSZHDR0", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField RequestInd = new WinFormsField("REQUEST-IND", "RequestInd");
        public static WinFormsField MessageType = new WinFormsField("MESSAGE-TYPE", "MessageType");
        public static WinFormsField Mde = new WinFormsField("MDE", "Mde");
        public static WinFormsField Num = new WinFormsField("NUM", "Num");
        public static WinFormsField TransfrItemNum = new WinFormsField("TRANSFR-ITEM-NUM", "TransfrItemNum");
        public static WinFormsField TransfrSeqNum = new WinFormsField("TRANSFR-SEQ-NUM", "TransfrSeqNum");
        public static WinFormsField ID = new WinFormsField("ID", "ID");
        public static WinFormsField Ref = new WinFormsField("REF", "Ref");
    }
}
