using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OFFPXS02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OFFPXS02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AttendeeNum = new WinFormsField("ATTENDEE-NUM", "AttendeeNum");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
    }
}
