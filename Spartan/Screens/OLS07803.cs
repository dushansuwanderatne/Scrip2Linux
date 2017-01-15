using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS07803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS07803", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyClassDesc = new WinFormsField("BUY-CLASS-DESC", "BuyClassDesc");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyRegDesc = new WinFormsField("BUY-REG-DESC", "BuyRegDesc");
        public static WinFormsField TakeoverNumber = new WinFormsField("TAKEOVER-NUMBER", "TakeoverNumber");
        public static WinFormsField TakeoverDesc = new WinFormsField("TAKEOVER-DESC", "TakeoverDesc");
        public static WinFormsField BuyCertID = new WinFormsField("BUY-CERT-ID", "BuyCertID");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField BuyHnaLine = new WinFormsField("BUY-HNA-LINE", "BuyHnaLine");
        public static WinFormsField BuyDate = new WinFormsField("BUY-DATE", "BuyDate");
        public static WinFormsField BuyReference = new WinFormsField("BUY-REFERENCE", "BuyReference");
        public static WinFormsField BuyWarning = new WinFormsField("BUY-WARNING", "BuyWarning");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
