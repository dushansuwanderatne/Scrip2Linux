using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS06001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS06001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField UserOrigin = new WinFormsField("USER-ORIGIN", "UserOrigin");
        public static WinFormsField SelectFormCode = new WinFormsField("SELECT-FORM-CODE", "SelectFormCode");
        public static WinFormsField RequestFormCode = new WinFormsField("REQUEST-FORM-CODE", "RequestFormCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
