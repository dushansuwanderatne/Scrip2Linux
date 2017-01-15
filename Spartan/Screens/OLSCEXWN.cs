using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCEXWN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCEXWN", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClassCodesL1 = new WinFormsField("CLASS-CODES-L1", "ClassCodesL1");
        public static WinFormsField ClassCodesL2 = new WinFormsField("CLASS-CODES-L2", "ClassCodesL2");
        public static WinFormsField ClassCodesL3 = new WinFormsField("CLASS-CODES-L3", "ClassCodesL3");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
