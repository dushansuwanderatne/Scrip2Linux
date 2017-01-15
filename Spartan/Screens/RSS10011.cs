using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10011", "FormName");
		//Fields


        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField Grp = new WinFormsField("GRP", "Grp");
        public static WinFormsField GroupIDX = new WinFormsField("GROUP-ID-X", "GroupIDX");
        public static WinFormsField Exd = new WinFormsField("EXD", "Exd");
        public static WinFormsField MandatoryClass = new WinFormsField("MANDATORY-CLASS", "MandatoryClass");
        public static WinFormsField RegistersIEInd = new WinFormsField("REGISTERS-IE-IND", "RegistersIEInd");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
