using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP01513

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP01513", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AttendeeNumber = new WinFormsField("ATTENDEE-NUMBER", "AttendeeNumber");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
