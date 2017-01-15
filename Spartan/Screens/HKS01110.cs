using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01110", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ChessCumClassIN = new WinFormsField("CHESS-CUM-CLASS-IN", "ChessCumClassIN");
    }
}
