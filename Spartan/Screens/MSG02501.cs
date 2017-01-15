using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02501", "FormName");
		//Fields


        public static WinFormsField MenuItemN = new WinFormsField("MENU-ITEM-N", "N. Read new (unread)", "Readnew(unread)");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Scan messages", "Scanmessages");
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Read ALL messages", "ReadALLmessages");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField TotalMessages = new WinFormsField("TOTAL-MESSAGES", "TotalMessages");
        public static WinFormsField UnreadMessages = new WinFormsField("UNREAD-MESSAGES", "UnreadMessages");
        public static WinFormsField EarliestDate = new WinFormsField("EARLIEST-DATE", "EarliestDate");
        public static WinFormsField ReadAction = new WinFormsField("READ-ACTION", "ReadAction");
    }
}
