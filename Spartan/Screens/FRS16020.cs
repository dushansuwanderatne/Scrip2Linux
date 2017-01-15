using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS16020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS16020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransBalanceFrom = new WinFormsField("TRANS-BALANCE-FROM", "TransBalanceFrom");
        public static WinFormsField TransBalanceTO = new WinFormsField("TRANS-BALANCE-TO", "TransBalanceTO");
        public static WinFormsField RunNumberFrom = new WinFormsField("RUN-NUMBER-FROM", "RunNumberFrom");
        public static WinFormsField RunNumberTO = new WinFormsField("RUN-NUMBER-TO", "RunNumberTO");
        public static WinFormsField LodgementDateFrom = new WinFormsField("LODGEMENT-DATE-FROM", "LodgementDateFrom");
        public static WinFormsField LodgementDateTO = new WinFormsField("LODGEMENT-DATE-TO", "LodgementDateTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
