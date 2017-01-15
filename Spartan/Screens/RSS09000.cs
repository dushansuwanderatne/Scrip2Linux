using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS09000
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS09000", "FormName");
        //Fields
        public static WinFormsField MenuItemBT = new WinFormsField("MENU-ITEM-BT", "BT.  Broker Trading Analysis", "BrokerTradingAnalysis");
        public static WinFormsField MenuItemBA = new WinFormsField("MENU-ITEM-BA", "BA.  Broker Application Report", "BrokerApplicationReport");
        public static WinFormsField MenuItemBS = new WinFormsField("MENU-ITEM-BS", "BS.  Broker State Report", "BrokerStateReport");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField Preload = new WinFormsField("PRELOAD", "Preload");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
