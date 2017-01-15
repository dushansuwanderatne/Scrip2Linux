using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSCBA01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSCBA01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ApplicationNumber = new WinFormsField("APPLICATION-NUMBER", "ApplicationNumber");
        public static WinFormsField ShareholderID = new WinFormsField("SHAREHOLDER-ID", "ShareholderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
    }
}
