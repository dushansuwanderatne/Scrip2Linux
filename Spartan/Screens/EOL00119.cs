using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00119

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00119", "FormName");
		//Fields
        public static WinFormsField MenuItemEsfrl = new WinFormsField("MENU-ITEM-ESFRL", "ESFRL. Forfeiture for Leavers", "ForfeitureforLeavers");
        public static WinFormsField MenuItemEsfre = new WinFormsField("MENU-ITEM-ESFRE", "ESFRE. Employee Requested Forfeiture", "EmployeeRequestedForfeiture");
        public static WinFormsField MenuItemEsfrc = new WinFormsField("MENU-ITEM-ESFRC", "ESFRC. Company Requested Forfeiture", "CompanyRequestedForfeiture");
        public static WinFormsField MenuItemEsfrt = new WinFormsField("MENU-ITEM-ESFRT", "ESFRT. Performance Test Failure Forfeiture", "PerformanceTestFailureForfeiture");
        public static WinFormsField MenuItemEsrvf = new WinFormsField("MENU-ITEM-ESRVF", "ESRVF. Forfeiture Reversal", "ForfeitureReversal");
        public static WinFormsField MenuItemEstoc = new WinFormsField("MENU-ITEM-ESTOC", "ESTOC. Termination of Contract", "TerminationofContract");
        public static WinFormsField MenuItemEsrvq = new WinFormsField("MENU-ITEM-ESRVQ", "ESRVQ. Termination of Contract Reversal", "TerminationofContractReversal");
        public static WinFormsField MenuItemEslva = new WinFormsField("MENU-ITEM-ESLVA", "ESLVA. Leaver Processing", "LeaverProcessing");
        public static WinFormsField MenuItemEslra = new WinFormsField("MENU-ITEM-ESLRA", "ESLRA. Leaver Processing Reversal", "LeaverProcessingReversal");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
