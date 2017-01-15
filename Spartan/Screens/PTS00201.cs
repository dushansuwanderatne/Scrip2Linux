using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField PriorityT = new WinFormsField("PRIORITY-T", "PriorityT");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        //public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Logged = new WinFormsField("LOGGED", "Logged");
        public static WinFormsField LoggedBY = new WinFormsField("LOGGED-BY", "LoggedBY");
        public static WinFormsField Affected = new WinFormsField("AFFECTED", "Affected");
        public static WinFormsField Tasks = new WinFormsField("TASKS", "Tasks");
        public static WinFormsField ProblemNumber = new WinFormsField("PROBLEM-NUMBER", "ProblemNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
