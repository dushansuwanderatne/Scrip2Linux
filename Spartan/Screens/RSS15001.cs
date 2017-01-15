using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS15001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS15001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AsxCode1 = new WinFormsField("ASX-CODE1", "AsxCode1");
        public static WinFormsField ClsCode1 = new WinFormsField("CLS-CODE1", "ClsCode1");
        public static WinFormsField AsxCode2 = new WinFormsField("ASX-CODE2", "AsxCode2");
        public static WinFormsField ClsCode2 = new WinFormsField("CLS-CODE2", "ClsCode2");
        public static WinFormsField AsxCode3 = new WinFormsField("ASX-CODE3", "AsxCode3");
        public static WinFormsField ClsCode3 = new WinFormsField("CLS-CODE3", "ClsCode3");
        public static WinFormsField AsxCode4 = new WinFormsField("ASX-CODE4", "AsxCode4");
        public static WinFormsField ClsCode4 = new WinFormsField("CLS-CODE4", "ClsCode4");
        public static WinFormsField KeyMatch = new WinFormsField("KEY-MATCH", "KeyMatch");
        public static WinFormsField IncludePcode = new WinFormsField("INCLUDE-PCODE", "IncludePcode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
