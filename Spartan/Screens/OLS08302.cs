using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08302", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField AsxTakeoverCode = new WinFormsField("ASX-TAKEOVER-CODE", "AsxTakeoverCode");
        public static WinFormsField ScripTakeoverNumber = new WinFormsField("SCRIP-TAKEOVER-NUMBER", "ScripTakeoverNumber");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField AsxTakeoverDesc = new WinFormsField("ASX-TAKEOVER-DESC", "AsxTakeoverDesc");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField ActionField = new WinFormsField("ACTION-FIELD", "ActionField");
        public static WinFormsField AccClassCode = new WinFormsField("ACC-CLASS-CODE", "AccClassCode");
        public static WinFormsField AccClassDesc = new WinFormsField("ACC-CLASS-DESC", "AccClassDesc");
        public static WinFormsField OfferClassCode = new WinFormsField("OFFER-CLASS-CODE", "OfferClassCode");
        public static WinFormsField OfferClassDesc = new WinFormsField("OFFER-CLASS-DESC", "OfferClassDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
