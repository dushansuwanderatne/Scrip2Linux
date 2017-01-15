using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UNC01090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UNC01090", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
        public static WinFormsField ConfirmDeleteInd = new WinFormsField("CONFIRM-DELETE-IND", "ConfirmDeleteInd");
    }
}
