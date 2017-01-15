using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03501", "FormName");
		//Fields


        public static WinFormsField YSourceDomicile = new WinFormsField("Y-SOURCE-DOMICILE", "YSourceDomicile");
        public static WinFormsField YSourceDomDesc = new WinFormsField("Y-SOURCE-DOM-DESC", "YSourceDomDesc");
        public static WinFormsField RecipientDomicile = new WinFormsField("RECIPIENT-DOMICILE", "RecipientDomicile");
        public static WinFormsField RecipientDomDesc = new WinFormsField("RECIPIENT-DOM-DESC", "RecipientDomDesc");
        public static WinFormsField CompCatCode = new WinFormsField("COMP-CAT-CODE", "CompCatCode");
        public static WinFormsField CompCatDesc = new WinFormsField("COMP-CAT-DESC", "CompCatDesc");
        public static WinFormsField RecipientCodeType = new WinFormsField("RECIPIENT-CODE-TYPE", "RecipientCodeType");
        public static WinFormsField EffectDateDdmmccyy = new WinFormsField("EFFECT-DATE-DDMMCCYY", "EffectDateDdmmccyy");
        public static WinFormsField ExpiryDateDdmmccyy = new WinFormsField("EXPIRY-DATE-DDMMCCYY", "ExpiryDateDdmmccyy");
        public static WinFormsField TaxRateInd = new WinFormsField("TAX-RATE-IND", "TaxRateInd");
        public static WinFormsField TaxRateComp = new WinFormsField("TAX-RATE-COMP", "TaxRateComp");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SearchSource = new WinFormsField("SEARCH-SOURCE", "SearchSource");
        public static WinFormsField SearchRecipient = new WinFormsField("SEARCH-RECIPIENT", "SearchRecipient");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
