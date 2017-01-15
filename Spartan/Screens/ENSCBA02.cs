using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSCBA02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSCBA02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ApplicNO = new WinFormsField("APPLIC-NO", "ApplicNO");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField SearchMethod = new WinFormsField("SEARCH-METHOD", "SearchMethod");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
