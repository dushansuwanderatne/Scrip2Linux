using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSFC

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSFC", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Holder number/name/HIN", "Holdernumber/name/HIN");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Certificate number", "Certificatenumber");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Transaction number", "Transactionnumber");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
