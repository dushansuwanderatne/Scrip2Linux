using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP01501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP01501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField HolderAddress1 = new WinFormsField("HOLDER-ADDRESS-1", "HolderAddress1");
        public static WinFormsField HolderAddress2 = new WinFormsField("HOLDER-ADDRESS-2", "HolderAddress2");
        public static WinFormsField AppRefNbr = new WinFormsField("APP-REF-NBR", "AppRefNbr");
        public static WinFormsField AppDate = new WinFormsField("APP-DATE", "AppDate");
        public static WinFormsField AbtFlag = new WinFormsField("ABT-FLAG", "AbtFlag");
        public static WinFormsField CashBalance = new WinFormsField("CASH-BALANCE", "CashBalance");
        public static WinFormsField CashYear = new WinFormsField("CASH-YEAR", "CashYear");
        public static WinFormsField TermRefNbr = new WinFormsField("TERM-REF-NBR", "TermRefNbr");
        public static WinFormsField TermDate = new WinFormsField("TERM-DATE", "TermDate");
        public static WinFormsField CashAmt = new WinFormsField("CASH-AMT", "CashAmt");
        public static WinFormsField CashDep = new WinFormsField("CASH-DEP", "CashDep");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}