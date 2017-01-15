using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SMIM0300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SMIM0300", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymasterCode = new WinFormsField("PAYMASTER-CODE", "PaymasterCode");
        public static WinFormsField DeductionCode = new WinFormsField("DEDUCTION-CODE", "DeductionCode");
        public static WinFormsField LoanClass = new WinFormsField("LOAN-CLASS", "LoanClass");
        public static WinFormsField EmplClass = new WinFormsField("EMPL-CLASS", "EmplClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField PaymasCode = new WinFormsField("PAYMAS-CODE", "PaymasCode");
        public static WinFormsField DednCode = new WinFormsField("DEDN-CODE", "DednCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}