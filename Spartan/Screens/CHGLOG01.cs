using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHGLOG01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHGLOG01", "FormName");
		//Fields


        public static WinFormsField ChglogKey0 = new WinFormsField("CHGLOG-KEY0", "ChglogKey0");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField CompanyUfdsel = new WinFormsField("COMPANY-UFDSEL", "CompanyUfdsel");
        public static WinFormsField PrintLines = new WinFormsField("PRINT-LINES", "PrintLines");
        public static WinFormsField ProgramName = new WinFormsField("PROGRAM-NAME", "ProgramName");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField InputXtractInd = new WinFormsField("INPUT-XTRACT-IND", "InputXtractInd");
        public static WinFormsField Holders = new WinFormsField("HOLDERS", "Holders");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField BJDate = new WinFormsField("BJ-DATE", "BJDate");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField TotalReinvestors = new WinFormsField("TOTAL-REINVESTORS", "TotalReinvestors");
        public static WinFormsField TotalSources = new WinFormsField("TOTAL-SOURCES", "TotalSources");
        public static WinFormsField TotalMultCurrencies = new WinFormsField("TOTAL-MULT-CURRENCIES", "TotalMultCurrencies");
        public static WinFormsField TotalPayments = new WinFormsField("TOTAL-PAYMENTS", "TotalPayments");
        public static WinFormsField ProgramDesc = new WinFormsField("PROGRAM-DESC", "ProgramDesc");
        public static WinFormsField FormsPages = new WinFormsField("FORMS-PAGES", "FormsPages");
        public static WinFormsField OlsTrans = new WinFormsField("OLS-TRANS", "OlsTrans");
        public static WinFormsField BatTrans = new WinFormsField("BAT-TRANS", "BatTrans");
        public static WinFormsField TfnTrans = new WinFormsField("TFN-TRANS", "TfnTrans");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
