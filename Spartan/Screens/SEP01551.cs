using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP01551

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP01551", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AttendeeNum = new WinFormsField("ATTENDEE-NUM", "AttendeeNum");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField NewName = new WinFormsField("NEW-NAME", "NewName");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
