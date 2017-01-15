using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03401", "FormName");
		//Fields


        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField BulkPayHolder = new WinFormsField("BULK-PAY-HOLDER", "BulkPayHolder");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField BulkPayType = new WinFormsField("BULK-PAY-TYPE", "BulkPayType");
        public static WinFormsField ListRequired = new WinFormsField("LIST-REQUIRED", "ListRequired");
        public static WinFormsField PayInstrFromChess = new WinFormsField("PAY-INSTR-FROM-CHESS", "PayInstrFromChess");
        public static WinFormsField ConvertCurrency = new WinFormsField("CONVERT-CURRENCY", "ConvertCurrency");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField PaidCurrencyDesc = new WinFormsField("PAID-CURRENCY-DESC", "PaidCurrencyDesc");
        public static WinFormsField BankDetKnownInd = new WinFormsField("BANK-DET-KNOWN-IND", "BankDetKnownInd");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField CemtexUserNum = new WinFormsField("CEMTEX-USER-NUM", "CemtexUserNum");
        public static WinFormsField OverrideTranType = new WinFormsField("OVERRIDE-TRAN-TYPE", "OverrideTranType");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField TraceBsb1to3 = new WinFormsField("TRACE-BSB-1TO3", "TraceBsb1to3");
        public static WinFormsField TraceBsb5to7 = new WinFormsField("TRACE-BSB-5TO7", "TraceBsb5to7");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField LodgementSuffix = new WinFormsField("LODGEMENT-SUFFIX", "LodgementSuffix");
        public static WinFormsField AusDirectCredtEft1 = new WinFormsField("AUS-DIRECT-CREDT-EFT1", "AusDirectCredtEft1");
        public static WinFormsField AusDirectCredtEft2 = new WinFormsField("AUS-DIRECT-CREDT-EFT2", "AusDirectCredtEft2");
        public static WinFormsField PseudoCode = new WinFormsField("PSEUDO-CODE", "PseudoCode");
        public static WinFormsField WriteTOFloppy = new WinFormsField("WRITE-TO-FLOPPY", "WriteTOFloppy");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField AddKey = new WinFormsField("ADD-KEY", "AddKey");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
