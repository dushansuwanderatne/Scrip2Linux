using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01111

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01111", "FormName");
		//Fields


        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
