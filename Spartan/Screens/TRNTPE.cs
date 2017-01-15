using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRNTPE

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRNTPE", "FormName");
		//Fields


        public static WinFormsField MenuItemXtt0 = new WinFormsField("MENU-ITEM-XTT0", "XTT0.  Batch header record (always at start of batch)", "Batchheaderrecord(alwaysatstartofbatch)");
        public static WinFormsField MenuItemXtt1 = new WinFormsField("MENU-ITEM-XTT1", "XTT1.  Cert transactions", "Certtransactions");
        public static WinFormsField MenuItemXtt2 = new WinFormsField("MENU-ITEM-XTT2", "XTT2.  HLDADD transactions", "HLDADDtransactions");
        public static WinFormsField MenuItemXtt3 = new WinFormsField("MENU-ITEM-XTT3", "XTT3.  Payee Instructions", "PayeeInstructions");
        public static WinFormsField MenuItemXtt4 = new WinFormsField("MENU-ITEM-XTT4", "XTT4.  Dividend Intentions", "DividendIntentions");
        public static WinFormsField MenuItemXtt5D = new WinFormsField("MENU-ITEM-XTT5-D", "XTT5-D. Deceased Estate Notings", "DeceasedEstateNotings");
        public static WinFormsField MenuItemXtt5M = new WinFormsField("MENU-ITEM-XTT5-M", "XTT5-M. Holder Memorandum", "HolderMemorandum");
        public static WinFormsField MenuItemXtt5N = new WinFormsField("MENU-ITEM-XTT5-N", "XTT5-N. Free Form Noting", "FreeFormNoting");
        public static WinFormsField MenuItemXtt5P = new WinFormsField("MENU-ITEM-XTT5-P", "XTT5-P. Power of Attorney", "PowerofAttorney");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
