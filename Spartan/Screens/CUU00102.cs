using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CUU00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CUU00102", "FormName");
		//Fields


        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
        public static WinFormsField DeptCode = new WinFormsField("DEPT-CODE", "DeptCode");
        public static WinFormsField DeptInfo = new WinFormsField("DEPT-INFO", "DeptInfo");
        public static WinFormsField ResetText = new WinFormsField("RESET-TEXT", "ResetText");
        public static WinFormsField UserPassword = new WinFormsField("USER-PASSWORD", "UserPassword");
        public static WinFormsField ResetText2 = new WinFormsField("RESET-TEXT2", "ResetText2");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
