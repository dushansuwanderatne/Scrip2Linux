using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10025", "FormName");
		//Fields


        public static WinFormsField MenuItemM = new WinFormsField("MENU-ITEM-M", "M. Maturity Notices", "MaturityNotices");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C. Audit Certificates", "AuditCertificates");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R. Reminder Notices/Listing", "ReminderNotices/Listing");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Investment Account Statement", "InvestmentAccountStatement");
        public static WinFormsField MenuItemG = new WinFormsField("MENU-ITEM-G", "G. General Notices", "GeneralNotices");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField NoticeDate = new WinFormsField("NOTICE-DATE", "NoticeDate");
        public static WinFormsField DueDate = new WinFormsField("DUE-DATE", "DueDate");
        public static WinFormsField ActiveAccts = new WinFormsField("ACTIVE-ACCTS", "ActiveAccts");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
