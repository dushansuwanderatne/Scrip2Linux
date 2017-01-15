using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01227

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01227", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField StreetNbr = new WinFormsField("STREET-NBR", "StreetNbr");
        public static WinFormsField StreetRange = new WinFormsField("STREET-RANGE", "StreetRange");
        public static WinFormsField StreetOpt = new WinFormsField("STREET-OPT", "StreetOpt");
        public static WinFormsField StreetName = new WinFormsField("STREET-NAME", "StreetName");
        public static WinFormsField LocalityOpt = new WinFormsField("LOCALITY-OPT", "LocalityOpt");
        public static WinFormsField Locality = new WinFormsField("LOCALITY", "Locality");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
