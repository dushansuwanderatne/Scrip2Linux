using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ATODET02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ATODET02", "FormName");
		//Fields


        public static WinFormsField AtodetKey0 = new WinFormsField("ATODET-KEY0", "AtodetKey0");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField CgtEndDate = new WinFormsField("CGT-END-DATE", "CgtEndDate");
        public static WinFormsField AtoStatus = new WinFormsField("ATO-STATUS", "AtoStatus");
        public static WinFormsField ReportFormat = new WinFormsField("REPORT-FORMAT", "ReportFormat");
        public static WinFormsField PaydscChangedInd = new WinFormsField("PAYDSC-CHANGED-IND", "PaydscChangedInd");
        public static WinFormsField HolderBillingTot = new WinFormsField("HOLDER-BILLING-TOT", "HolderBillingTot");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
