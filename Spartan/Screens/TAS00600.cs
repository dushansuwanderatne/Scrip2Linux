using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00600", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField TaskCode = new WinFormsField("TASK-CODE", "TaskCode");
        public static WinFormsField TaskDescription = new WinFormsField("TASK-DESCRIPTION", "TaskDescription");
        public static WinFormsField DollarValue = new WinFormsField("DOLLAR-VALUE", "DollarValue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
