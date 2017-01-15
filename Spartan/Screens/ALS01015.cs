using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01015", "FormName");
		//Fields


        public static WinFormsField XtrName = new WinFormsField("XTR-NAME", "XtrName");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
