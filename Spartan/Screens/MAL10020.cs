using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL10020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL10020", "FormName");
		//Fields


        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL.  Participant List", "ParticipantList");
        public static WinFormsField MenuItemLB = new WinFormsField("MENU-ITEM-LB", "LB.  Labels", "Labels");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
    }
}
