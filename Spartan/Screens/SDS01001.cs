using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SDS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SDS01001", "FormName");
		//Fields


        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepHeading = new WinFormsField("REP HEADING", "RepHeading");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField XtrFilname = new WinFormsField("XTR-FILNAME", "XtrFilname");
        public static WinFormsField ScaleDownType = new WinFormsField("SCALE-DOWN-TYPE", "ScaleDownType");
        public static WinFormsField UnitMoneySelection = new WinFormsField("UNIT-MONEY-SELECTION", "UnitMoneySelection");
        public static WinFormsField ClassGroup1 = new WinFormsField("CLASS-GROUP1", "ClassGroup1");
        public static WinFormsField ClassGroup2 = new WinFormsField("CLASS GROUP2", "ClassGroup2");
        public static WinFormsField ClassGroup3 = new WinFormsField("CLASS GROUP3", "ClassGroup3");
        public static WinFormsField ClassGroup4 = new WinFormsField("CLASS GROUP4", "ClassGroup4");
        public static WinFormsField ClassGroup5 = new WinFormsField("CLASS GROUP5", "ClassGroup5");
        public static WinFormsField ScaleDownParFlag = new WinFormsField("SCALE-DOWN-PAR-FLAG", "ScaleDownParFlag");
        public static WinFormsField ScaledownUnitPrice = new WinFormsField("SCALEDOWN-UNIT-PRICE", "ScaledownUnitPrice");
        public static WinFormsField MoneyClassFlag = new WinFormsField("MONEY-CLASS-FLAG", "MoneyClassFlag");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField RefundClass = new WinFormsField("REFUND-CLASS", "RefundClass");
        public static WinFormsField BoughtBackFlag = new WinFormsField("BOUGHT-BACK-FLAG", "BoughtBackFlag");
        public static WinFormsField MarketableParcel = new WinFormsField("MARKETABLE-PARCEL", "MarketableParcel");
        public static WinFormsField TargetCompany = new WinFormsField("TARGET-COMPANY", "TargetCompany");
        public static WinFormsField EntitledClass = new WinFormsField("ENTITLED-CLASS", "EntitledClass");
        public static WinFormsField TargetClass = new WinFormsField("TARGET-CLASS", "TargetClass");
        public static WinFormsField BulksSettledFlag = new WinFormsField("BULKS-SETTLED-FLAG", "BulksSettledFlag");
        public static WinFormsField BuybackGroup = new WinFormsField("BUYBACK-GROUP", "BuybackGroup");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
