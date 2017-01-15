using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01043

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01043", "FormName");
		//Fields
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Selgrp = new WinFormsField("SELGRP", "Selgrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField SelCls = new WinFormsField("SELCLS", "SelCls");
        public static WinFormsField StatementType = new WinFormsField("STATEMENT-TYPE", "StatementType");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField StatementRunFrom = new WinFormsField("STATEMENT-RUN-FROM", "StatementRunFrom");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField MarketValuePrice = new WinFormsField("MARKET-VALUE-PRICE", "MarketValuePrice");
        public static WinFormsField MarketValueDate = new WinFormsField("MARKET-VALUE-DATE", "MarketValueDate");
        public static WinFormsField StmtDsplayDateFrom = new WinFormsField("STMT-DSPLAY-DATE-FROM", "StmtDsplayDateFrom");
        public static WinFormsField StmtDsplayDateTO = new WinFormsField("STMT-DSPLAY-DATE-TO", "StmtDsplayDateTO");
        public static WinFormsField NilHoldingsInd = new WinFormsField("NIL-HOLDINGS-IND", "NilHoldingsInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
