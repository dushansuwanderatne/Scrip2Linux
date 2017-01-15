using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS04020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS04020", "FormName");
		//Fields
        public static WinFormsField ScreenLine = new WinFormsField("SCREEN-LINE", "ScreenLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField String = new WinFormsField("STRING", "String");
    }
}
