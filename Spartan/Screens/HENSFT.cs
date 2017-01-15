using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSFT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSFT", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Register transactions", "Registertransactions");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Static detail (maintenance) transactions", "Staticdetail(maintenance)transactions");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
