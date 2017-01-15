using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AbtTraceBsb = new WinFormsField("ABT-TRACE-BSB", "AbtTraceBsb");
        public static WinFormsField AbtTraceAccount = new WinFormsField("ABT-TRACE-ACCOUNT", "AbtTraceAccount");
        public static WinFormsField AbtTraceRemitter = new WinFormsField("ABT-TRACE-REMITTER", "AbtTraceRemitter");
        public static WinFormsField AbtUserNumber = new WinFormsField("ABT-USER-NUMBER", "AbtUserNumber");
        public static WinFormsField AbtHomeBankDesc = new WinFormsField("ABT-HOME-BANK-DESC", "AbtHomeBankDesc");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
