using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISS01025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISS01025", "FormName");
		//Fields


        public static WinFormsField RecordMoney = new WinFormsField("RECORD-MONEY", "RecordMoney");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField UnallocateID = new WinFormsField("UNALLOCATE-ID", "UnallocateID");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField HvfExceptionNbr = new WinFormsField("HVF-EXCEPTION-NBR", "HvfExceptionNbr");
        public static WinFormsField ExcLegitimateValue = new WinFormsField("EXC-LEGITIMATE-VALUE", "ExcLegitimateValue");
        public static WinFormsField ExcProblemValue = new WinFormsField("EXC-PROBLEM-VALUE", "ExcProblemValue");
        public static WinFormsField MPRoundupInd = new WinFormsField("MP-ROUNDUP-IND", "MPRoundupInd");
        public static WinFormsField MPEntitleClass = new WinFormsField("MP-ENTITLE-CLASS", "MPEntitleClass");
        public static WinFormsField MPAcceptClass = new WinFormsField("MP-ACCEPT-CLASS", "MPAcceptClass");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
