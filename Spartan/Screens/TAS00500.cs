using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00500", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ProjectCode = new WinFormsField("PROJECT-CODE", "ProjectCode");
        public static WinFormsField ProjectDesc = new WinFormsField("PROJECT-DESC", "ProjectDesc");
        public static WinFormsField ChargeFlag = new WinFormsField("CHARGE-FLAG", "ChargeFlag");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
