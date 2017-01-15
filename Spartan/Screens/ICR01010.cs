using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR01010", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField ClsGrpCode = new WinFormsField("CLS-GRP-CODE", "ClsGrpCode");
        public static WinFormsField ClsGrpDesc = new WinFormsField("CLS-GRP-DESC", "ClsGrpDesc");
        public static WinFormsField MenuItemIcr = new WinFormsField("MENU-ITEM-ICR", "ICR.  Issued Capital Recon Summary", "IssuedCapitalReconSummary");
        public static WinFormsField MenuItemCur = new WinFormsField("MENU-ITEM-CUR", "CUR.  CUM Reconciliation Summary", "CUMReconciliationSummary");
        public static WinFormsField MenuItemAic = new WinFormsField("MENU-ITEM-AIC", "AIC.  Approved Issued Capital Enquiry", "ApprovedIssuedCapitalEnquiry");
        public static WinFormsField MenuItemAT = new WinFormsField("MENU-ITEM-AT", "AT.   ASX Tolerance Enquiry", "ASXToleranceEnquiry");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.   SCRIP Tolerance Enquiry", "SCRIPToleranceEnquiry");
        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT.   CUM Tolerance Enquiry", "CUMToleranceEnquiry");
        public static WinFormsField MenuItemGC = new WinFormsField("MENU-ITEM-GC", "GC.   Grouped Classes", "GroupedClasses");
        public static WinFormsField MenuSelection = new WinFormsField("MENU-SELECTION", "MenuSelection");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
