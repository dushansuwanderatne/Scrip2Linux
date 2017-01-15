using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00410

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00410", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepSequence = new WinFormsField("REP-SEQUENCE", "RepSequence");
        public static WinFormsField FromRun = new WinFormsField("FROM-RUN", "FromRun");
        public static WinFormsField TORun = new WinFormsField("TO-RUN", "TORun");
    }
}
