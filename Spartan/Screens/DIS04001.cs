using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS04001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS04001", "FormName");
		//Fields


        public static WinFormsField MenuItemNcp = new WinFormsField("MENU-ITEM-NCP", "NCP. Nominate Company Components", "NominateCompanyComponents");
        public static WinFormsField MenuItemEqc = new WinFormsField("MENU-ITEM-EQC", "EQC. Enquire on Components", "EnquireonComponents");
        public static WinFormsField MenuItemEtc = new WinFormsField("MENU-ITEM-ETC", "ETC. Enquire on Master Tax Codes", "EnquireonMasterTaxCodes");
        public static WinFormsField MenuItemCtc = new WinFormsField("MENU-ITEM-CTC", "CTC. Company Tax Codes", "CompanyTaxCodes");
        public static WinFormsField MenuItemEis = new WinFormsField("MENU-ITEM-EIS", "EIS. Enquire on Income Source Tax Rates", "EnquireonIncomeSourceTaxRates");
        public static WinFormsField MenuItemEar = new WinFormsField("MENU-ITEM-EAR", "EAR. Enquire on AIIR References", "EnquireonAIIRReferences");
        public static WinFormsField MenuItemEac = new WinFormsField("MENU-ITEM-EAC", "EAC. Enquire on AIIR/Payment Component Type", "EnquireonAIIR/PaymentComponentType");
        public static WinFormsField MenuItemEca = new WinFormsField("MENU-ITEM-ECA", "ECA. Enquire on Payment Component Type/AIIR", "EnquireonPaymentComponentType/AIIR");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
