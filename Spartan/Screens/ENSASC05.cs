using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC05", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Enquiries", "Enquiries");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2. Extracts", "Extracts");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Sel = new WinFormsField("SEL", "Sel");
    }
}
