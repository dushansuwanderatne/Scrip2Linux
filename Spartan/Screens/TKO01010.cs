using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TkoCoyDesc = new WinFormsField("TKO-COY-DESC", "TkoCoyDesc");
        public static WinFormsField UpdOfferDets = new WinFormsField("UPD-OFFER-DETS", "UpdOfferDets");
        public static WinFormsField UpdEntitlementDets = new WinFormsField("UPD-ENTITLEMENT-DETS", "UpdEntitlementDets");
        public static WinFormsField UpdAllotmentDets = new WinFormsField("UPD-ALLOTMENT-DETS", "UpdAllotmentDets");
        public static WinFormsField TkoStatus = new WinFormsField("TKO-STATUS", "TkoStatus");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
