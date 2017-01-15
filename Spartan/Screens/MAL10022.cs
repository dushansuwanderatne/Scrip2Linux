using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL10022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL10022", "FormName");
		//Fields


        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Alpha", "Alpha");
        public static WinFormsField MenuItemI = new WinFormsField("MENU-ITEM-I", "I. Participant Id.", "ParticipantId.");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Postcode", "Postcode");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Special Pre-Sort Plan", "SpecialPre-SortPlan");
        public static WinFormsField MenuItemX = new WinFormsField("MENU-ITEM-X", "X. Alpha Within Aust (Overseas at end)", "AlphaWithinAust(Overseasatend)");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
    }
}
