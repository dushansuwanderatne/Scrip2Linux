using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP22

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP22", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField ErrorReason1 = new WinFormsField("ERROR-REASON-1", "ErrorReason1");
        public static WinFormsField ErrorReason2 = new WinFormsField("ERROR-REASON-2", "ErrorReason2");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
