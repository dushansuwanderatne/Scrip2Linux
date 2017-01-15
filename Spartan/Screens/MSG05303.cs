using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05303

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05303", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RealNode = new WinFormsField("REAL-NODE", "RealNode");
        public static WinFormsField ConfirmFlag = new WinFormsField("CONFIRM-FLAG", "ConfirmFlag");
    }
}
