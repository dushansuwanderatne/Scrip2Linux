using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01041

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01041", "FormName");
		//Fields
        public static WinFormsField ClsCode = new WinFormsField("CLS-CODE", "ClsCode");
        public static WinFormsField SelCls = new WinFormsField("SELCLS", "SelCls");
        public static WinFormsField SelGrp = new WinFormsField("SELGRP", "SelGrp");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField ClsGrp = new WinFormsField("CLS-GRP", "ClsGrp");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
