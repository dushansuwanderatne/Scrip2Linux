using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS03002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS03002", "FormName");
		//Fields


        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Brief Report", "BriefReport");
        public static WinFormsField MenuItemFU = new WinFormsField("MENU-ITEM-FU", "FU. Full Report", "FullReport");
        public static WinFormsField MenuItemLB = new WinFormsField("MENU-ITEM-LB", "LB. Labels", "Labels");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP. Tape", "Tape");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP. Special Program", "SpecialProgram");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField SpecialProg = new WinFormsField("SPECIAL-PROG", "SpecialProg");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
    }
}
