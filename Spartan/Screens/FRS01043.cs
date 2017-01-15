using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS01043

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS01043", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField ReversalDate = new WinFormsField("REVERSAL-DATE", "ReversalDate");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
