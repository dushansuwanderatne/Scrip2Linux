using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP01512

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP01512", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AttendeeNumber = new WinFormsField("ATTENDEE-NUMBER", "AttendeeNumber");
        public static WinFormsField AttendeeType = new WinFormsField("ATTENDEE-TYPE", "AttendeeType");
    }
}
