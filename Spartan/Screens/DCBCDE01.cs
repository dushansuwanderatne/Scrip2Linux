using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCBCDE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCBCDE01", "FormName");
		//Fields


        public static WinFormsField DcbcdeKey0 = new WinFormsField("DCBCDE-KEY0", "DcbcdeKey0");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField BulkPayHolder = new WinFormsField("BULK-PAY-HOLDER", "BulkPayHolder");
        public static WinFormsField BulkPayType = new WinFormsField("BULK-PAY-TYPE", "BulkPayType");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField CemtexUserNum = new WinFormsField("CEMTEX-USER-NUM", "CemtexUserNum");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField OverrideTranType = new WinFormsField("OVERRIDE-TRAN-TYPE", "OverrideTranType");
        public static WinFormsField TraceBsb = new WinFormsField("TRACE-BSB", "TraceBsb");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField LodgementSuffix = new WinFormsField("LODGEMENT-SUFFIX", "LodgementSuffix");
        public static WinFormsField WriteTOFloppy = new WinFormsField("WRITE-TO-FLOPPY", "WriteTOFloppy");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField ListRequired = new WinFormsField("LIST-REQUIRED", "ListRequired");
        public static WinFormsField ConvertCurrency = new WinFormsField("CONVERT-CURRENCY", "ConvertCurrency");
        public static WinFormsField AusDirectCredtEft = new WinFormsField("AUS-DIRECT-CREDT-EFT", "AusDirectCredtEft");
        public static WinFormsField PseudoCode = new WinFormsField("PSEUDO-CODE", "PseudoCode");
        public static WinFormsField PayInstrFromChess = new WinFormsField("PAY-INSTR-FROM-CHESS", "PayInstrFromChess");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField BankDetKnownInd = new WinFormsField("BANK-DET-KNOWN-IND", "BankDetKnownInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
