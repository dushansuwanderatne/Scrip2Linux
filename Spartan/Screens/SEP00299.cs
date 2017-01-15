using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00299

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00299", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ControlRun = new WinFormsField("CONTROL-RUN", "ControlRun");
        public static WinFormsField AllvotRun = new WinFormsField("ALLVOT-RUN", "AllvotRun");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
