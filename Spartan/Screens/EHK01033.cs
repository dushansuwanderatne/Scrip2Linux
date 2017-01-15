using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01033

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01033", "FormName");
		//Fields


        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField DcbUserNum = new WinFormsField("DCB-USER-NUM", "DcbUserNum");
        public static WinFormsField GbrTrace1to2 = new WinFormsField("GBR-TRACE-1TO2", "GbrTrace1to2");
        public static WinFormsField GbrTraceDash1 = new WinFormsField("GBR-TRACE-DASH1", "GbrTraceDash1");
        public static WinFormsField GbrTrace3to4 = new WinFormsField("GBR-TRACE-3TO4", "GbrTrace3to4");
        public static WinFormsField GbrTraceDash2 = new WinFormsField("GBR-TRACE-DASH2", "GbrTraceDash2");
        public static WinFormsField GbrTrace5to6 = new WinFormsField("GBR-TRACE-5TO6", "GbrTrace5to6");
        public static WinFormsField GbrTraceAccount = new WinFormsField("GBR-TRACE-ACCOUNT", "GbrTraceAccount");
        public static WinFormsField GbrRemitterName = new WinFormsField("GBR-REMITTER-NAME", "GbrRemitterName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
