using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTSA

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTSA", "FormName");
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
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField SellSbn = new WinFormsField("SELL-SBN", "SellSbn");
        public static WinFormsField SellSearchName = new WinFormsField("SELL-SEARCH-NAME", "SellSearchName");
        public static WinFormsField CheckNumberX = new WinFormsField("CHECK-NUMBER-X", "CheckNumberX");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellerBirthDate = new WinFormsField("SELLER-BIRTH-DATE", "SellerBirthDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
