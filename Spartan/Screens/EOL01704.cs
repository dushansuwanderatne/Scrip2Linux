using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01704", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TermCode = new WinFormsField("TERM-CODE", "TermCode");
        public static WinFormsField TermDesc = new WinFormsField("TERM-DESC", "TermDesc");
    }
}
