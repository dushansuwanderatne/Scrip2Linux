using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00104", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AllvotRun = new WinFormsField("ALLVOT-RUN", "AllvotRun");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
