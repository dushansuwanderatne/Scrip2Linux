using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS03001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField GroupDesc = new WinFormsField("GROUP-DESC", "GroupDesc");
        public static WinFormsField Class1 = new WinFormsField("CLASS1", "Class1");
        public static WinFormsField Class2 = new WinFormsField("CLASS2", "Class2");
        public static WinFormsField Class3 = new WinFormsField("CLASS3", "Class3");
        public static WinFormsField Class4 = new WinFormsField("CLASS4", "Class4");
        public static WinFormsField Class5 = new WinFormsField("CLASS5", "Class5");
        public static WinFormsField Exit = new WinFormsField("EXIT", "Exit");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
