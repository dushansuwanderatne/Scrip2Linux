using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS03001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField File120 = new WinFormsField("FILE-1-20", "File120");
        public static WinFormsField File2140 = new WinFormsField("FILE-21-40", "File2140");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
