using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05030", "FormName");
		//Fields


        public static WinFormsField MenuItemApps = new WinFormsField("MENU-ITEM-APPS", "APPS.", "");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField MenuItemCalc = new WinFormsField("MENU-ITEM-CALC", "CALC.", "");
        public static WinFormsField MenuItemAllt = new WinFormsField("MENU-ITEM-ALLT", "ALLT.", "");
        public static WinFormsField MenuItemBuld = new WinFormsField("MENU-ITEM-BULD", "BULD.", "");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField AppsPhaseStatus = new WinFormsField("APPS-PHASE-STATUS", "AppsPhaseStatus");
        public static WinFormsField CalcPhaseStatus = new WinFormsField("CALC-PHASE-STATUS", "CalcPhaseStatus");
        public static WinFormsField PlanPhaseStatus = new WinFormsField("PLAN-PHASE-STATUS", "PlanPhaseStatus");
        public static WinFormsField BuldPhaseStatus = new WinFormsField("BULD-PHASE-STATUS", "BuldPhaseStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
