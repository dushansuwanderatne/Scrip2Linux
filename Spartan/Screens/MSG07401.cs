using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField FullUserName = new WinFormsField("FULL-USER-NAME", "FullUserName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
