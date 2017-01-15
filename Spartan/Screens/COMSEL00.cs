using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COMSEL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COMSEL00", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Ufd = new WinFormsField("UFD", "Ufd");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField SelUfd = new WinFormsField("SEL-UFD", "SelUfd");
    }
}
