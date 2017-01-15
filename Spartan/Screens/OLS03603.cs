using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03603", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranNumber = new WinFormsField("TRAN-NUMBER", "TranNumber");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Sell1cert = new WinFormsField("SELL-1CERT", "Sell1cert");
        //public static WinFormsField 1Ind = new WinFormsField("1-IND", "1Ind");
        //public static WinFormsField 1Desc = new WinFormsField("1-DESC", "1Desc");
        public static WinFormsField SellXcert = new WinFormsField("SELL-XCERT", "SellXcert");
        public static WinFormsField OldXind = new WinFormsField("OLD-XIND", "OldXind");
        public static WinFormsField OldXdesc = new WinFormsField("OLD-XDESC", "OldXdesc");
        public static WinFormsField NewInd = new WinFormsField("NEW-IND", "NewInd");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
