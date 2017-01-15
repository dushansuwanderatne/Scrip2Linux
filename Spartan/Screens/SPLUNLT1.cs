using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLUNLT1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLUNLT1", "FormName");
		//Fields


        public static WinFormsField MenuItemDpu = new WinFormsField("MENU-ITEM-DPU", "DPU.  Day Price Enquiry Update", "DayPriceEnquiryUpdate");
        public static WinFormsField MenuItemApp = new WinFormsField("MENU-ITEM-APP", "APP.  Trust Applications", "TrustApplications");
        public static WinFormsField MenuItemRed = new WinFormsField("MENU-ITEM-RED", "RED. Trust Redemptions", "TrustRedemptions");
        public static WinFormsField MenuItemArv = new WinFormsField("MENU-ITEM-ARV", "ARV.  Applications Reversal", "ApplicationsReversal");
        public static WinFormsField MenuItemRrv = new WinFormsField("MENU-ITEM-RRV", "RRV.  Redemption Reversal", "RedemptionReversal");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit From System", "ExitFromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
