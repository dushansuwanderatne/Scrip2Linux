using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC06", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SelectionType = new WinFormsField("SELECTION-TYPE", "SelectionType");
        public static WinFormsField FromClass = new WinFormsField("FROM-CLASS", "FromClass");
        public static WinFormsField TOClass = new WinFormsField("TO-CLASS", "TOClass");
        public static WinFormsField S118 = new WinFormsField("S1-18", "S118");
        public static WinFormsField Cc118 = new WinFormsField("CC1-18", "Cc118");
        public static WinFormsField Cd118 = new WinFormsField("CD1-18", "Cd118");
        public static WinFormsField S1934 = new WinFormsField("S19-34", "S1934");
        public static WinFormsField Cc1934 = new WinFormsField("CC19-34", "Cc1934");
        public static WinFormsField Cd1934 = new WinFormsField("CD19-34", "Cd1934");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
    }
}
