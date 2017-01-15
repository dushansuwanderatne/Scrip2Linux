using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01115

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01115", "FormName");
		//Fields


        public static WinFormsField SecasxCode = new WinFormsField("SECASX-CODE", "SecasxCode");
        public static WinFormsField UnlistClass1 = new WinFormsField("UNLIST-CLASS1", "UnlistClass1");
        public static WinFormsField UnlistClass2 = new WinFormsField("UNLIST-CLASS2", "UnlistClass2");
        public static WinFormsField ListedClass = new WinFormsField("LISTED-CLASS", "ListedClass");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
    }
}
