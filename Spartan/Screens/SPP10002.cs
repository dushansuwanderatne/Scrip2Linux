using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP10002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP10002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DateDesc = new WinFormsField("DATE-DESC", "DateDesc");
        public static WinFormsField ConfirmationDate = new WinFormsField("CONFIRMATION-DATE", "ConfirmationDate");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
