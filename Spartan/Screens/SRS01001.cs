using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01001", "FormName");
		//Fields


        public static WinFormsField MenuItemCH = new WinFormsField("MENU-ITEM-CH", "CH.  Chronological", "Chronological");
        public static WinFormsField MenuItemTT = new WinFormsField("MENU-ITEM-TT", "TT.  Totr/Tetr", "Totr/Tetr");
        public static WinFormsField MenuItemRC = new WinFormsField("MENU-ITEM-RC", "RC.  Reverse Chronological", "ReverseChronological");
        public static WinFormsField MenuItemCI = new WinFormsField("MENU-ITEM-CI", "CI.  Confirmation of Issuer Sponsored Holdings", "ConfirmationofIssuerSponsoredHoldings");
        public static WinFormsField MenuItemCE = new WinFormsField("MENU-ITEM-CE", "CE.  Company Event Display", "CompanyEventDisplay");
        public static WinFormsField MenuItemPU = new WinFormsField("MENU-ITEM-PU", "PU.  Password Update", "PasswordUpdate");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR.  Create Registration Down Load File", "CreateRegistrationDownLoadFile");
        public static WinFormsField MenuItemLP = new WinFormsField("MENU-ITEM-LP", "LP.  List Participating Companies", "ListParticipatingCompanies");
        public static WinFormsField MenuItemLN = new WinFormsField("MENU-ITEM-LN", "LN.  Latest News and Information", "LatestNewsandInformation");
        public static WinFormsField MenuItemCN = new WinFormsField("MENU-ITEM-CN", "CN.  Change Institution Participation Number", "ChangeInstitutionParticipationNumber");
        public static WinFormsField MenuItemHS = new WinFormsField("MENU-ITEM-HS", "HS.  Holder Summary Report", "HolderSummaryReport");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU.  SURE Utilities", "SUREUtilities");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit SURE System", "ExitSURESystem");
        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoUser1 = new WinFormsField("SYSTEM-INFO-USER-1", "11", "11");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
