using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02007

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02007", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField ReserveHid = new WinFormsField("RESERVE-HID", "ReserveHid");
        public static WinFormsField ReserveClass = new WinFormsField("RESERVE-CLASS", "ReserveClass");
        public static WinFormsField ReserveEmpMoneyCL = new WinFormsField("RESERVE-EMP-MONEY-CL", "ReserveEmpMoneyCL");
        public static WinFormsField ReserveCoyMoneyCL = new WinFormsField("RESERVE-COY-MONEY-CL", "ReserveCoyMoneyCL");
        public static WinFormsField EmpCntrolInd = new WinFormsField("EMP-CNTROL-IND", "EmpCntrolInd");
        public static WinFormsField EmpCntrolHid = new WinFormsField("EMP-CNTROL-HID", "EmpCntrolHid");
        public static WinFormsField EmpCntrolClass = new WinFormsField("EMP-CNTROL-CLASS", "EmpCntrolClass");
        public static WinFormsField TotalCashONFile = new WinFormsField("TOTAL-CASH-ON-FILE", "TotalCashONFile");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
