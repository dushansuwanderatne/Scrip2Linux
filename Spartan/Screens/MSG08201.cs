using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField MessageText = new WinFormsField("MESSAGE-TEXT", "MessageText");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchDate = new WinFormsField("SEARCH-DATE", "SearchDate");
        public static WinFormsField SearchTime = new WinFormsField("SEARCH-TIME", "SearchTime");
    }
}
