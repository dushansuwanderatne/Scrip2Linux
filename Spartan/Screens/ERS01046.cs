using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01046

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01046", "FormName");
		//Fields
        public static WinFormsField ClsCode = new WinFormsField("CLS-CODE", "ClsCode");
        public static WinFormsField ClsGrp = new WinFormsField("CLS-GRP", "ClsGrp");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField SelCls = new WinFormsField("SELCLS", "SelCls");
        public static WinFormsField SelGrp = new WinFormsField("SELGRP", "SelGrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField RunDateRangeInd = new WinFormsField("RUN-DATE-RANGE-IND", "RunDateRangeInd");
        public static WinFormsField RunRangeFrom = new WinFormsField("RUN-RANGE-FROM", "RunRangeFrom");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField TranDateFrom = new WinFormsField("TRAN-DATE-FROM", "TranDateFrom");
        public static WinFormsField TranDateTO = new WinFormsField("TRAN-DATE-TO", "TranDateTO");
        public static WinFormsField SummaryDetailInd = new WinFormsField("SUMMARY-DETAIL-IND", "SummaryDetailInd");
        public static WinFormsField ExerciseStatusInd = new WinFormsField("EXERCISE-STATUS-IND", "ExerciseStatusInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
