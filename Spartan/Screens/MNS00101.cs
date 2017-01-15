using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    class MNS00101
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("MNS00101", "FormName");
        //Menu Fields
        public static WinFormsField EnquirySystem = new WinFormsField("MENU-ITEM-EN", "EN.  Enquiry System", "EnquirySystem");
        public static WinFormsField OnlineDataEntrySystem = new WinFormsField("MENU-ITEM-OL", "OL.  Online Data Entry System", "OnlineDataEntrySystem");
        public static WinFormsField HousekeepingSystem = new WinFormsField("MENU-ITEM-HK", "HK.  Housekeeping System", "HousekeepingSystem");
        public static WinFormsField ReportingSystem = new WinFormsField("MENU-ITEM-RS", "RS.  Reporting System", "ReportingSystem");
        public static WinFormsField HostFunctions = new WinFormsField("MENU-ITEM-HF", "HF.  Host Functions", "HostFunctions");
        public static WinFormsField OnlineProxySystem = new WinFormsField("MENU-ITEM-PX", "PX.  Online Proxy System", "OnlineProxySystem");
        public static WinFormsField SystemParameterSetups = new WinFormsField("MENU-ITEM-SS", "SS.  System Parameter Setups", "SystemParameterSetups");
        public static WinFormsField SpecialProcessing = new WinFormsField("MENU-ITEM-SP", "SP.  Special Processing", "SpecialProcessing");
        public static WinFormsField PublicEnquiry = new WinFormsField("MENU-ITEM-PE", "PE.  Public Enquiry", "PublicEnquiry");
        public static WinFormsField TradingSystem = new WinFormsField("MENU-ITEM-TS", "TS.  Trading System", "TradingSystem");
        public static WinFormsField FileProcessing = new WinFormsField("MENU-ITEM-FP", "FP.  File Processing", "FileProcessing");
        public static WinFormsField BulkProcessing = new WinFormsField("MENU-ITEM-BP", "BP.  Bulk Processing", "BulkProcessing");
        public static WinFormsField EmployeeSchemeProcessing = new WinFormsField("MENU-ITEM-EP", "EP.  Employee Scheme Processing", "EmployeeSchemeProcessing");
        public static WinFormsField SelectCompany = new WinFormsField("MENU-ITEM-SC", "SC.  Select Company", "SelectCompany");
        public static WinFormsField ExitfromSystem = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from System", "ExitfromSystem");
        public static WinFormsField SelectServiceLevel = new WinFormsField("MENU-ITEM-SL", "SL.  Select Service Level", "SelectServiceLevel");
        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "", "ServiceProvider");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "", "ServiceCode");

        //Sys Info Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "SystemInfoFree6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "SystemInfoFree4");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "SystemInfoFree7");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "SystemInfoFree3");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "SystemInfoFree5");

        //Alpha Numeric Fields
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");

        [Then(@"I should be on the SCRIP System Menu screen")]
        public static void IShouldBeOnTheSCRIPSystemMenuScreen()
        {
            try { FormName.ValidateFormName(); }
            catch (Exception ex) 
            { 
                Spartan.Core.TestDriver.CatchNTrash(ex);  
            }
        }

    }
}
