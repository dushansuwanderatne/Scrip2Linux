using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP13

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP13", "FormName");
		//Fields


        public static WinFormsField FormHeading = new WinFormsField("FORM-HEADING", "FormHeading");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CommChgCode = new WinFormsField("COMM-CHG-CODE", "CommChgCode");
        public static WinFormsField ReportMasterCodes = new WinFormsField("REPORT-MASTER-CODES", "ReportMasterCodes");
        public static WinFormsField CommChgTypes = new WinFormsField("COMM-CHG-TYPES", "CommChgTypes");
        public static WinFormsField TestChargeCodesInd = new WinFormsField("TEST-CHARGE-CODES-IND", "TestChargeCodesInd");
        public static WinFormsField TestCalcDealInput = new WinFormsField("TEST-CALC-DEAL-INPUT", "TestCalcDealInput");
        public static WinFormsField TestCalcBulkInput = new WinFormsField("TEST-CALC-BULK-INPUT", "TestCalcBulkInput");
        public static WinFormsField TestCalcUnitInput = new WinFormsField("TEST-CALC-UNIT-INPUT", "TestCalcUnitInput");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
