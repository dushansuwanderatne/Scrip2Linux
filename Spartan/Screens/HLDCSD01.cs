using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDCSD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDCSD01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField SubType = new WinFormsField("SUB-TYPE", "SubType");
        public static WinFormsField IrlTaxCode = new WinFormsField("IRL-TAX-CODE", "IrlTaxCode");
        public static WinFormsField IrlCustodianRef = new WinFormsField("IRL-CUSTODIAN-REF", "IrlCustodianRef");
        public static WinFormsField IrlIntermediaryInd = new WinFormsField("IRL-INTERMEDIARY-IND", "IrlIntermediaryInd");
        public static WinFormsField IrlOtherStatus = new WinFormsField("IRL-OTHER-STATUS", "IrlOtherStatus");
        public static WinFormsField HldcsdKey0 = new WinFormsField("HLDCSD-KEY0", "HldcsdKey0");
        public static WinFormsField IrlMailAddrLine = new WinFormsField("IRL-MAIL-ADDR-LINE", "IrlMailAddrLine");
        public static WinFormsField IrlMailAddrPC = new WinFormsField("IRL-MAIL-ADDR-PC", "IrlMailAddrPC");
    }
}
