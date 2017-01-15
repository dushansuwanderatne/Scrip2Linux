using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01015", "FormName");
		//Fields


        public static WinFormsField MenuItemOpt = new WinFormsField("MENU-ITEM-OPT", "OPT.  Outstanding Pending Transactions", "OutstandingPendingTransactions");
        public static WinFormsField MenuItemUrh = new WinFormsField("MENU-ITEM-URH", "URH.  Update Reporting Run History", "UpdateReportingRunHistory");
        public static WinFormsField MenuItemGca = new WinFormsField("MENU-ITEM-GCA", "GCA.  Get Corporate Actions For A Security", "GetCorporateActionsForASecurity");
        public static WinFormsField MenuItemCpc = new WinFormsField("MENU-ITEM-CPC", "CPC.  Companies Pending Chess Conversions", "CompaniesPendingChessConversions");
        public static WinFormsField MenuItemUsc = new WinFormsField("MENU-ITEM-USC", "USC.  User/Status In Company", "User/StatusInCompany");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ProcessGroupCode = new WinFormsField("PROCESS-GROUP-CODE", "ProcessGroupCode");
    }
}
