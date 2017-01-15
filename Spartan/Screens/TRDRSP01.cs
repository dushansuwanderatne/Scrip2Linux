using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP01", "FormName");
		//Fields


        public static WinFormsField FormHeading = new WinFormsField("FORM-HEADING", "FormHeading");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField TrdCntrlCode = new WinFormsField("TRD-CNTRL-CODE", "TrdCntrlCode");
        public static WinFormsField ReportNonCurrent = new WinFormsField("REPORT-NON-CURRENT", "ReportNonCurrent");
        public static WinFormsField TrdType = new WinFormsField("TRD-TYPE", "TrdType");
        public static WinFormsField RealTimeTrdInd = new WinFormsField("REAL-TIME-TRD-IND", "RealTimeTrdInd");
        public static WinFormsField TrdOrdStatus = new WinFormsField("TRD-ORD-STATUS", "TrdOrdStatus");
        public static WinFormsField CutOffDateFrom = new WinFormsField("CUT-OFF-DATE-FROM", "CutOffDateFrom");
        public static WinFormsField CutOffDateTO = new WinFormsField("CUT-OFF-DATE-TO", "CutOffDateTO");
        public static WinFormsField TrdDateFrom = new WinFormsField("TRD-DATE-FROM", "TrdDateFrom");
        public static WinFormsField TrdDateTO = new WinFormsField("TRD-DATE-TO", "TrdDateTO");
        public static WinFormsField StlDateFrom = new WinFormsField("STL-DATE-FROM", "StlDateFrom");
        public static WinFormsField StlDateTO = new WinFormsField("STL-DATE-TO", "StlDateTO");
        public static WinFormsField OrdNumFrom = new WinFormsField("ORD-NUM-FROM", "OrdNumFrom");
        public static WinFormsField OrdNumTO = new WinFormsField("ORD-NUM-TO", "OrdNumTO");
        public static WinFormsField FinalPriceFrom = new WinFormsField("FINAL-PRICE-FROM", "FinalPriceFrom");
        public static WinFormsField FinalPriceTO = new WinFormsField("FINAL-PRICE-TO", "FinalPriceTO");
        public static WinFormsField TotUnitRangeFrom = new WinFormsField("TOT-UNIT-RANGE-FROM", "TotUnitRangeFrom");
        public static WinFormsField TotUnitRangeTO = new WinFormsField("TOT-UNIT-RANGE-TO", "TotUnitRangeTO");
        public static WinFormsField TotMnyRangeFrom = new WinFormsField("TOT-MNY-RANGE-FROM", "TotMnyRangeFrom");
        public static WinFormsField TotMnyRangeTO = new WinFormsField("TOT-MNY-RANGE-TO", "TotMnyRangeTO");
        public static WinFormsField TranNumRangeFrom = new WinFormsField("TRAN-NUM-RANGE-FROM", "TranNumRangeFrom");
        public static WinFormsField TranNumRangeTO = new WinFormsField("TRAN-NUM-RANGE-TO", "TranNumRangeTO");
        public static WinFormsField PymtRefRangeFrom = new WinFormsField("PYMT-REF-RANGE-FROM", "PymtRefRangeFrom");
        public static WinFormsField PymtRefRangeTO = new WinFormsField("PYMT-REF-RANGE-TO", "PymtRefRangeTO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
