using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07403", "FormName");
		//Fields


        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField MessageID = new WinFormsField("MESSAGE-ID", "MessageID");
        public static WinFormsField FullUserName = new WinFormsField("FULL-USER-NAME", "FullUserName");
        public static WinFormsField CompanyAsx = new WinFormsField("COMPANY-ASX", "CompanyAsx");
        public static WinFormsField CompanyStatus = new WinFormsField("COMPANY-STATUS", "CompanyStatus");
        public static WinFormsField NZUser = new WinFormsField("NZ-USER", "NZUser");
        public static WinFormsField LastResponse = new WinFormsField("LAST-RESPONSE", "LastResponse");
    }
}
