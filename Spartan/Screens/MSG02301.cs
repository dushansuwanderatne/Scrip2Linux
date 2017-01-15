using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02301", "FormName");
		//Fields


        public static WinFormsField PostedDate = new WinFormsField("POSTED-DATE", "PostedDate");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField ReadMessage = new WinFormsField("READ-MESSAGE", "ReadMessage");
    }
}
