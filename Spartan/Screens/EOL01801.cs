using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01801", "FormName");
		//Fields


        public static WinFormsField NewTransNbr = new WinFormsField("NEW-TRANS-NBR", "NewTransNbr");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField UnitPrice = new WinFormsField("UNIT-PRICE", "UnitPrice");
        public static WinFormsField OldRunNbr = new WinFormsField("OLD-RUN-NBR", "OldRunNbr");
        public static WinFormsField OldTransNbr = new WinFormsField("OLD-TRANS-NBR", "OldTransNbr");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
