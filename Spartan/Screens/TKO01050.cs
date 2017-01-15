using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01050", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TkoCoyDesc = new WinFormsField("TKO-COY-DESC", "TkoCoyDesc");
        public static WinFormsField SpecialCalcProcess = new WinFormsField("SPECIAL-CALC-PROCESS", "SpecialCalcProcess");
        public static WinFormsField CalcProgName = new WinFormsField("CALC-PROG-NAME", "CalcProgName");
        public static WinFormsField CashOnlyOffer = new WinFormsField("CASH-ONLY-OFFER", "CashOnlyOffer");
        public static WinFormsField AmtRoundCash = new WinFormsField("AMT-ROUND-CASH", "AmtRoundCash");
        public static WinFormsField AmtRoundParcel = new WinFormsField("AMT-ROUND-PARCEL", "AmtRoundParcel");
        public static WinFormsField AmtRoundFraction = new WinFormsField("AMT-ROUND-FRACTION", "AmtRoundFraction");
        public static WinFormsField ParcelRound = new WinFormsField("PARCEL-ROUND", "ParcelRound");
        public static WinFormsField EntCalcOption = new WinFormsField("ENT-CALC-OPTION", "EntCalcOption");
        public static WinFormsField EntRound = new WinFormsField("ENT-ROUND", "EntRound");
        public static WinFormsField EntMinimum = new WinFormsField("ENT-MINIMUM", "EntMinimum");
        public static WinFormsField UpdateTkoCoy = new WinFormsField("UPDATE-TKO-COY", "UpdateTkoCoy");
        public static WinFormsField TakeovererUfd = new WinFormsField("TAKEOVERER-UFD", "TakeovererUfd");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
