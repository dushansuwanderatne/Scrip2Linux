using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03301", "FormName");
		//Fields


        public static WinFormsField IndexNumber = new WinFormsField("INDEX-NUMBER", "IndexNumber");
        public static WinFormsField CompTypeCode = new WinFormsField("COMP-TYPE-CODE", "CompTypeCode");
        public static WinFormsField CompTypeShortDesc = new WinFormsField("COMP-TYPE-SHORT-DESC", "CompTypeShortDesc");
        public static WinFormsField CompCatCode = new WinFormsField("COMP-CAT-CODE", "CompCatCode");
        public static WinFormsField CompCatShortDesc = new WinFormsField("COMP-CAT-SHORT-DESC", "CompCatShortDesc");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField AddText = new WinFormsField("ADD-TEXT", "AddText");
        public static WinFormsField AddDesc = new WinFormsField("ADD-DESC", "AddDesc");
        public static WinFormsField NextText = new WinFormsField("NEXT-TEXT", "NextText");
        public static WinFormsField NextDesc = new WinFormsField("NEXT-DESC", "NextDesc");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField EoiTaxApplyInd = new WinFormsField("EOI-TAX-APPLY-IND", "EoiTaxApplyInd");
        public static WinFormsField FundPaymentInd = new WinFormsField("FUND-PAYMENT-IND", "FundPaymentInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
