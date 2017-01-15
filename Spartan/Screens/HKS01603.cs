using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01603", "FormName");
		//Fields


        public static WinFormsField ScreenDesc = new WinFormsField("SCREEN-DESC", "ScreenDesc");
        public static WinFormsField ParentTranType = new WinFormsField("PARENT-TRAN-TYPE", "ParentTranType");
        public static WinFormsField OriginalTTDesc = new WinFormsField("ORIGINAL-TT-DESC", "OriginalTTDesc");
        public static WinFormsField ClonedTTID = new WinFormsField("CLONED-TT-ID", "ClonedTTID");
        public static WinFormsField ClonedTt4 = new WinFormsField("CLONED-TT4", "ClonedTt4");
        public static WinFormsField ClonedTTDesc = new WinFormsField("CLONED-TT-DESC", "ClonedTTDesc");
        public static WinFormsField TranTypeList = new WinFormsField("TRAN-TYPE-LIST", "TranTypeList");
        public static WinFormsField TranTypeGroup = new WinFormsField("TRAN-TYPE-GROUP", "TranTypeGroup");
        public static WinFormsField TranTypeAlt = new WinFormsField("TRAN-TYPE-ALT", "TranTypeAlt");
        public static WinFormsField TranBillingGroup = new WinFormsField("TRAN-BILLING-GROUP", "TranBillingGroup");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SearchTranType = new WinFormsField("SEARCH-TRAN-TYPE", "SearchTranType");
        public static WinFormsField TranTypeAltCat = new WinFormsField("TRAN-TYPE-ALT-CAT", "TranTypeAltCat");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
