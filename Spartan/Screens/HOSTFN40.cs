using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN40

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN40", "FormName");
		//Fields


        public static WinFormsField MenuItemSftp = new WinFormsField("MENU-ITEM-SFTP", "SFTP.  Select Files to Transfer", "SelectFilestoTransfer");
        public static WinFormsField MenuItemAftp = new WinFormsField("MENU-ITEM-AFTP", "AFTP.  Authorise Transfer of Files", "AuthoriseTransferofFiles");
        public static WinFormsField MenuItemEftp = new WinFormsField("MENU-ITEM-EFTP", "EFTP.  Enquire on Transfers", "EnquireonTransfers");
        public static WinFormsField MenuItemEofs = new WinFormsField("MENU-ITEM-EOFS", "EOFS.  Enquire on FTP Setup", "EnquireonFTPSetup");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
