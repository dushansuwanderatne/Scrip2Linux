using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MNS001XX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MNS001XX", "FormName");
		//Fields


        public static WinFormsField MenuItemEN = new WinFormsField("MENU-ITEM-EN", "EN. Enquiry System", "EnquirySystem");
        public static WinFormsField MenuItemPP = new WinFormsField("MENU-ITEM-PP", "PP. Payment Parameter System", "PaymentParameterSystem");
        public static WinFormsField MenuItemOL = new WinFormsField("MENU-ITEM-OL", "OL. Online Data Entry System", "OnlineDataEntrySystem");
        public static WinFormsField MenuItemPX = new WinFormsField("MENU-ITEM-PX", "PX. Proxy System", "ProxySystem");
        public static WinFormsField MenuItemRS = new WinFormsField("MENU-ITEM-RS", "RS. Reporting System", "ReportingSystem");
        public static WinFormsField MenuItemHK = new WinFormsField("MENU-ITEM-HK", "HK. Housekeeping System", "HousekeepingSystem");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM-PR", "PR. Print Reports/Certificates", "PrintReports/Certificates");
        public static WinFormsField MenuItemCF = new WinFormsField("MENU-ITEM-CF", "CF. Control Files (TEMPORARY)", "ControlFiles(TEMPORARY)");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit from System", "ExitfromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
