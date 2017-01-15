using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL00100", "FormName");
		//Fields


        public static WinFormsField MenuItemOL = new WinFormsField("MENU-ITEM-OL", "OL. Online/Enquiry System", "Online/EnquirySystem");
        public static WinFormsField MenuItemRS = new WinFormsField("MENU-ITEM-RS", "RS. Reporting System", "ReportingSystem");
        public static WinFormsField MenuItemHK = new WinFormsField("MENU-ITEM-HK", "HK. Housekeeping System", "HousekeepingSystem");
        public static WinFormsField MenuItemHF = new WinFormsField("MENU-ITEM-HF", "HF. Host Functions", "HostFunctions");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC.  Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from System", "ExitfromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
