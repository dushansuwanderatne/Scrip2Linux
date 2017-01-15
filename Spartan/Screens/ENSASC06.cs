using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC06", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField GivenNames1 = new WinFormsField("GIVEN-NAMES1", "GivenNames1");
        public static WinFormsField GivenNames2 = new WinFormsField("GIVEN-NAMES2", "GivenNames2");
        public static WinFormsField DobDD = new WinFormsField("DOB-DD", "DobDD");
        public static WinFormsField DobMM = new WinFormsField("DOB-MM", "DobMM");
        public static WinFormsField DobYY = new WinFormsField("DOB-YY", "DobYY");
    }
}
