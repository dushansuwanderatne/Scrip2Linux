using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0701", "FormName");
		//Fields
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField SharePriceFrom = new WinFormsField("SHARE-PRICE-FROM", "SharePriceFrom");
        public static WinFormsField SharePriceTO = new WinFormsField("SHARE-PRICE-TO", "SharePriceTO");
        public static WinFormsField SharePriceInt = new WinFormsField("SHARE-PRICE-INT", "SharePriceInt");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField MaxNbrUnits = new WinFormsField("MAX-NBR-UNITS", "MaxNbrUnits");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField CalcMatchingInd = new WinFormsField("CALC-MATCHING-IND", "CalcMatchingInd");
        public static WinFormsField UnapValidType = new WinFormsField("UNAP-VALID-TYPE", "UnapValidType");
        public static WinFormsField NbrUnapTOUse = new WinFormsField("NBR-UNAP-TO-USE", "NbrUnapTOUse");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
