using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOLB0103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOLB0103", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDescription = new WinFormsField("TRAN-TYPE-DESCRIPTION", "TranTypeDescription");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField CemtexUserNum = new WinFormsField("CEMTEX-USER-NUM", "CemtexUserNum");
        public static WinFormsField AusOverTranType = new WinFormsField("AUS-OVER-TRAN-TYPE", "AusOverTranType");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField AusTraceBsb1to3 = new WinFormsField("AUS-TRACE-BSB-1TO3", "AusTraceBsb1to3");
        public static WinFormsField AusTraceBsb5to7 = new WinFormsField("AUS-TRACE-BSB-5TO7", "AusTraceBsb5to7");
        public static WinFormsField AusTraceAccount = new WinFormsField("AUS-TRACE-ACCOUNT", "AusTraceAccount");
        public static WinFormsField AusTransRemitName = new WinFormsField("AUS-TRANS-REMIT-NAME", "AusTransRemitName");
        public static WinFormsField AusDirectCredtEft = new WinFormsField("AUS-DIRECT-CREDT-EFT", "AusDirectCredtEft");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
