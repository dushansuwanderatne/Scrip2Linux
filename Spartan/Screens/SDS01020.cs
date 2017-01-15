using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField OfferX = new WinFormsField("OFFER-X", "OfferX");
        public static WinFormsField OfferY = new WinFormsField("OFFER-Y", "OfferY");
        public static WinFormsField RoundOpt = new WinFormsField("ROUND-OPT", "RoundOpt");
        public static WinFormsField Multiple = new WinFormsField("MULTIPLE", "Multiple");
        public static WinFormsField MinAllotment = new WinFormsField("MIN-ALLOTMENT", "MinAllotment");
        public static WinFormsField AllotClass = new WinFormsField("ALLOT-CLASS", "AllotClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
