using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC02", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Enquiries", "Enquiries");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2. Extracts", "Extracts");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3. Document Copies", "DocumentCopies");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Sel = new WinFormsField("SEL", "Sel");
    }
}
