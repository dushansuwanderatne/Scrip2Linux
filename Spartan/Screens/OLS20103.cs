using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS20103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS20103", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HnaLine1 = new WinFormsField("HNA-LINE-1", "HnaLine1");
        public static WinFormsField HnaLine2 = new WinFormsField("HNA-LINE-2", "HnaLine2");
        public static WinFormsField HolderPI = new WinFormsField("HOLDER-PI", "HolderPI");
        public static WinFormsField ReplaceCntC = new WinFormsField("REPLACE-CNT-C", "ReplaceCntC");
        public static WinFormsField ReplaceAmtC = new WinFormsField("REPLACE-AMT-C", "ReplaceAmtC");
        public static WinFormsField ReplaceCntD = new WinFormsField("REPLACE-CNT-D", "ReplaceCntD");
        public static WinFormsField ReplaceAmtD = new WinFormsField("REPLACE-AMT-D", "ReplaceAmtD");
        public static WinFormsField ReplaceCntE = new WinFormsField("REPLACE-CNT-E", "ReplaceCntE");
        public static WinFormsField ReplaceAmtE = new WinFormsField("REPLACE-AMT-E", "ReplaceAmtE");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReplaceAmtTot = new WinFormsField("REPLACE-AMT-TOT", "ReplaceAmtTot");
        public static WinFormsField ReplaceCntM = new WinFormsField("REPLACE-CNT-M", "ReplaceCntM");
        public static WinFormsField ReplaceAmtM = new WinFormsField("REPLACE-AMT-M", "ReplaceAmtM");
        public static WinFormsField MoneyFinderName = new WinFormsField("MONEY-FINDER-NAME", "MoneyFinderName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
