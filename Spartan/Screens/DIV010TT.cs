using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV010TT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV010TT", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField Heading1 = new WinFormsField("HEADING-1", "Heading1");
        public static WinFormsField Heading2 = new WinFormsField("HEADING-2", "Heading2");
        public static WinFormsField TttRate = new WinFormsField("TTT-RATE", "TttRate");
    }
}
