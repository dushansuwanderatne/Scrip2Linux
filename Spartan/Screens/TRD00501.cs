using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00501", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ReutersPrice = new WinFormsField("REUTERS-PRICE", "ReutersPrice");
        public static WinFormsField ReutersPriceStatus = new WinFormsField("REUTERS-PRICE-STATUS", "ReutersPriceStatus");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField ReportMode = new WinFormsField("REPORT-MODE", "ReportMode");
        public static WinFormsField SharePriceFrom = new WinFormsField("SHARE-PRICE-FROM", "SharePriceFrom");
        public static WinFormsField SharePriceTO = new WinFormsField("SHARE-PRICE-TO", "SharePriceTO");
        public static WinFormsField SharePrice = new WinFormsField("SHARE-PRICE", "SharePrice");
        public static WinFormsField SharePriceInt = new WinFormsField("SHARE-PRICE-INT", "SharePriceInt");
        public static WinFormsField GenerateDetailReport = new WinFormsField("GENERATE-DETAIL-REPORT", "GenerateDetailReport");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
