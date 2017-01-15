using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03401", "FormName");
		//Fields


        public static WinFormsField MenuItemFcvse = new WinFormsField("MENU-ITEM-FCVSE", "FCVSE.  (F)ast (C)onversion from (S)ponsored to (E)ntrepot Account", "(F)ast(C)onversionfrom(S)ponsoredto(E)ntrepotAccount");
        public static WinFormsField MenuItemFbchg = new WinFormsField("MENU-ITEM-FBCHG", "FBCHG.  (F)ast (B)roker Code (C)hange", "(F)ast(B)rokerCode(C)hange");
        public static WinFormsField MenuItemFrchg = new WinFormsField("MENU-ITEM-FRCHG", "FRCHG.  (F)ast (R)egister Code (C)hange", "(F)ast(R)egisterCode(C)hange");
        public static WinFormsField MenuItemFtchg = new WinFormsField("MENU-ITEM-FTCHG", "FTCHG.  (F)ast (T)otr/Tetr Change", "(F)ast(T)otr/TetrChange");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
