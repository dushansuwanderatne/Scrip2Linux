using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00215

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00215", "FormName");
		//Fields


        public static WinFormsField WorkClass = new WinFormsField("WORK-CLASS", "WorkClass");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField WorkClassB = new WinFormsField("WORK-CLASS-B", "WorkClassB");
    }
}
