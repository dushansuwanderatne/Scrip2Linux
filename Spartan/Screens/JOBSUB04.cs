using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB04", "FormName");
        public static WinFormsField StatutoryRep = new WinFormsField("STATUTORY-REP", "StatutoryRep");
        public static WinFormsField RepType = new WinFormsField("REP-TYPE", "RepType");
        public static WinFormsField OutputMedium = new WinFormsField("OUTPUT-MEDIUM", "OutputMedium");
        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "ServiceProvider");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
