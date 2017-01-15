using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0710

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0710", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ReportMode = new WinFormsField("REPORT-MODE", "ReportMode");
        public static WinFormsField SharePriceFrom = new WinFormsField("SHARE-PRICE-FROM", "SharePriceFrom");
        public static WinFormsField SharePriceTO = new WinFormsField("SHARE-PRICE-TO", "SharePriceTO");
        public static WinFormsField SharePrice = new WinFormsField("SHARE-PRICE", "SharePrice");
        public static WinFormsField SharePriceInt = new WinFormsField("SHARE-PRICE-INT", "SharePriceInt");
    }
}
