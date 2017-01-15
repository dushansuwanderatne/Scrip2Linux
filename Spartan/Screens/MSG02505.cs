using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02505

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02505", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserFrom = new WinFormsField("USER-FROM", "UserFrom");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField MessageDate = new WinFormsField("MESSAGE-DATE", "MessageDate");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}