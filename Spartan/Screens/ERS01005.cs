using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01005", "FormName");
		//Fields
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField SelCls = new WinFormsField("SELCLS", "SelCls");
        public static WinFormsField Ers01005Selgrp = new WinFormsField("ERS01005-SELGRP", "Ers01005Selgrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField RunORDateRange = new WinFormsField("RUN-OR-DATE-RANGE", "RunORDateRange");
        public static WinFormsField RunRangeFrom = new WinFormsField("RUN-RANGE-FROM", "RunRangeFrom");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField LapseDate = new WinFormsField("LAPSE-DATE", "LapseDate");
        public static WinFormsField TotalsOnly = new WinFormsField("TOTALS-ONLY", "TotalsOnly");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
