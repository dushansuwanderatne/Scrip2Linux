using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class COMTBL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("COMTBL00", "FormName");
		//Fields


        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField ChargeType = new WinFormsField("CHARGE-TYPE", "ChargeType");
        public static WinFormsField SalesTaxCode = new WinFormsField("SALES-TAX-CODE", "SalesTaxCode");
        public static WinFormsField ApportionChargeInd = new WinFormsField("APPORTION-CHARGE-IND", "ApportionChargeInd");
        public static WinFormsField SpecialProgramInd = new WinFormsField("SPECIAL-PROGRAM-IND", "SpecialProgramInd");
        public static WinFormsField SpecialProgramPrefix = new WinFormsField("SPECIAL-PROGRAM-PREFIX", "SpecialProgramPrefix");
        public static WinFormsField DomicileSpecificInd = new WinFormsField("DOMICILE-SPECIFIC-IND", "DomicileSpecificInd");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField ChargeFlag = new WinFormsField("CHARGE-FLAG", "ChargeFlag");
        public static WinFormsField RangeFrom = new WinFormsField("RANGE-FROM", "RangeFrom");
        public static WinFormsField RangeTO = new WinFormsField("RANGE-TO", "RangeTO");
        public static WinFormsField Rate = new WinFormsField("RATE", "Rate");
        public static WinFormsField ChargeRounding = new WinFormsField("CHARGE-ROUNDING", "ChargeRounding");
        public static WinFormsField ChargeMin = new WinFormsField("CHARGE-MIN", "ChargeMin");
        public static WinFormsField ChargeMax = new WinFormsField("CHARGE-MAX", "ChargeMax");
        public static WinFormsField ChargeMult = new WinFormsField("CHARGE-MULT", "ChargeMult");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SearchChargeCode = new WinFormsField("SEARCH-CHARGE-CODE", "SearchChargeCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
