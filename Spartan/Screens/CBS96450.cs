using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS96450

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS96450", "FormName");
		//Fields


        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ParticipantName = new WinFormsField("PARTICIPANT-NAME", "ParticipantName");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField DisplayDesc = new WinFormsField("DISPLAY-DESC", "DisplayDesc");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField EntitlementBalance = new WinFormsField("ENTITLEMENT-BALANCE", "EntitlementBalance");
        //public static WinFormsField Code = new WinFormsField("CODE", "Code");
        //public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
