using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB10", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  1 Part", "1Part");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  2 Part", "2Part");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  3 Part", "3Part");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S.  Special (Bureau to be informed)", "Special(Bureautobeinformed)");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T.  Sticky Labels", "StickyLabels");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P.  Plain Labels", "PlainLabels");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField FormType = new WinFormsField("FORM-TYPE", "FormType");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
    }
}
