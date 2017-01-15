using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOMADD10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOMADD10", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField AtdType = new WinFormsField("ATD-TYPE", "AtdType");
        public static WinFormsField RestrictionType = new WinFormsField("RESTRICTION-TYPE", "RestrictionType");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
