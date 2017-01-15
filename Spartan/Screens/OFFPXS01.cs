using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OFFPXS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OFFPXS01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AttendeeNum = new WinFormsField("ATTENDEE-NUM", "AttendeeNum");
        public static WinFormsField HinNumber = new WinFormsField("HIN-NUMBER", "HinNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Address = new WinFormsField("ADDRESS", "Address");
    }
}
