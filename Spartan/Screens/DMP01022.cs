using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01022", "FormName");
		//Fields


        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField Class1 = new WinFormsField("CLASS-1", "Class1");
        public static WinFormsField Class2 = new WinFormsField("CLASS-2", "Class2");
        public static WinFormsField Class3 = new WinFormsField("CLASS-3", "Class3");
        public static WinFormsField Class4 = new WinFormsField("CLASS-4", "Class4");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
