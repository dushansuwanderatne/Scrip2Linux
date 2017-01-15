using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG07001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG07001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CoyCode = new WinFormsField("COY-CODE", "CoyCode");
        public static WinFormsField CoyName = new WinFormsField("COY-NAME", "CoyName");
        public static WinFormsField PendingHeldTotal = new WinFormsField("PENDING-HELD-TOTAL", "PendingHeldTotal");
        public static WinFormsField PendingCount = new WinFormsField("PENDING-COUNT", "PendingCount");
        public static WinFormsField HeldCount = new WinFormsField("HELD-COUNT", "HeldCount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
