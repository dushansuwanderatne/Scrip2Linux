using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDCSD11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDCSD11", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField SubType = new WinFormsField("SUB-TYPE", "SubType");
        public static WinFormsField HldcsdKey0 = new WinFormsField("HLDCSD-KEY0", "HldcsdKey0");
        public static WinFormsField ZafTaxCode = new WinFormsField("ZAF-TAX-CODE", "ZafTaxCode");
        public static WinFormsField ZafCustodianRef = new WinFormsField("ZAF-CUSTODIAN-REF", "ZafCustodianRef");
        public static WinFormsField ZafIntermediaryInd = new WinFormsField("ZAF-INTERMEDIARY-IND", "ZafIntermediaryInd");
        public static WinFormsField ZafOtherStatus = new WinFormsField("ZAF-OTHER-STATUS", "ZafOtherStatus");
        public static WinFormsField ZafTradingName = new WinFormsField("ZAF-TRADING-NAME", "ZafTradingName");
    }
}
