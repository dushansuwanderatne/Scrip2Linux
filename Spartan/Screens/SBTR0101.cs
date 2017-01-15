using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBTR0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBTR0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField SalaryClass = new WinFormsField("SALARY-CLASS", "SalaryClass");
        public static WinFormsField SalaryFactor = new WinFormsField("SALARY-FACTOR", "SalaryFactor");
        public static WinFormsField NotionalPrice = new WinFormsField("NOTIONAL-PRICE", "NotionalPrice");
        public static WinFormsField FactorMultiple = new WinFormsField("FACTOR-MULTIPLE", "FactorMultiple");
        public static WinFormsField EntitleClass = new WinFormsField("ENTITLE-CLASS", "EntitleClass");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
