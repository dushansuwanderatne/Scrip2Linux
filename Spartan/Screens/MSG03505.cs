using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG03505

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG03505", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserNamePosted = new WinFormsField("USER-NAME-POSTED", "UserNamePosted");
        public static WinFormsField ActivityDate = new WinFormsField("ACTIVITY-DATE", "ActivityDate");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
