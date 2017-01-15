using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP01", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField SellBrokerDesc = new WinFormsField("SELL-BROKER-DESC", "SellBrokerDesc");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField MovementReasonDesc = new WinFormsField("MOVEMENT-REASON-DESC", "MovementReasonDesc");
        public static WinFormsField BuyTransDate = new WinFormsField("BUY-TRANS-DATE", "BuyTransDate");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellAddressCh1to30 = new WinFormsField("SELL-ADDRESS-CH1TO30", "SellAddressCh1to30");
        public static WinFormsField SellWarning1to3 = new WinFormsField("SELL-WARNING-1TO3", "SellWarning1to3");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyRegDesc = new WinFormsField("BUY-REG-DESC", "BuyRegDesc");
        public static WinFormsField BuySearchName = new WinFormsField("BUY-SEARCH-NAME", "BuySearchName");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SkipRecs = new WinFormsField("SKIP-RECS", "SkipRecs");
        public static WinFormsField BuyNal1Ch1to30 = new WinFormsField("BUY-NAL-1-CH1TO30", "BuyNal1Ch1to30");
        public static WinFormsField BuyNal4Ch1to30 = new WinFormsField("BUY-NAL-4-CH1TO30", "BuyNal4Ch1to30");
        public static WinFormsField BuyerResidency = new WinFormsField("BUYER-RESIDENCY", "BuyerResidency");
        public static WinFormsField BuyNal2Ch1to30 = new WinFormsField("BUY-NAL-2-CH1TO30", "BuyNal2Ch1to30");
        public static WinFormsField BuyNal5Ch1to30 = new WinFormsField("BUY-NAL-5-CH1TO30", "BuyNal5Ch1to30");
        public static WinFormsField BuyNal3Ch1to30 = new WinFormsField("BUY-NAL-3-CH1TO30", "BuyNal3Ch1to30");
        public static WinFormsField BuyNal6Ch1to30 = new WinFormsField("BUY-NAL-6-CH1TO30", "BuyNal6Ch1to30");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
