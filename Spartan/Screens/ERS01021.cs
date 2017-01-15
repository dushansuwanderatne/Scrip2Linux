using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01021", "FormName");
		//Fields
        public static WinFormsField SELCLS = new WinFormsField("SELCLS", "selcls");
        public static WinFormsField CLASS = new WinFormsField("CLASS", "class");
        public static WinFormsField Selgrp = new WinFormsField("SELGRP", "Selgrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField StatementRunFrom = new WinFormsField("STATEMENT-RUN-FROM", "StatementRunFrom");
        public static WinFormsField BFBalanceInd = new WinFormsField("BF-BALANCE-IND", "BFBalanceInd");
        public static WinFormsField StatementDisplayInd = new WinFormsField("STATEMENT-DISPLAY-IND", "StatementDisplayInd");
        public static WinFormsField Ers01021PymtTranInd = new WinFormsField("ERS01021-PYMT-TRAN-IND", "Ers01021PymtTranInd");
        public static WinFormsField MarketValuePrice = new WinFormsField("MARKET-VALUE-PRICE", "MarketValuePrice");
        public static WinFormsField MarketValueDate = new WinFormsField("MARKET-VALUE-DATE", "MarketValueDate");
        public static WinFormsField ForeignExchangeRate = new WinFormsField("FOREIGN-EXCHANGE-RATE", "ForeignExchangeRate");
        public static WinFormsField StmtDsplayDateFrom = new WinFormsField("STMT-DSPLAY-DATE-FROM", "StmtDsplayDateFrom");
        public static WinFormsField StmtDsplayDateTO = new WinFormsField("STMT-DSPLAY-DATE-TO", "StmtDsplayDateTO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
