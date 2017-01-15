using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07402", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField FullUserName = new WinFormsField("FULL-USER-NAME", "FullUserName");
        public static WinFormsField CompanyAsx = new WinFormsField("COMPANY-ASX", "CompanyAsx");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
