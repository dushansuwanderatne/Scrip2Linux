using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSFP

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSFP", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Holder number/name/HIN", "Holdernumber/name/HIN");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Reference number", "Referencenumber");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
