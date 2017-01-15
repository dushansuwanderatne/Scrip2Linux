using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02503", "FormName");
		//Fields


        public static WinFormsField UserFrom = new WinFormsField("USER-FROM", "UserFrom");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField MessageDate = new WinFormsField("MESSAGE-DATE", "MessageDate");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField MessageLine = new WinFormsField("MESSAGE-LINE", "MessageLine");
        public static WinFormsField DeleteTag = new WinFormsField("DELETE-TAG", "DeleteTag");
        public static WinFormsField ReplyAck = new WinFormsField("REPLY-ACK", "ReplyAck");
    }
}
