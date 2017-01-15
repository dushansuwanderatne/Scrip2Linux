using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00121

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00121", "FormName");
		//Fields


        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField AccumPeriod = new WinFormsField("ACCUM-PERIOD", "AccumPeriod");
        public static WinFormsField EmployeePymtTotal = new WinFormsField("EMPLOYEE-PYMT-TOTAL", "EmployeePymtTotal");
        public static WinFormsField EmployerPymtTotal = new WinFormsField("EMPLOYER-PYMT-TOTAL", "EmployerPymtTotal");
        public static WinFormsField PaymentRecTotal = new WinFormsField("PAYMENT-REC-TOTAL", "PaymentRecTotal");
        public static WinFormsField ProcessNilPymtsInd = new WinFormsField("PROCESS-NIL-PYMTS-IND", "ProcessNilPymtsInd");
        public static WinFormsField Eol00121ForeignCurrencyApply = new WinFormsField("EOL00121-FOREIGN-CURRENCY-APPLY", "Eol00121ForeignCurrencyApply");
        public static WinFormsField RunMode = new WinFormsField("RUN-MODE", "RunMode");
    }
}
