using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL07301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL07301", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField AdjustmentDate = new WinFormsField("ADJUSTMENT-DATE", "AdjustmentDate");
        public static WinFormsField AdjRunNumber = new WinFormsField("ADJ-RUN-NUMBER", "AdjRunNumber");
        public static WinFormsField AdjRefNumber = new WinFormsField("ADJ-REF-NUMBER", "AdjRefNumber");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
