using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCRTLK17

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCRTLK17", "FormName");
		//Fields


        public static WinFormsField MarkingNbr = new WinFormsField("MARKING-NBR", "MarkingNbr");
        public static WinFormsField RBRemainingBalance = new WinFormsField("RB-REMAINING-BALANCE", "RBRemainingBalance");
        public static WinFormsField MarkingDate = new WinFormsField("MARKING-DATE", "MarkingDate");
        public static WinFormsField HldTransferBalance = new WinFormsField("HLD-TRANSFER-BALANCE", "HldTransferBalance");
        public static WinFormsField HolderScripBalance = new WinFormsField("HOLDER-SCRIP-BALANCE", "HolderScripBalance");
        public static WinFormsField ReissueBalance = new WinFormsField("REISSUE-BALANCE", "ReissueBalance");
        public static WinFormsField SellerBroker = new WinFormsField("SELLER-BROKER", "SellerBroker");
        public static WinFormsField STLineNbr = new WinFormsField("ST-LINE-NBR", "STLineNbr");
        public static WinFormsField STQuantity = new WinFormsField("ST-QUANTITY", "STQuantity");
        public static WinFormsField STDenom = new WinFormsField("ST-DENOM", "STDenom");
        public static WinFormsField CFRunNbr = new WinFormsField("CF-RUN-NBR", "CFRunNbr");
        public static WinFormsField CFTransNumber = new WinFormsField("CF-TRANS-NUMBER", "CFTransNumber");
        public static WinFormsField StartCertID = new WinFormsField("START-CERT-ID", "StartCertID");
        public static WinFormsField AutoTransTypeCode = new WinFormsField("AUTO-TRANS-TYPE-CODE", "AutoTransTypeCode");
        public static WinFormsField AutoTransNumber = new WinFormsField("AUTO-TRANS-NUMBER", "AutoTransNumber");
        public static WinFormsField GenerateAutoMrkInd = new WinFormsField("GENERATE-AUTO-MRK-IND", "GenerateAutoMrkInd");
        public static WinFormsField MTLineNbr = new WinFormsField("MT-LINE-NBR", "MTLineNbr");
        public static WinFormsField MTQuantity = new WinFormsField("MT-QUANTITY", "MTQuantity");
        public static WinFormsField MTDenom = new WinFormsField("MT-DENOM", "MTDenom");
        public static WinFormsField OriginalSellingCert = new WinFormsField("ORIGINAL-SELLING-CERT", "OriginalSellingCert");
    }
}
