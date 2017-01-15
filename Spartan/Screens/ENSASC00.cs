using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC00", "FormName");
		//Fields


        public static WinFormsField Title = new WinFormsField("TITLE", "Title");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
    }
}
