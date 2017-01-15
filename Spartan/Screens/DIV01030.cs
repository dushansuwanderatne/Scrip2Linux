using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Scrip2by60 = new WinFormsField("SCRIP-2BY60", "Scrip2by60");
        public static WinFormsField Scrip3by40 = new WinFormsField("SCRIP-3BY40", "Scrip3by40");
    }
}
