using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR00100", "FormName");
		//Fields


        public static WinFormsField MenuItemEN = new WinFormsField("MENU-ITEM-EN", "EN.  Enquiry System", "EnquirySystem");
        public static WinFormsField MenuItemAP = new WinFormsField("MENU-ITEM-AP", "AP.  Approved Processing", "ApprovedProcessing");
        public static WinFormsField MenuItemHF = new WinFormsField("MENU-ITEM-HF", "HF.  Host Functions", "HostFunctions");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP.  Tolerance Processing", "ToleranceProcessing");
        public static WinFormsField MenuItemRS = new WinFormsField("MENU-ITEM-RS", "RS.  Reporting System", "ReportingSystem");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit From System", "ExitFromSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
