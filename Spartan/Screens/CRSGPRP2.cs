using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSGPRP2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSGPRP2", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Form = new WinFormsField("FORM", "Form");
        public static WinFormsField Count = new WinFormsField("COUNT", "Count");
        public static WinFormsField Investor = new WinFormsField("INVESTOR", "Investor");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
