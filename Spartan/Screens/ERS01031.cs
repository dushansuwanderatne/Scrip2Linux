using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01031

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01031", "FormName");
		//Fields
        public static WinFormsField ClntCode = new WinFormsField("CLNT-CODE", "ClntCode");
        public static WinFormsField CoyCode = new WinFormsField("COY-CODE", "CoyCode");
        public static WinFormsField ClsCode = new WinFormsField("CLS-CODE", "ClsCode");
        public static WinFormsField ClsGrp = new WinFormsField("CLS-GRP", "ClsGrp");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField SelCls = new WinFormsField("SELCLS", "SelCls");
        public static WinFormsField SelGrp = new WinFormsField("SELGRP", "SelGrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField SelectedPlanType = new WinFormsField("SELECTED-PLAN-TYPE", "SelectedPlanType");
        public static WinFormsField SelectedTaxType = new WinFormsField("SELECTED-TAX-TYPE", "SelectedTaxType");
        public static WinFormsField SelectedNorType = new WinFormsField("SELECTED-NOR-TYPE", "SelectedNorType");
        public static WinFormsField AwardFrom = new WinFormsField("AWARD-FROM", "AwardFrom");
        public static WinFormsField AwardTO = new WinFormsField("AWARD-TO", "AwardTO");
        public static WinFormsField HldgEndFrom = new WinFormsField("HLDG-END-FROM", "HldgEndFrom");
        public static WinFormsField HldgEndTO = new WinFormsField("HLDG-END-TO", "HldgEndTO");
        public static WinFormsField TaxEndFrom = new WinFormsField("TAX-END-FROM", "TaxEndFrom");
        public static WinFormsField TaxEndTO = new WinFormsField("TAX-END-TO", "TaxEndTO");
        public static WinFormsField ForfEndFrom = new WinFormsField("FORF-END-FROM", "ForfEndFrom");
        public static WinFormsField ForfEndTO = new WinFormsField("FORF-END-TO", "ForfEndTO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
