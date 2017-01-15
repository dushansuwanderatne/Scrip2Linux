using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS96250

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS96250", "FormName");
		//Fields


        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ParticipantName = new WinFormsField("PARTICIPANT-NAME", "ParticipantName");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Balance = new WinFormsField("BALANCE", "Balance");
        public static WinFormsField OutFlag = new WinFormsField("OUT-FLAG", "OutFlag");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        //public static WinFormsField Balance = new WinFormsField("BALANCE", "Balance");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
