using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSMRAQ1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSMRAQ1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Balance = new WinFormsField("BALANCE", "Balance");
        //public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ID = new WinFormsField("ID", "ID");
        public static WinFormsField ReconciliationMessage = new WinFormsField("RECONCILIATION-MESSAGE", "ReconciliationMessage");
    }
}
