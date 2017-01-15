using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01040", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField OldYearWarn1 = new WinFormsField("OLD-YEAR-WARN-1", "OldYearWarn1");
        public static WinFormsField NewYearWarn1 = new WinFormsField("NEW-YEAR-WARN-1", "NewYearWarn1");
        public static WinFormsField OldYearWarn2 = new WinFormsField("OLD-YEAR-WARN-2", "OldYearWarn2");
        public static WinFormsField NewYearWarn2 = new WinFormsField("NEW-YEAR-WARN-2", "NewYearWarn2");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
