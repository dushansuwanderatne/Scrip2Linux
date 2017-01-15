using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField RvsalRunNumber = new WinFormsField("RVSAL-RUN-NUMBER", "RvsalRunNumber");
        public static WinFormsField RvsalTransNumber = new WinFormsField("RVSAL-TRANS-NUMBER", "RvsalTransNumber");
        public static WinFormsField RvsalTranTypeDesc = new WinFormsField("RVSAL-TRAN-TYPE-DESC", "RvsalTranTypeDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyClassDesc = new WinFormsField("BUY-CLASS-DESC", "BuyClassDesc");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellRegDesc = new WinFormsField("SELL-REG-DESC", "SellRegDesc");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyRegDesc = new WinFormsField("BUY-REG-DESC", "BuyRegDesc");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField BuyCertID = new WinFormsField("BUY-CERT-ID", "BuyCertID");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField SellCenter = new WinFormsField("SELL-CENTER", "SellCenter");
        public static WinFormsField SellGrade = new WinFormsField("SELL-GRADE", "SellGrade");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
