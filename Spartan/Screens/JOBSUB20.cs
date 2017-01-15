using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB20", "FormName");
		//Fields


        public static WinFormsField MenuItem1P = new WinFormsField("MENU-ITEM-1P", "1P. 1 Part", "1Part");
        public static WinFormsField MenuItem2P = new WinFormsField("MENU-ITEM-2P", "2P. 2 Part", "2Part");
        public static WinFormsField MenuItem3P = new WinFormsField("MENU-ITEM-3P", "3P. 3 Part", "3Part");
        public static WinFormsField MenuItemMF = new WinFormsField("MENU-ITEM-MF", "MF. Microfische", "Microfische");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Sticky Labels", "StickyLabels");
        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL. Plain Labels", "PlainLabels");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP. Special (Bureau to be informed)", "Special(Bureautobeinformed)");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP. Tape", "Tape");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField FormType = new WinFormsField("FORM-TYPE", "FormType");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
    }
}
