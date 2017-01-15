using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS20104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS20104", "FormName");
		//Fields


        public static WinFormsField SelectionNumberX = new WinFormsField("SELECTION-NUMBER-X", "SelectionNumberX");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Address1 = new WinFormsField("ADDRESS-1", "Address1");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
