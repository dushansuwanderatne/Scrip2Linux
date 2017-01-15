using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10015", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransNumFrom = new WinFormsField("TRANS-NUM-FROM", "TransNumFrom");
        public static WinFormsField TransNumTO = new WinFormsField("TRANS-NUM-TO", "TransNumTO");
        public static WinFormsField Sof = new WinFormsField("SOF", "Sof");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField GroupFrom = new WinFormsField("GROUP-FROM", "GroupFrom");
        public static WinFormsField GroupTO = new WinFormsField("GROUP-TO", "GroupTO");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField RunNumFrom = new WinFormsField("RUN-NUM-FROM", "RunNumFrom");
        public static WinFormsField RunNumTO = new WinFormsField("RUN-NUM-TO", "RunNumTO");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}