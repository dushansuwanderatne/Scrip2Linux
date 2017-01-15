using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08501", "FormName");
		//Fields


        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField AddChangeDesc = new WinFormsField("ADD-CHANGE-DESC", "AddChangeDesc");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField RegLine6 = new WinFormsField("REG-LINE-6", "RegLine6");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField ResidencyInd = new WinFormsField("RESIDENCY-IND", "ResidencyInd");
        public static WinFormsField ContactReference = new WinFormsField("CONTACT-REFERENCE", "ContactReference");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField EmailCancel = new WinFormsField("EMAIL-CANCEL", "EmailCancel");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
