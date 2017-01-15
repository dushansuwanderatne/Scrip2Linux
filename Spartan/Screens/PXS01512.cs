using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01512

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01512", "FormName");
		//Fields
        public static WinFormsField AttendeeNumber = new WinFormsField("ATTENDEE-NUMBER", "AttendeeNumber");
        public static WinFormsField AttendeeType = new WinFormsField("ATTENDEE-TYPE", "AttendeeType");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
