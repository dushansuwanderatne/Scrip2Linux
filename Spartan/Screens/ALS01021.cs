using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CorpAction = new WinFormsField("CORP-ACTION", "CorpAction");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}