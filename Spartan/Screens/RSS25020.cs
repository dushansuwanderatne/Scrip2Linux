using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS25020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS25020", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filnam = new WinFormsField("FILNAM", "Filnam");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField Size = new WinFormsField("SIZE", "Size");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
