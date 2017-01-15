using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03320

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03320", "FormName");
		//Fields


        public static WinFormsField CompCatCode = new WinFormsField("COMP-CAT-CODE", "CompCatCode");
        public static WinFormsField CompCatLongDesc = new WinFormsField("COMP-CAT-LONG-DESC", "CompCatLongDesc");
        public static WinFormsField CompTypeCode = new WinFormsField("COMP-TYPE-CODE", "CompTypeCode");
        public static WinFormsField CompTypeLongDesc = new WinFormsField("COMP-TYPE-LONG-DESC", "CompTypeLongDesc");
        public static WinFormsField FundPaymentInd = new WinFormsField("FUND-PAYMENT-IND", "FundPaymentInd");
        public static WinFormsField EoiTaxApplyInd = new WinFormsField("EOI-TAX-APPLY-IND", "EoiTaxApplyInd");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
