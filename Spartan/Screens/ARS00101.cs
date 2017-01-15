using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ARS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ARS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemRun = new WinFormsField("MENU-ITEM-RUN", "RUN.  Schedule Update Reporting Run", "ScheduleUpdateReportingRun");
        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER.  Extract Reporting ...", "ExtractReporting...");
        public static WinFormsField MenuItemCS = new WinFormsField("MENU-ITEM-CS", "CS.  Company Specific Reporting", "CompanySpecificReporting");
        public static WinFormsField MenuItemFI = new WinFormsField("MENU-ITEM-FI", "FI.  File Integrity Reporting ...", "FileIntegrityReporting...");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Reporting System", "ExitReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
