using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01013

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01013", "FormName");
		//Fields
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField Selgrp = new WinFormsField("SELGRP", "Selgrp");
        public static WinFormsField AwardDate17 = new WinFormsField("AWARD-DATE-1-7", "AwardDate17");
        public static WinFormsField AwardDate814 = new WinFormsField("AWARD-DATE-8-14", "AwardDate814");
        public static WinFormsField MoneyCertsInd = new WinFormsField("MONEY-CERTS-IND", "MoneyCertsInd");
        public static WinFormsField Exd = new WinFormsField("EXD", "Exd");
        public static WinFormsField MandatoryClass = new WinFormsField("MANDATORY-CLASS", "MandatoryClass");
        public static WinFormsField RegisterExd = new WinFormsField("REGISTER-EXD", "RegisterExd");
        public static WinFormsField MandatoryReg = new WinFormsField("MANDATORY-REG", "MandatoryReg");
        public static WinFormsField UnitBalanceFrom = new WinFormsField("UNIT-BALANCE-FROM", "UnitBalanceFrom");
        public static WinFormsField UnitBalanceTO = new WinFormsField("UNIT-BALANCE-TO", "UnitBalanceTO");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField TransactionType = new WinFormsField("TRANSACTION-TYPE", "TransactionType");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField HolderTotalsOnly = new WinFormsField("HOLDER-TOTALS-ONLY", "HolderTotalsOnly");
        public static WinFormsField ShowAvailability = new WinFormsField("SHOW-AVAILABILITY", "ShowAvailability");
        public static WinFormsField ReportVertically = new WinFormsField("REPORT-VERTICALLY", "ReportVertically");
        public static WinFormsField EliminateGaps = new WinFormsField("ELIMINATE-GAPS", "EliminateGaps");
        public static WinFormsField ReservedUnits = new WinFormsField("RESERVED-UNITS", "ReservedUnits");
        public static WinFormsField IncludeStatus = new WinFormsField("INCLUDE-STATUS", "IncludeStatus");
        public static WinFormsField TaxAssessedInd = new WinFormsField("TAX-ASSESSED-IND", "TaxAssessedInd");
    }
}
