using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSCONF0

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSCONF0", "FormName");
		//Fields


        public static WinFormsField Message1 = new WinFormsField("MESSAGE-1", "Message1");
        public static WinFormsField Message2 = new WinFormsField("MESSAGE-2", "Message2");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
