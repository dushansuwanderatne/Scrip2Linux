using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField CoyMatchInd = new WinFormsField("COY-MATCH-IND", "CoyMatchInd");
        public static WinFormsField CoyMatchOfferX = new WinFormsField("COY-MATCH-OFFER-X", "CoyMatchOfferX");
        public static WinFormsField CoyMatchOfferY = new WinFormsField("COY-MATCH-OFFER-Y", "CoyMatchOfferY");
        public static WinFormsField CoyMatchRoundInd = new WinFormsField("COY-MATCH-ROUND-IND", "CoyMatchRoundInd");
        public static WinFormsField LimitRequired = new WinFormsField("LIMIT-REQUIRED", "LimitRequired");
        public static WinFormsField CoyMatchLimit = new WinFormsField("COY-MATCH-LIMIT", "CoyMatchLimit");
        public static WinFormsField MatchCoyMoneyFlag = new WinFormsField("MATCH-COY-MONEY-FLAG", "MatchCoyMoneyFlag");
        public static WinFormsField CoyVestInd = new WinFormsField("COY-VEST-IND", "CoyVestInd");
        public static WinFormsField CoyVestClass = new WinFormsField("COY-VEST-CLASS", "CoyVestClass");
        public static WinFormsField CoyVestTaxCat = new WinFormsField("COY-VEST-TAX-CAT", "CoyVestTaxCat");
        public static WinFormsField CoyUnvestClass = new WinFormsField("COY-UNVEST-CLASS", "CoyUnvestClass");
        public static WinFormsField CoyUnvestTaxCat = new WinFormsField("COY-UNVEST-TAX-CAT", "CoyUnvestTaxCat");
        public static WinFormsField CoyVestPeriod = new WinFormsField("COY-VEST-PERIOD", "CoyVestPeriod");
        public static WinFormsField CoyVestTransType = new WinFormsField("COY-VEST-TRANS-TYPE", "CoyVestTransType");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
