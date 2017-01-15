using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISS01045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISS01045", "FormName");
		//Fields


        public static WinFormsField BCDate = new WinFormsField("BC-DATE", "BCDate");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField BuildDeferDate = new WinFormsField("BUILD-DEFER-DATE", "BuildDeferDate");
        public static WinFormsField CNEntDate = new WinFormsField("CN-ENT-DATE", "CNEntDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
