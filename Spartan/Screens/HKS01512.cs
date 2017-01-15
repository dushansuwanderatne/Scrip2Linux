using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01512

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01512", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SignificantSeq = new WinFormsField("SIGNIFICANT-SEQ", "SignificantSeq");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
