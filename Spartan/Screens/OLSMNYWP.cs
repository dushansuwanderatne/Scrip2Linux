using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSMNYWP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSMNYWP", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Arrow = new WinFormsField("ARROW", "Arrow");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
    }
}
