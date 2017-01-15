using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS10099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS10099", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField EnquiryScope = new WinFormsField("ENQUIRY-SCOPE", "EnquiryScope");
    }
}
