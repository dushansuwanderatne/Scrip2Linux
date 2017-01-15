using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OverwriteYN = new WinFormsField("OVERWRITE-YN", "OverwriteYN");
    }
}
