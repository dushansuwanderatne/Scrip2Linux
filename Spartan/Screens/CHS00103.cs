using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS00103", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField TransProc = new WinFormsField("TRANS-PROC", "TransProc");
    }
}
