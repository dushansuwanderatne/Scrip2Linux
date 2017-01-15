using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEQFIL

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEQFIL", "FormName");
		//Fields


        public static WinFormsField MenuItemAttach = new WinFormsField("MENU-ITEM-ATTACH", "ATTACH. Attach to a company", "Attachtoacompany");
        public static WinFormsField MenuItemOpenfi = new WinFormsField("MENU-ITEM-OPENFI", "OPENFILE. Open sequential file", "Opensequentialfile");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
    }
}
