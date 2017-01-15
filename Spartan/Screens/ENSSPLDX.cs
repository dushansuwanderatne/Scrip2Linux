using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLDX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLDX", "FormName");
		//Fields


        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Cat = new WinFormsField("CAT", "Cat");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Column1 = new WinFormsField("COLUMN1", "Column1");
        public static WinFormsField Column2 = new WinFormsField("COLUMN2", "Column2");
        public static WinFormsField Column3 = new WinFormsField("COLUMN3", "Column3");
        public static WinFormsField Column4 = new WinFormsField("COLUMN4", "Column4");
        public static WinFormsField Column5 = new WinFormsField("COLUMN5", "Column5");
        public static WinFormsField ExcludeDom5 = new WinFormsField("EXCLUDE-DOM-5", "ExcludeDom5");
        public static WinFormsField AttribAmount = new WinFormsField("ATTRIB-AMOUNT", "AttribAmount");
        public static WinFormsField AttribIndAmt = new WinFormsField("ATTRIB-IND-AMT", "AttribIndAmt");
        public static WinFormsField IndPercent = new WinFormsField("IND-PERCENT", "IndPercent");
        public static WinFormsField AttribSupAmt = new WinFormsField("ATTRIB-SUP-AMT", "AttribSupAmt");
        public static WinFormsField SupPercent = new WinFormsField("SUP-PERCENT", "SupPercent");
        public static WinFormsField Brokerage = new WinFormsField("BROKERAGE", "Brokerage");
        public static WinFormsField StampDuty = new WinFormsField("STAMP-DUTY", "StampDuty");
        public static WinFormsField AdminCosts = new WinFormsField("ADMIN-COSTS", "AdminCosts");
        public static WinFormsField InterestRepay = new WinFormsField("INTEREST-REPAY", "InterestRepay");
    }
}
