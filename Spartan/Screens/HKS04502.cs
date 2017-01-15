using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS04502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS04502", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RequestNumber = new WinFormsField("REQUEST-NUMBER", "RequestNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField StockCode = new WinFormsField("STOCK-CODE", "StockCode");
        public static WinFormsField StockDesc = new WinFormsField("STOCK-DESC", "StockDesc");
        public static WinFormsField RodType = new WinFormsField("ROD-TYPE", "RodType");
        public static WinFormsField RodTypeDesc = new WinFormsField("ROD-TYPE-DESC", "RodTypeDesc");
        public static WinFormsField CorpActionType = new WinFormsField("CORP-ACTION-TYPE", "CorpActionType");
        public static WinFormsField CorpActionDesc = new WinFormsField("CORP-ACTION-DESC", "CorpActionDesc");
        public static WinFormsField CumClass = new WinFormsField("CUM-CLASS", "CumClass");
        public static WinFormsField RecordDate = new WinFormsField("RECORD-DATE", "RecordDate");
        public static WinFormsField PayableDate = new WinFormsField("PAYABLE-DATE", "PayableDate");
        public static WinFormsField Explanation1 = new WinFormsField("EXPLANATION-1", "Explanation1");
        public static WinFormsField Explanation2 = new WinFormsField("EXPLANATION-2", "Explanation2");
        public static WinFormsField Explanation3 = new WinFormsField("EXPLANATION-3", "Explanation3");
        public static WinFormsField RequestorsName = new WinFormsField("REQUESTORS-NAME", "RequestorsName");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
