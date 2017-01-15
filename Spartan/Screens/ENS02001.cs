using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS02001", "FormName");
		//Fields
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField LowRefNbr = new WinFormsField("LOW-REF-NBR", "LowRefNbr");
        public static WinFormsField HighRefNbr = new WinFormsField("HIGH-REF-NBR", "HighRefNbr");
        public static WinFormsField NbrCQPresented = new WinFormsField("NBR-CQ-PRESENTED", "NbrCQPresented");
        public static WinFormsField NbrRIPresented = new WinFormsField("NBR-RI-PRESENTED", "NbrRIPresented");
        public static WinFormsField NbrDCPresented = new WinFormsField("NBR-DC-PRESENTED", "NbrDCPresented");
        public static WinFormsField TotalNbrPresented = new WinFormsField("TOTAL-NBR-PRESENTED", "TotalNbrPresented");
        public static WinFormsField NbrCQUnpresented = new WinFormsField("NBR-CQ-UNPRESENTED", "NbrCQUnpresented");
        public static WinFormsField NbrRIUnpresented = new WinFormsField("NBR-RI-UNPRESENTED", "NbrRIUnpresented");
        public static WinFormsField NbrDCUnpresented = new WinFormsField("NBR-DC-UNPRESENTED", "NbrDCUnpresented");
        public static WinFormsField TotalNbrUnpresented = new WinFormsField("TOTAL-NBR-UNPRESENTED", "TotalNbrUnpresented");
        public static WinFormsField NbrCQUnissued = new WinFormsField("NBR-CQ-UNISSUED", "NbrCQUnissued");
        public static WinFormsField NbrRIUnissued = new WinFormsField("NBR-RI-UNISSUED", "NbrRIUnissued");
        public static WinFormsField NbrDCUnissued = new WinFormsField("NBR-DC-UNISSUED", "NbrDCUnissued");
        public static WinFormsField TotalNbrUnissued = new WinFormsField("TOTAL-NBR-UNISSUED", "TotalNbrUnissued");
        public static WinFormsField NbrCQFailed = new WinFormsField("NBR-CQ-FAILED", "NbrCQFailed");
        public static WinFormsField NbrRIFailed = new WinFormsField("NBR-RI-FAILED", "NbrRIFailed");
        public static WinFormsField NbrDCFailed = new WinFormsField("NBR-DC-FAILED", "NbrDCFailed");
        public static WinFormsField TotalNbrFailed = new WinFormsField("TOTAL-NBR-FAILED", "TotalNbrFailed");
        public static WinFormsField NbrCQCancelled = new WinFormsField("NBR-CQ-CANCELLED", "NbrCQCancelled");
        public static WinFormsField NbrRICancelled = new WinFormsField("NBR-RI-CANCELLED", "NbrRICancelled");
        public static WinFormsField NbrDCCancelled = new WinFormsField("NBR-DC-CANCELLED", "NbrDCCancelled");
        public static WinFormsField TotalNbrCancelled = new WinFormsField("TOTAL-NBR-CANCELLED", "TotalNbrCancelled");
        public static WinFormsField NettCQPresented = new WinFormsField("NETT-CQ-PRESENTED", "NettCQPresented");
        public static WinFormsField NettRIPresented = new WinFormsField("NETT-RI-PRESENTED", "NettRIPresented");
        public static WinFormsField NettDCPresented = new WinFormsField("NETT-DC-PRESENTED", "NettDCPresented");
        public static WinFormsField TotalNettPresented = new WinFormsField("TOTAL-NETT-PRESENTED", "TotalNettPresented");
        public static WinFormsField NettCQUnpresented = new WinFormsField("NETT-CQ-UNPRESENTED", "NettCQUnpresented");
        public static WinFormsField NettRIUnpresented = new WinFormsField("NETT-RI-UNPRESENTED", "NettRIUnpresented");
        public static WinFormsField NettDCUnpresented = new WinFormsField("NETT-DC-UNPRESENTED", "NettDCUnpresented");
        public static WinFormsField TotalNettUnpres = new WinFormsField("TOTAL-NETT-UNPRES", "TotalNettUnpres");
        public static WinFormsField NettCQUnissued = new WinFormsField("NETT-CQ-UNISSUED", "NettCQUnissued");
        public static WinFormsField NettRIUnissued = new WinFormsField("NETT-RI-UNISSUED", "NettRIUnissued");
        public static WinFormsField NettDCUnissued = new WinFormsField("NETT-DC-UNISSUED", "NettDCUnissued");
        public static WinFormsField TotalNettUnissued = new WinFormsField("TOTAL-NETT-UNISSUED", "TotalNettUnissued");
        public static WinFormsField NettCQFailed = new WinFormsField("NETT-CQ-FAILED", "NettCQFailed");
        public static WinFormsField NettRIFailed = new WinFormsField("NETT-RI-FAILED", "NettRIFailed");
        public static WinFormsField NettDCFailed = new WinFormsField("NETT-DC-FAILED", "NettDCFailed");
        public static WinFormsField TotalNettFailed = new WinFormsField("TOTAL-NETT-FAILED", "TotalNettFailed");
        public static WinFormsField NettCQCancelled = new WinFormsField("NETT-CQ-CANCELLED", "NettCQCancelled");
        public static WinFormsField NettRICancelled = new WinFormsField("NETT-RI-CANCELLED", "NettRICancelled");
        public static WinFormsField NettDCCancelled = new WinFormsField("NETT-DC-CANCELLED", "NettDCCancelled");
        public static WinFormsField TotalNettCancelled = new WinFormsField("TOTAL-NETT-CANCELLED", "TotalNettCancelled");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField NbrCQDestroyed = new WinFormsField("NBR-CQ-DESTROYED", "NbrCQDestroyed");
        public static WinFormsField NbrRIDestroyed = new WinFormsField("NBR-RI-DESTROYED", "NbrRIDestroyed");
        public static WinFormsField NbrDCDestroyed = new WinFormsField("NBR-DC-DESTROYED", "NbrDCDestroyed");
        public static WinFormsField TotalNbrDestroyed = new WinFormsField("TOTAL-NBR-DESTROYED", "TotalNbrDestroyed");
        public static WinFormsField NbrCQReturned = new WinFormsField("NBR-CQ-RETURNED", "NbrCQReturned");
        public static WinFormsField NbrRIReturned = new WinFormsField("NBR-RI-RETURNED", "NbrRIReturned");
        public static WinFormsField NbrDCReturned = new WinFormsField("NBR-DC-RETURNED", "NbrDCReturned");
        public static WinFormsField TotalNbrReturned = new WinFormsField("TOTAL-NBR-RETURNED", "TotalNbrReturned");
        public static WinFormsField NettCQReturned = new WinFormsField("NETT-CQ-RETURNED", "NettCQReturned");
        public static WinFormsField NettRIReturned = new WinFormsField("NETT-RI-RETURNED", "NettRIReturned");
        public static WinFormsField NettDCReturned = new WinFormsField("NETT-DC-RETURNED", "NettDCReturned");
        public static WinFormsField TotalNettReturned = new WinFormsField("TOTAL-NETT-RETURNED", "TotalNettReturned");
        public static WinFormsField NettCQDestroyed = new WinFormsField("NETT-CQ-DESTROYED", "NettCQDestroyed");
        public static WinFormsField NettRIDestroyed = new WinFormsField("NETT-RI-DESTROYED", "NettRIDestroyed");
        public static WinFormsField NettDCDestroyed = new WinFormsField("NETT-DC-DESTROYED", "NettDCDestroyed");
        public static WinFormsField TotalNettDestroyed = new WinFormsField("TOTAL-NETT-DESTROYED", "TotalNettDestroyed");
        public static WinFormsField NbrFCPresented = new WinFormsField("NBR-FC-PRESENTED", "NbrFCPresented");
        public static WinFormsField NbrFCUnpresented = new WinFormsField("NBR-FC-UNPRESENTED", "NbrFCUnpresented");
        public static WinFormsField NbrFCReturned = new WinFormsField("NBR-FC-RETURNED", "NbrFCReturned");
        public static WinFormsField NbrFCDestroyed = new WinFormsField("NBR-FC-DESTROYED", "NbrFCDestroyed");
        public static WinFormsField NbrFCUnissued = new WinFormsField("NBR-FC-UNISSUED", "NbrFCUnissued");
        public static WinFormsField NbrFCFailed = new WinFormsField("NBR-FC-FAILED", "NbrFCFailed");
        public static WinFormsField NbrFCCancelled = new WinFormsField("NBR-FC-CANCELLED", "NbrFCCancelled");
        public static WinFormsField NettFCPresented = new WinFormsField("NETT-FC-PRESENTED", "NettFCPresented");
        public static WinFormsField NettFCUnpresented = new WinFormsField("NETT-FC-UNPRESENTED", "NettFCUnpresented");
        public static WinFormsField NettFCCancelled = new WinFormsField("NETT-FC-CANCELLED", "NettFCCancelled");
        public static WinFormsField NettFCFailed = new WinFormsField("NETT-FC-FAILED", "NettFCFailed");
        public static WinFormsField NettFCUnissued = new WinFormsField("NETT-FC-UNISSUED", "NettFCUnissued");
        public static WinFormsField NettFCDestroyed = new WinFormsField("NETT-FC-DESTROYED", "NettFCDestroyed");
        public static WinFormsField NettFCReturned = new WinFormsField("NETT-FC-RETURNED", "NettFCReturned");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
