using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01004", "FormName");
		//Fields
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField SelGrp = new WinFormsField("SELGRP", "SelGrp");
        public static WinFormsField Selgrp = new WinFormsField("SELGRP", "Selgrp");
        public static WinFormsField Selreg = new WinFormsField("SELREG", "Selreg");
        public static WinFormsField reg = new WinFormsField("REG", "reg");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField SummaryDetailInd = new WinFormsField("SUMMARY-DETAIL-IND", "SummaryDetailInd");
        public static WinFormsField DispUnitBalanceInd = new WinFormsField("DISP-UNIT-BALANCE-IND", "DispUnitBalanceInd");
        public static WinFormsField ContributionTypeInd = new WinFormsField("CONTRIBUTION-TYPE-IND", "ContributionTypeInd");
        public static WinFormsField DispSharePriceInd = new WinFormsField("DISP-SHARE-PRICE-IND", "DispSharePriceInd");
        public static WinFormsField ContractedSvgsInd = new WinFormsField("CONTRACTED-SVGS-IND", "ContractedSvgsInd");
        public static WinFormsField DispShareCostInd = new WinFormsField("DISP-SHARE-COST-IND", "DispShareCostInd");
        public static WinFormsField SvgsContribDiffInd = new WinFormsField("SVGS-CONTRIB-DIFF-IND", "SvgsContribDiffInd");
        public static WinFormsField DispUnitsAllocInd = new WinFormsField("DISP-UNITS-ALLOC-IND", "DispUnitsAllocInd");
        public static WinFormsField DispResidualsInd = new WinFormsField("DISP-RESIDUALS-IND", "DispResidualsInd");
        public static WinFormsField Ers01004RecContribDetsInd = new WinFormsField("ERS01004-REC-CONTRIB-DETS-IND", "Ers01004RecContribDetsInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
