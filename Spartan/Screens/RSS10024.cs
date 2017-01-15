using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10024", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PrintStaticNotes = new WinFormsField("PRINT-STATIC-NOTES", "PrintStaticNotes");
        public static WinFormsField PrintStaticChange = new WinFormsField("PRINT-STATIC-CHANGE", "PrintStaticChange");
        public static WinFormsField PrintStaticDivhis = new WinFormsField("PRINT-STATIC-DIVHIS", "PrintStaticDivhis");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
