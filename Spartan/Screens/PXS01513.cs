using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01513

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01513", "FormName");
		//Fields
        public static WinFormsField AttendeeNumber = new WinFormsField("ATTENDEE-NUMBER", "AttendeeNumber");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
