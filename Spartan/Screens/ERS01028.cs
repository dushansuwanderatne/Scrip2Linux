using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01028

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01028", "FormName");
		//Fields
        public static WinFormsField HolderStatus = new WinFormsField("HOLDER-STATUS", "HolderStatus");
        public static WinFormsField DeceasedFlag = new WinFormsField("DECEASED-FLAG", "DeceasedFlag");
        public static WinFormsField ExceptionFlag = new WinFormsField("EXCEPTION-FLAG", "ExceptionFlag");
        public static WinFormsField StopTradeFlag = new WinFormsField("STOP-TRADE-FLAG", "StopTradeFlag");
        public static WinFormsField DivIntentionFlag = new WinFormsField("DIV-INTENTION-FLAG", "DivIntentionFlag");
        public static WinFormsField VariableFlags = new WinFormsField("VARIABLE-FLAGS", "VariableFlags");
        public static WinFormsField VariableField = new WinFormsField("VARIABLE-FIELD", "VariableField");
        public static WinFormsField TfnDescription = new WinFormsField("TFN-DESCRIPTION", "TfnDescription");
        public static WinFormsField Dates = new WinFormsField("DATES", "Dates");
        public static WinFormsField MailUnclaimedDate = new WinFormsField("MAIL-UNCLAIMED-DATE", "MailUnclaimedDate");
        public static WinFormsField HolderONDate = new WinFormsField("HOLDER-ON-DATE", "HolderONDate");
        public static WinFormsField HolderOffDate = new WinFormsField("HOLDER-OFF-DATE", "HolderOffDate");
        public static WinFormsField HolderAddedDate = new WinFormsField("HOLDER-ADDED-DATE", "HolderAddedDate");
        public static WinFormsField PlanDetails = new WinFormsField("PLAN-DETAILS", "PlanDetails");
        public static WinFormsField DrpDetails = new WinFormsField("DRP-DETAILS", "DrpDetails");
        public static WinFormsField DrpPlanDesc = new WinFormsField("DRP-PLAN-DESC", "DrpPlanDesc");
        public static WinFormsField BspDetails = new WinFormsField("BSP-DETAILS", "BspDetails");
        public static WinFormsField BspPlanDesc = new WinFormsField("BSP-PLAN-DESC", "BspPlanDesc");
        public static WinFormsField DirectCredit = new WinFormsField("DIRECT-CREDIT", "DirectCredit");
        public static WinFormsField BankID = new WinFormsField("BANK-ID", "BankID");
        public static WinFormsField BankNamadd = new WinFormsField("BANK-NAMADD", "BankNamadd");
        public static WinFormsField BankAccountNbr = new WinFormsField("BANK-ACCOUNT-NBR", "BankAccountNbr");
        public static WinFormsField BankAccountName = new WinFormsField("BANK-ACCOUNT-NAME", "BankAccountName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
