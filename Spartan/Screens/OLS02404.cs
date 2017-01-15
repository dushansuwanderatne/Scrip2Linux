using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02404", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField MarkingNbr = new WinFormsField("MARKING-NBR", "MarkingNbr");
        public static WinFormsField MarkingDate = new WinFormsField("MARKING-DATE", "MarkingDate");
        public static WinFormsField ReissueBal = new WinFormsField("REISSUE-BAL", "ReissueBal");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField Instructions = new WinFormsField("INSTRUCTIONS", "Instructions");
        public static WinFormsField SplitNumber = new WinFormsField("SPLIT-NUMBER", "SplitNumber");
        public static WinFormsField SplitUnits = new WinFormsField("SPLIT-UNITS", "SplitUnits");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
