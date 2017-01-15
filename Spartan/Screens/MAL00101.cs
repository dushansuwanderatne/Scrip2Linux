using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL00101", "FormName");
		//Fields


        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER. Extract Reporting", "ExtractReporting");
        public static WinFormsField MenuItemCF = new WinFormsField("MENU-ITEM-CF", "CF. Control File Listings", "ControlFileListings");
        public static WinFormsField MenuItemRR = new WinFormsField("MENU-ITEM-RR", "RR. Reporting Run", "ReportingRun");
        public static WinFormsField MenuItemLP = new WinFormsField("MENU-ITEM-LP", "LP. Like Participants Summary", "LikeParticipantsSummary");
        public static WinFormsField MenuItemMS = new WinFormsField("MENU-ITEM-MS", "MS. Mailing Statistics Report", "MailingStatisticsReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit from System", "ExitfromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
