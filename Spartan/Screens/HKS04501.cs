using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS04501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS04501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RequestNumber = new WinFormsField("REQUEST-NUMBER", "RequestNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RodType = new WinFormsField("ROD-TYPE", "RodType");
        public static WinFormsField RecordDate = new WinFormsField("RECORD-DATE", "RecordDate");
        public static WinFormsField Explanation1 = new WinFormsField("EXPLANATION-1", "Explanation1");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Explanation2 = new WinFormsField("EXPLANATION-2", "Explanation2");
        public static WinFormsField BuiltDate = new WinFormsField("BUILT-DATE", "BuiltDate");
        public static WinFormsField Explanation3 = new WinFormsField("EXPLANATION-3", "Explanation3");
        public static WinFormsField Holders = new WinFormsField("HOLDERS", "Holders");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchRequest = new WinFormsField("SEARCH-REQUEST", "SearchRequest");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
