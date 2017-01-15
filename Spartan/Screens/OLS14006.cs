using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS14006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS14006", "FormName");
		//Fields


        public static WinFormsField StepCode = new WinFormsField("STEP-CODE", "StepCode");
        public static WinFormsField NoteTxtL1 = new WinFormsField("NOTE-TXT-L1", "NoteTxtL1");
        public static WinFormsField NoteTxtL2 = new WinFormsField("NOTE-TXT-L2", "NoteTxtL2");
        public static WinFormsField NoteTxtL3 = new WinFormsField("NOTE-TXT-L3", "NoteTxtL3");
        public static WinFormsField NoteTxtL4 = new WinFormsField("NOTE-TXT-L4", "NoteTxtL4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
