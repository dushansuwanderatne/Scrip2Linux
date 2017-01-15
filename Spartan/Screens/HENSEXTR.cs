using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSEXTR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSEXTR", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Selecting an extract file", "Selectinganextractfile");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Adding a holder to the extract file", "Addingaholdertotheextractfile");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
