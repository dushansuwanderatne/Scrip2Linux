using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Sex = new WinFormsField("SEX", "Sex");
    }
}
