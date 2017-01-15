using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS011CS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS011CS", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ClassParValue = new WinFormsField("CLASS-PAR-VALUE", "ClassParValue");
        public static WinFormsField ClassGroupNumber = new WinFormsField("CLASS-GROUP-NUMBER", "ClassGroupNumber");
        public static WinFormsField ClassTypeFlag = new WinFormsField("CLASS-TYPE-FLAG", "ClassTypeFlag");
        public static WinFormsField ClassMoneyFlag = new WinFormsField("CLASS-MONEY-FLAG", "ClassMoneyFlag");
        public static WinFormsField LoanClass = new WinFormsField("LOAN-CLASS", "LoanClass");
        public static WinFormsField ClassStopTrade = new WinFormsField("CLASS-STOP-TRADE", "ClassStopTrade");
        public static WinFormsField IncludeINSure = new WinFormsField("INCLUDE-IN-SURE", "IncludeINSure");
        public static WinFormsField IntBearing = new WinFormsField("INT-BEARING", "IntBearing");
        public static WinFormsField IntPercentage = new WinFormsField("INT-PERCENTAGE", "IntPercentage");
        public static WinFormsField IntPeriod = new WinFormsField("INT-PERIOD", "IntPeriod");
        public static WinFormsField AsxClassCode = new WinFormsField("ASX-CLASS-CODE", "AsxClassCode");
        public static WinFormsField ClassAuthUnits = new WinFormsField("CLASS-AUTH-UNITS", "ClassAuthUnits");
        public static WinFormsField ClassIssuedUnits = new WinFormsField("CLASS-ISSUED-UNITS", "ClassIssuedUnits");
        public static WinFormsField StartOFRun = new WinFormsField("START-OF-RUN", "StartOFRun");
        public static WinFormsField Current = new WinFormsField("CURRENT", "Current");
        public static WinFormsField Batch = new WinFormsField("BATCH", "Batch");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
