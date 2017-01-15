using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14000", "FormName");
		//Fields


        public static WinFormsField MenuItemAri = new WinFormsField("MENU-ITEM-ARI", "ARI.  ATO Reporting Information", "ATOReportingInformation");
        public static WinFormsField MenuItemEss = new WinFormsField("MENU-ITEM-ESS", "ESS.  ESS Supplier Information Setup", "ESSSupplierInformationSetup");
        public static WinFormsField MenuItemGen = new WinFormsField("MENU-ITEM-GEN", "GEN.  Generate AIIR", "GenerateAIIR");
        public static WinFormsField MenuItemSig = new WinFormsField("MENU-ITEM-SIG", "SIG.  Sign Off AIIR", "SignOffAIIR");
        public static WinFormsField MenuItemRep = new WinFormsField("MENU-ITEM-REP", "REP.  Replace AIIR", "ReplaceAIIR");
        public static WinFormsField MenuItemCan = new WinFormsField("MENU-ITEM-CAN", "CAN.  Cancel Replacement AIIR", "CancelReplacementAIIR");
        public static WinFormsField MenuItemCom = new WinFormsField("MENU-ITEM-COM", "COM.  AIIR Compliance Report", "AIIRComplianceReport");
        public static WinFormsField MenuItemQrt = new WinFormsField("MENU-ITEM-QRT", "QRT.  Quarterly ATO Tape", "QuarterlyATOTape");
        public static WinFormsField MenuItemPar = new WinFormsField("MENU-ITEM-PAR", "PAR.  Parent Company Name", "ParentCompanyName");
        public static WinFormsField MenuItemSub = new WinFormsField("MENU-ITEM-SUB", "SUB.  Sub-Company Setup", "Sub-CompanySetup");
        public static WinFormsField MenuItemGcg = new WinFormsField("MENU-ITEM-GCG", "GCG.  Generate CGT", "GenerateCGT");
        public static WinFormsField MenuItemScg = new WinFormsField("MENU-ITEM-SCG", "SCG.  Sign Off CGT", "SignOffCGT");
        public static WinFormsField MenuItemRcg = new WinFormsField("MENU-ITEM-RCG", "RCG.  Replace CGT", "ReplaceCGT");
        public static WinFormsField MenuItemCcg = new WinFormsField("MENU-ITEM-CCG", "CCG.  Cancel Replacement CGT", "CancelReplacementCGT");
        public static WinFormsField MenuItemCgt = new WinFormsField("MENU-ITEM-CGT", "CGT.  CGT Compliance Report", "CGTComplianceReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
