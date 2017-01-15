using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN01", "FormName");
		//Fields
        public static WinFormsField MenuItemPrt = new WinFormsField("MENU-ITEM-PRT", "PRT. Printing Options ...", "PrintingOptions...");
        public static WinFormsField MenuItemCpr = new WinFormsField("MENU-ITEM-CPR", "CPR. Control Printers ...", "ControlPrinters...");
        public static WinFormsField MenuItemJob = new WinFormsField("MENU-ITEM-JOB", "JOB. Check on JOB Queue(s)", "CheckonJOBQueue(s)");
        public static WinFormsField MenuItemRsp = new WinFormsField("MENU-ITEM-RSP", "RSP. Job Parameter File Options ...", "JobParameterFileOptions...");
        public static WinFormsField MenuItemFtp = new WinFormsField("MENU-ITEM-FTP", "FTP. File Transfer ...", "FileTransfer...");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Host Function System", "ExitHostFunctionSystem");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
