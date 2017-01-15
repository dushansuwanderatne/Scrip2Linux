using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS04001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS04001", "FormName");
		//Fields


        public static WinFormsField MenuItemFtfcu = new WinFormsField("MENU-ITEM-FTFCU", "FTFCU.  (F)ast (T)rans(F)er   - (C)ertificated   to (U)ncertificated", "(F)ast(T)rans(F)er-(C)ertificatedto(U)ncertificated");
        public static WinFormsField MenuItemFtfuc = new WinFormsField("MENU-ITEM-FTFUC", "FTFUC.  (F)ast (T)rans(F)er   - (U)ncertificated to (C)ertificated", "(F)ast(T)rans(F)er-(U)ncertificatedto(C)ertificated");
        public static WinFormsField MenuItemFtfuu = new WinFormsField("MENU-ITEM-FTFUU", "FTFUU.  (F)ast (T)rans(F)er   - (U)ncertificated to (U)ncertificated", "(F)ast(T)rans(F)er-(U)ncertificatedto(U)ncertificated");
        public static WinFormsField MenuItemFcvcu = new WinFormsField("MENU-ITEM-FCVCU", "FCVCU.  (F)ast (C)on(V)ersion - (C)ertificated   to (U)ncertificated", "(F)ast(C)on(V)ersion-(C)ertificatedto(U)ncertificated");
        public static WinFormsField MenuItemFcvuc = new WinFormsField("MENU-ITEM-FCVUC", "FCVUC.  (F)ast (C)on(V)ersion - (U)ncertificated to (C)ertificated", "(F)ast(C)on(V)ersion-(U)ncertificatedto(C)ertificated");
        public static WinFormsField MenuItemFcsuu = new WinFormsField("MENU-ITEM-FCSUU", "FCSUU.  (F)ast (C)hange (S)ponsorship - (U)ncertif'd to (U)ncertif'd", "(F)ast(C)hange(S)ponsorship-(U)ncertif'dto(U)ncertif'd");
        public static WinFormsField MenuItemFexuu = new WinFormsField("MENU-ITEM-FEXUU", "FEXUU.  (F)ast (E)xercise (C)onversion - (U)ncertif'd to (U)ncertif'd", "(F)ast(E)xercise(C)onversion-(U)ncertif'dto(U)ncertif'd");
        public static WinFormsField MenuItemFajst = new WinFormsField("MENU-ITEM-FAJST", "FAJST.  (F)ast (A)djustment", "(F)ast(A)djustment");
        public static WinFormsField MenuItemFajdn = new WinFormsField("MENU-ITEM-FAJDN", "FAJDN.  (F)ast (A)djustment - (D)ecrease", "(F)ast(A)djustment-(D)ecrease");
        public static WinFormsField MenuItemFajup = new WinFormsField("MENU-ITEM-FAJUP", "FAJUP.  (F)ast (A)djustment - Increase", "(F)ast(A)djustment-Increase");
        public static WinFormsField MenuItemFastr = new WinFormsField("MENU-ITEM-FASTR", "FASTR.  Process FASTER Transactions (Pending/Accepted)", "ProcessFASTERTransactions(Pending/Accepted)");
        public static WinFormsField MenuItemFstmt = new WinFormsField("MENU-ITEM-FSTMT", "FSTMT.  (F)ast USeR Statement", "(F)astUSeRStatement");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
