using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS11001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS11001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField PrintfileName = new WinFormsField("PRINTFILE-NAME", "PrintfileName");
        public static WinFormsField StartTransNO = new WinFormsField("START-TRANS-NO", "StartTransNO");
        public static WinFormsField EndTransNO = new WinFormsField("END-TRANS-NO", "EndTransNO");
        public static WinFormsField TotalWithdrawals = new WinFormsField("TOTAL-WITHDRAWALS", "TotalWithdrawals");
        public static WinFormsField TotalUnitsIssued = new WinFormsField("TOTAL-UNITS-ISSUED", "TotalUnitsIssued");
        public static WinFormsField TotalAmountPaid = new WinFormsField("TOTAL-AMOUNT-PAID", "TotalAmountPaid");
        public static WinFormsField TotalNegativeZero = new WinFormsField("TOTAL-NEGATIVE-ZERO", "TotalNegativeZero");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
