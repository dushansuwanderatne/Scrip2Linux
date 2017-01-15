using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10017

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10017", "FormName");
		//Fields


        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H.  Holding balance (Brief)", "Holdingbalance(Brief)");
        public static WinFormsField MenuItemB = new WinFormsField("MENU-ITEM-B", "B.  Balance on Class/Register", "BalanceonClass/Register");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C.  Certificate Balance", "CertificateBalance");
        public static WinFormsField MenuItemF = new WinFormsField("MENU-ITEM-F", "F.  Full Register List", "FullRegisterList");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T.  Transaction List", "TransactionList");
        public static WinFormsField MenuItemM = new WinFormsField("MENU-ITEM-M", "M.  Movements showing Opening/Closing Balance", "MovementsshowingOpening/ClosingBalance");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField RegEsdPrint = new WinFormsField("REG-ESD-PRINT", "RegEsdPrint");
        public static WinFormsField TradeIDPrint = new WinFormsField("TRADE-ID-PRINT", "TradeIDPrint");
        public static WinFormsField NilCertsTOPrint = new WinFormsField("NIL-CERTS-TO-PRINT", "NilCertsTOPrint");
        public static WinFormsField SeparateClassPrint = new WinFormsField("SEPARATE-CLASS-PRINT", "SeparateClassPrint");
        public static WinFormsField PrintChessHis = new WinFormsField("PRINT-CHESS-HIS", "PrintChessHis");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
