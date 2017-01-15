using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CONVER02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CONVER02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField RecordTypeDesc = new WinFormsField("RECORD-TYPE-DESC", "RecordTypeDesc");
        public static WinFormsField OldCode = new WinFormsField("OLD-CODE", "OldCode");
        public static WinFormsField OldDesc = new WinFormsField("OLD-DESC", "OldDesc");
        public static WinFormsField Counter = new WinFormsField("COUNTER", "Counter");
        public static WinFormsField NewCode = new WinFormsField("NEW-CODE", "NewCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchRecordType = new WinFormsField("SEARCH-RECORD-TYPE", "SearchRecordType");
        public static WinFormsField SearchOldCode = new WinFormsField("SEARCH-OLD-CODE", "SearchOldCode");
    }
}
