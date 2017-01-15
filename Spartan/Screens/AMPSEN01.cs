using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AMPSEN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AMPSEN01", "FormName");
		//Fields


        public static WinFormsField EntitlementNumber = new WinFormsField("ENTITLEMENT-NUMBER", "EntitlementNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField NumberShares = new WinFormsField("NUMBER-SHARES", "NumberShares");
        public static WinFormsField TrustFlag = new WinFormsField("TRUST-FLAG", "TrustFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
