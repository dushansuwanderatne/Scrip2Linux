using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD24005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD24005", "FormName");
		//Fields


        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargeDescription = new WinFormsField("CHARGE-DESCRIPTION", "ChargeDescription");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField Acknowledge = new WinFormsField("ACKNOWLEDGE", "Acknowledge");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
