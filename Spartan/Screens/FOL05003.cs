using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL05003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL05003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MarkingNumber = new WinFormsField("MARKING-NUMBER", "MarkingNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
