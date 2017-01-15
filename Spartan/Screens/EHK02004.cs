using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02004", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField FirstAllotPeriod = new WinFormsField("FIRST-ALLOT-PERIOD", "FirstAllotPeriod");
        public static WinFormsField LastAllotPeriod = new WinFormsField("LAST-ALLOT-PERIOD", "LastAllotPeriod");
        public static WinFormsField LastAllotDate = new WinFormsField("LAST-ALLOT-DATE", "LastAllotDate");
        public static WinFormsField CurrAllotPeriod = new WinFormsField("CURR-ALLOT-PERIOD", "CurrAllotPeriod");
        public static WinFormsField AllotFreq = new WinFormsField("ALLOT-FREQ", "AllotFreq");
        public static WinFormsField AllotRoundInd = new WinFormsField("ALLOT-ROUND-IND", "AllotRoundInd");
        public static WinFormsField AllotPoolHid = new WinFormsField("ALLOT-POOL-HID", "AllotPoolHid");
        public static WinFormsField AllotPoolClass = new WinFormsField("ALLOT-POOL-CLASS", "AllotPoolClass");
        public static WinFormsField AllotRollPoolFlag = new WinFormsField("ALLOT-ROLL-POOL-FLAG", "AllotRollPoolFlag");
        public static WinFormsField AllotTranType = new WinFormsField("ALLOT-TRAN-TYPE", "AllotTranType");
        public static WinFormsField AllotCashCFFlg = new WinFormsField("ALLOT-CASH-CF-FLG", "AllotCashCFFlg");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
