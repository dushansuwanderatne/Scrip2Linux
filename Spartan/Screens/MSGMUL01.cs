using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSGMUL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSGMUL01", "FormName");
		//Fields


        public static WinFormsField MsgmulKey0 = new WinFormsField("MSGMUL-KEY0", "MsgmulKey0");
        public static WinFormsField UserIdentifier = new WinFormsField("USER-IDENTIFIER", "UserIdentifier");
        public static WinFormsField NodeTO = new WinFormsField("NODE-TO", "NodeTO");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField MessageNumber = new WinFormsField("MESSAGE-NUMBER", "MessageNumber");
        public static WinFormsField AbortCount = new WinFormsField("ABORT-COUNT", "AbortCount");
        public static WinFormsField SentAbortFlag = new WinFormsField("SENT-ABORT-FLAG", "SentAbortFlag");
        public static WinFormsField MsgmulTagged = new WinFormsField("MSGMUL-TAGGED", "MsgmulTagged");
        public static WinFormsField DateRead = new WinFormsField("DATE-READ", "DateRead");
        public static WinFormsField DateReplied = new WinFormsField("DATE-REPLIED", "DateReplied");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
