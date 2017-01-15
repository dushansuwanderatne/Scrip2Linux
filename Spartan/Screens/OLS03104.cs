using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03104", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Chp4Desc = new WinFormsField("CHP4-DESC", "Chp4Desc");
        public static WinFormsField InvName = new WinFormsField("INV-NAME", "InvName");
        public static WinFormsField InvType = new WinFormsField("INV-TYPE", "InvType");
        public static WinFormsField InvTinStatus = new WinFormsField("INV-TIN-STATUS", "InvTinStatus");
        public static WinFormsField InvChpt3 = new WinFormsField("INV-CHPT-3", "InvChpt3");
        public static WinFormsField InvChpt4 = new WinFormsField("INV-CHPT-4", "InvChpt4");
        public static WinFormsField InvW8Exp = new WinFormsField("INV-W8-EXP", "InvW8Exp");
        public static WinFormsField InvNumCntrols = new WinFormsField("INV-NUM-CNTROLS", "InvNumCntrols");
        public static WinFormsField CntNumber = new WinFormsField("CNT-NUMBER", "CntNumber");
        public static WinFormsField CntName = new WinFormsField("CNT-NAME", "CntName");
        public static WinFormsField CntResCountry = new WinFormsField("CNT-RES-COUNTRY", "CntResCountry");
        public static WinFormsField CntCtznCountry = new WinFormsField("CNT-CTZN-COUNTRY", "CntCtznCountry");
        public static WinFormsField CntBen = new WinFormsField("CNT-BEN", "CntBen");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
