using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00101", "FormName");
		//Fields
        public static WinFormsField MenuItemNxt = new WinFormsField("MENU-ITEM-NXT", "NXT. *** Next screen with more codes", "***Nextscreenwithmorecodes");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField ApprovalFlag = new WinFormsField("APPROVAL-FLAG", "ApprovalFlag");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
