using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01060", "FormName");
		//Fields


        public static WinFormsField OfferClass = new WinFormsField("OFFER-CLASS", "OfferClass");
        public static WinFormsField OfferClassDesc = new WinFormsField("OFFER-CLASS-DESC", "OfferClassDesc");
        public static WinFormsField TypeOFOffer = new WinFormsField("TYPE-OF-OFFER", "TypeOFOffer");
        public static WinFormsField AsxTakeoverCode = new WinFormsField("ASX-TAKEOVER-CODE", "AsxTakeoverCode");
        public static WinFormsField AsxTakeoverDesc = new WinFormsField("ASX-TAKEOVER-DESC", "AsxTakeoverDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
