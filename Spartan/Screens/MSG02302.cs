using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02302", "FormName");
		//Fields


        public static WinFormsField SentTO = new WinFormsField("SENT-TO", "SentTO");
        public static WinFormsField NbrUsersRead = new WinFormsField("NBR-USERS-READ", "NbrUsersRead");
        public static WinFormsField NbrUsersSentTO = new WinFormsField("NBR-USERS-SENT-TO", "NbrUsersSentTO");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField MessageLine = new WinFormsField("MESSAGE-LINE", "MessageLine");
        public static WinFormsField Delete = new WinFormsField("DELETE", "Delete");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField MessageDate = new WinFormsField("MESSAGE-DATE", "MessageDate");
    }
}
