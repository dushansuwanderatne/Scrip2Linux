using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SWFT0200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SWFT0200", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AccountNum1 = new WinFormsField("ACCOUNT-NUM-1", "AccountNum1");
        public static WinFormsField AccountNum2 = new WinFormsField("ACCOUNT-NUM-2", "AccountNum2");
        public static WinFormsField PercIncome1 = new WinFormsField("PERC-INCOME-1", "PercIncome1");
        public static WinFormsField PercIncome2 = new WinFormsField("PERC-INCOME-2", "PercIncome2");
        public static WinFormsField PercInt1 = new WinFormsField("PERC-INT-1", "PercInt1");
        public static WinFormsField PercInt2 = new WinFormsField("PERC-INT-2", "PercInt2");
        public static WinFormsField PercTaxFree1 = new WinFormsField("PERC-TAX-FREE-1", "PercTaxFree1");
        public static WinFormsField PercTaxFree2 = new WinFormsField("PERC-TAX-FREE-2", "PercTaxFree2");
        public static WinFormsField PercTaxDef1 = new WinFormsField("PERC-TAX-DEF-1", "PercTaxDef1");
        public static WinFormsField PercTaxDef2 = new WinFormsField("PERC-TAX-DEF-2", "PercTaxDef2");
        public static WinFormsField NotSeq = new WinFormsField("NOT-SEQ", "NotSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
