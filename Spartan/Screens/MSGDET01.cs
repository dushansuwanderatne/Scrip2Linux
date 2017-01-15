using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSGDET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSGDET01", "FormName");
		//Fields


        public static WinFormsField MsgdetKey0 = new WinFormsField("MSGDET-KEY0", "MsgdetKey0");
        public static WinFormsField UserIdentifierFrom = new WinFormsField("USER-IDENTIFIER-FROM", "UserIdentifierFrom");
        public static WinFormsField InitialsFrom = new WinFormsField("INITIALS-FROM", "InitialsFrom");
        public static WinFormsField NodeFrom = new WinFormsField("NODE-FROM", "NodeFrom");
        public static WinFormsField ClientCodeFrom = new WinFormsField("CLIENT-CODE-FROM", "ClientCodeFrom");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField ClientCodeTO = new WinFormsField("CLIENT-CODE-TO", "ClientCodeTO");
        public static WinFormsField UserIdentifierTO = new WinFormsField("USER-IDENTIFIER-TO", "UserIdentifierTO");
        public static WinFormsField NumberUsersSentTO = new WinFormsField("NUMBER-USERS-SENT-TO", "NumberUsersSentTO");
        public static WinFormsField NumberUsersRead = new WinFormsField("NUMBER-USERS-READ", "NumberUsersRead");
        public static WinFormsField DateSent = new WinFormsField("DATE-SENT", "DateSent");
        public static WinFormsField NameFrom = new WinFormsField("NAME-FROM", "NameFrom");
        public static WinFormsField OriginalNumber = new WinFormsField("ORIGINAL-NUMBER", "OriginalNumber");
        public static WinFormsField DateSendOverNetwork = new WinFormsField("DATE-SEND-OVER-NETWORK", "DateSendOverNetwork");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField ConfidentialFlag = new WinFormsField("CONFIDENTIAL-FLAG", "ConfidentialFlag");
        public static WinFormsField OneOnly = new WinFormsField("ONE-ONLY", "OneOnly");
        public static WinFormsField AcknowledgeFlag = new WinFormsField("ACKNOWLEDGE-FLAG", "AcknowledgeFlag");
        public static WinFormsField SystemGeneratedFlag = new WinFormsField("SYSTEM-GENERATED-FLAG", "SystemGeneratedFlag");
        public static WinFormsField AutomaticReplyFlag = new WinFormsField("AUTOMATIC-REPLY-FLAG", "AutomaticReplyFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
