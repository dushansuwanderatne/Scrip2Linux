using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP16

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP16", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransUic = new WinFormsField("TRANS-UIC", "TransUic");
        public static WinFormsField TransReference = new WinFormsField("TRANS-REFERENCE", "TransReference");
        public static WinFormsField ErrorReason = new WinFormsField("ERROR-REASON", "ErrorReason");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
