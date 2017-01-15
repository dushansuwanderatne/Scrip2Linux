using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01002", "FormName");
		//Fields


        public static WinFormsField MenuItemIps = new WinFormsField("MENU-ITEM-IPS", "IPS.  Issue Parameter Setup", "IssueParameterSetup");
        public static WinFormsField MenuItemIcp = new WinFormsField("MENU-ITEM-ICP", "ICP.  Issue Calculation Process ", "IssueCalculationProcess");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
