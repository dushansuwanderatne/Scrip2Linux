using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL08000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL08000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField DumpDescription = new WinFormsField("DUMP-DESCRIPTION", "DumpDescription");
        public static WinFormsField DumpRun = new WinFormsField("DUMP-RUN", "DumpRun");
    }
}
