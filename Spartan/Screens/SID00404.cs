using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00404", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SelCodes110 = new WinFormsField("SEL-CODES-1-10", "SelCodes110");
        public static WinFormsField SelCodes1120 = new WinFormsField("SEL-CODES-11-20", "SelCodes1120");
        public static WinFormsField SelCodes2130 = new WinFormsField("SEL-CODES-21-30", "SelCodes2130");
        public static WinFormsField SelCodes3140 = new WinFormsField("SEL-CODES-31-40", "SelCodes3140");
    }
}
