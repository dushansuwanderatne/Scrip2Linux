using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01047

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01047", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegCode = new WinFormsField("REG-CODE", "RegCode");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField CurrMthEndDate = new WinFormsField("CURR-MTH-END-DATE", "CurrMthEndDate");
        public static WinFormsField RepDate1 = new WinFormsField("REP-DATE-1", "RepDate1");
        public static WinFormsField RepDate2 = new WinFormsField("REP-DATE-2", "RepDate2");
        public static WinFormsField RepDate3 = new WinFormsField("REP-DATE-3", "RepDate3");
        public static WinFormsField FutureSharePrice = new WinFormsField("FUTURE-SHARE-PRICE", "FutureSharePrice");
        public static WinFormsField FutureContBasis = new WinFormsField("FUTURE-CONT-BASIS", "FutureContBasis");
        public static WinFormsField EmpRetFactor = new WinFormsField("EMP-RET-FACTOR", "EmpRetFactor");
        public static WinFormsField RptCurrencyCode = new WinFormsField("RPT-CURRENCY-CODE", "RptCurrencyCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
