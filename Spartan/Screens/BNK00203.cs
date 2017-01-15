using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNK00203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNK00203", "FormName");
		//Fields


        public static WinFormsField PrintBatchID = new WinFormsField("PRINT-BATCH-ID", "PrintBatchID");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField NbrPayments = new WinFormsField("NBR-PAYMENTS", "NbrPayments");
        public static WinFormsField StartChequeNumber = new WinFormsField("START-CHEQUE-NUMBER", "StartChequeNumber");
        public static WinFormsField LastChequeNumber = new WinFormsField("LAST-CHEQUE-NUMBER", "LastChequeNumber");
        public static WinFormsField StatusShortDesc = new WinFormsField("STATUS-SHORT-DESC", "StatusShortDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField PrintingBYFlg = new WinFormsField("PRINTING-BY-FLG", "PrintingBYFlg");
        public static WinFormsField ConfirmAction = new WinFormsField("CONFIRM-ACTION", "ConfirmAction");
        public static WinFormsField BatchTypeDesc = new WinFormsField("BATCH-TYPE-DESC", "BatchTypeDesc");
        public static WinFormsField BatchUrgentDesc = new WinFormsField("BATCH-URGENT-DESC", "BatchUrgentDesc");
        public static WinFormsField ChqRejectedInd = new WinFormsField("CHQ-REJECTED-IND", "ChqRejectedInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}