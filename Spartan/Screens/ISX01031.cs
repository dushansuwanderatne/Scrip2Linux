using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01031

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01031", "FormName");
		//Fields


        public static WinFormsField CorpAction = new WinFormsField("CORP-ACTION", "CorpAction");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
