using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01093

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01093", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Variable Flag 1", "VariableFlag1");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2. Variable Flag 2", "VariableFlag2");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3. Variable Flag 3", "VariableFlag3");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4. Variable Flag 4", "VariableFlag4");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5. Variable Flag 5", "VariableFlag5");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6. Variable Field", "VariableField");
        public static WinFormsField Breakup1 = new WinFormsField("BREAKUP-1", "Breakup1");
        public static WinFormsField Breakup2 = new WinFormsField("BREAKUP-2", "Breakup2");
    }
}
