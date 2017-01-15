using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS07801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS07801", "FormName");
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
        public static WinFormsField TakeoverNumber = new WinFormsField("TAKEOVER-NUMBER", "TakeoverNumber");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField SellHin = new WinFormsField("SELL-HIN", "SellHin");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
