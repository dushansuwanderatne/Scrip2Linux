using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01030", "FormName");
		//Fields
        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField NzlRemitterName = new WinFormsField("NZL-REMITTER-NAME", "NzlRemitterName");
        public static WinFormsField NzlBank = new WinFormsField("NZL-BANK", "NzlBank");
        public static WinFormsField NzlBranch = new WinFormsField("NZL-BRANCH", "NzlBranch");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField NzlAccount = new WinFormsField("NZL-ACCOUNT", "NzlAccount");
        public static WinFormsField NzlSuffix = new WinFormsField("NZL-SUFFIX", "NzlSuffix");
        public static WinFormsField CemtexUserNum = new WinFormsField("CEMTEX-USER-NUM", "CemtexUserNum");
        public static WinFormsField NzlPayDesc = new WinFormsField("NZL-PAY-DESC", "NzlPayDesc");
        public static WinFormsField OverrideTranType = new WinFormsField("OVERRIDE-TRAN-TYPE", "OverrideTranType");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField TraceBsb1to3 = new WinFormsField("TRACE-BSB-1TO3", "TraceBsb1to3");
        public static WinFormsField TraceBsb5to7 = new WinFormsField("TRACE-BSB-5TO7", "TraceBsb5to7");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField LodgementSuffix = new WinFormsField("LODGEMENT-SUFFIX", "LodgementSuffix");
        public static WinFormsField AusDirectCredtEft1 = new WinFormsField("AUS-DIRECT-CREDT-EFT1", "AusDirectCredtEft1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField AddKey = new WinFormsField("ADD-KEY", "AddKey");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField AusDirectCredtEft2 = new WinFormsField("AUS-DIRECT-CREDT-EFT2", "AusDirectCredtEft2");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
