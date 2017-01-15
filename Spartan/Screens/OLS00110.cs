using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00110", "FormName");
		//Fields


        public static WinFormsField MenuItemCfxup = new WinFormsField("MENU-ITEM-CFXUP", "CFXUP.  CHESS Adjustment Up", "CHESSAdjustmentUp");
        public static WinFormsField MenuItemCfxdn = new WinFormsField("MENU-ITEM-CFXDN", "CFXDN.  CHESS Adjustment Down", "CHESSAdjustmentDown");
        public static WinFormsField MenuItemCfxcx = new WinFormsField("MENU-ITEM-CFXCX", "CFXCX.  Certificated to CHESS adjustment", "CertificatedtoCHESSadjustment");
        public static WinFormsField MenuItemCfxxc = new WinFormsField("MENU-ITEM-CFXXC", "CFXXC.  CHESS to certificated adjustment", "CHESStocertificatedadjustment");
        public static WinFormsField MenuItemCfxuu = new WinFormsField("MENU-ITEM-CFXUU", "CFXUU.  CHESS to Issuer spons adjustment (& vice versa)", "CHESStoIssuersponsadjustment(&viceversa)");
        public static WinFormsField MenuItemRtkor = new WinFormsField("MENU-ITEM-RTKOR", "RTKOR.  Takeover Removals Pending", "TakeoverRemovalsPending");
        public static WinFormsField MenuItemTkreg = new WinFormsField("MENU-ITEM-TKREG", "TKREG.  Offeror Registration Details", "OfferorRegistrationDetails");
        public static WinFormsField MenuItemRtkrq = new WinFormsField("MENU-ITEM-RTKRQ", "RTKRQ. Offeror TKO Acceptance Request", "OfferorTKOAcceptanceRequest");
        public static WinFormsField MenuItemTkcvc = new WinFormsField("MENU-ITEM-TKCVC", "TKCVC.  Chess to Certificated conversion", "ChesstoCertificatedconversion");
        public static WinFormsField MenuItemRtkrm = new WinFormsField("MENU-ITEM-RTKRM", "RTKRM. Registry TKO removals", "RegistryTKOremovals");
        public static WinFormsField MenuItemTkcvi = new WinFormsField("MENU-ITEM-TKCVI", "TKCVI.  Chess to Issuer sponsored conversion", "ChesstoIssuersponsoredconversion");
        public static WinFormsField MenuItemTktca = new WinFormsField("MENU-ITEM-TKTCA", "TKTCA.  Transfer CHESS accepted holdings to Offeror", "TransferCHESSacceptedholdingstoOfferor");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
