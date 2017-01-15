using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS03045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS03045", "FormName");
		//Fields


        public static WinFormsField Units120From = new WinFormsField("UNITS1-20-FROM", "Units120From");
        public static WinFormsField Units120TO = new WinFormsField("UNITS1-20-TO", "Units120TO");
        public static WinFormsField Alloted = new WinFormsField("ALLOTED", "Alloted");
        public static WinFormsField XOffer = new WinFormsField("X-OFFER", "XOffer");
        public static WinFormsField YOffer = new WinFormsField("Y-OFFER", "YOffer");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField AllotClass = new WinFormsField("ALLOT-CLASS", "AllotClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
