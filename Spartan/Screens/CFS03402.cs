using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03402", "FormName");
		//Fields


        public static WinFormsField CompCode = new WinFormsField("COMP-CODE", "CompCode");
        public static WinFormsField CompDesc = new WinFormsField("COMP-DESC", "CompDesc");
        public static WinFormsField CompTypeCode = new WinFormsField("COMP-TYPE-CODE", "CompTypeCode");
        public static WinFormsField CompTypeDesc = new WinFormsField("COMP-TYPE-DESC", "CompTypeDesc");
        public static WinFormsField CompCatCode = new WinFormsField("COMP-CAT-CODE", "CompCatCode");
        public static WinFormsField CompCatDesc = new WinFormsField("COMP-CAT-DESC", "CompCatDesc");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ControlHolderID = new WinFormsField("CONTROL-HOLDER-ID", "ControlHolderID");
        public static WinFormsField SuppressCtlHldrInd = new WinFormsField("SUPPRESS-CTL-HLDR-IND", "SuppressCtlHldrInd");
        public static WinFormsField ApplyTOIssCQInd = new WinFormsField("APPLY-TO-ISS-CQ-IND", "ApplyTOIssCQInd");
        public static WinFormsField ApplyTOUnissCQInd = new WinFormsField("APPLY-TO-UNISS-CQ-IND", "ApplyTOUnissCQInd");
        public static WinFormsField ApplyTOIssTPInd = new WinFormsField("APPLY-TO-ISS-TP-IND", "ApplyTOIssTPInd");
        public static WinFormsField ApplyTOUnissTPInd = new WinFormsField("APPLY-TO-UNISS-TP-IND", "ApplyTOUnissTPInd");
        public static WinFormsField ApplyTODCInd = new WinFormsField("APPLY-TO-DC-IND", "ApplyTODCInd");
        public static WinFormsField DCPayCodeInd = new WinFormsField("DC-PAY-CODE-IND", "DCPayCodeInd");
        public static WinFormsField ApplyTOUCInd = new WinFormsField("APPLY-TO-UC-IND", "ApplyTOUCInd");
        public static WinFormsField UCPayCodeInd = new WinFormsField("UC-PAY-CODE-IND", "UCPayCodeInd");
        public static WinFormsField ApplyTOBulkInd = new WinFormsField("APPLY-TO-BULK-IND", "ApplyTOBulkInd");
        public static WinFormsField BulkCodeInd = new WinFormsField("BULK-CODE-IND", "BulkCodeInd");
        public static WinFormsField ApplyTOFgnChqInd = new WinFormsField("APPLY-TO-FGN-CHQ-IND", "ApplyTOFgnChqInd");
        public static WinFormsField ApplyTOPaidCrrInd = new WinFormsField("APPLY-TO-PAID-CRR-IND", "ApplyTOPaidCrrInd");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField ApplyTODomCodeFlg = new WinFormsField("APPLY-TO-DOM-CODE-FLG", "ApplyTODomCodeFlg");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
