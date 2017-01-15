using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00103", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TaskCodeErr = new WinFormsField("TASK-CODE-ERR", "TaskCodeErr");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField TaskCode = new WinFormsField("TASK-CODE", "TaskCode");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
