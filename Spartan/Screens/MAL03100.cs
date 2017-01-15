using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL03100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL03100", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField AddCode = new WinFormsField("ADD-CODE", "AddCode");
        public static WinFormsField GroupDesc = new WinFormsField("GROUP-DESC", "GroupDesc");
        public static WinFormsField Total = new WinFormsField("TOTAL", "Total");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchGroup = new WinFormsField("SEARCH-GROUP", "SearchGroup");
    }
}
