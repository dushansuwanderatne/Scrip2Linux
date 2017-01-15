using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSKCAQ1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSKCAQ1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
    }
}
