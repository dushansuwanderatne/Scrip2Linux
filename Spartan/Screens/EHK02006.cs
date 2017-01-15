using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02006", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField TermPendVestFlag = new WinFormsField("TERM-PEND-VEST-FLAG", "TermPendVestFlag");
        public static WinFormsField EmpMoneyRefundFlag = new WinFormsField("EMP-MONEY-REFUND-FLAG", "EmpMoneyRefundFlag");
        public static WinFormsField ForfeitUnvestFlag = new WinFormsField("FORFEIT-UNVEST-FLAG", "ForfeitUnvestFlag");
        public static WinFormsField SaleVestB4Flag = new WinFormsField("SALE-VEST-B4-FLAG", "SaleVestB4Flag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
