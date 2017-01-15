using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS02002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS02002", "FormName");
		//Fields
        public static WinFormsField DualCQPresented = new WinFormsField("DUAL-CQ-PRESENTED", "DualCQPresented");
        public static WinFormsField DualRIPresented = new WinFormsField("DUAL-RI-PRESENTED", "DualRIPresented");
        public static WinFormsField DualDCPresented = new WinFormsField("DUAL-DC-PRESENTED", "DualDCPresented");
        public static WinFormsField TotalDualPresented = new WinFormsField("TOTAL-DUAL-PRESENTED", "TotalDualPresented");
        public static WinFormsField DualCQUnpresented = new WinFormsField("DUAL-CQ-UNPRESENTED", "DualCQUnpresented");
        public static WinFormsField DualRIUnpresented = new WinFormsField("DUAL-RI-UNPRESENTED", "DualRIUnpresented");
        public static WinFormsField DualDCUnpresented = new WinFormsField("DUAL-DC-UNPRESENTED", "DualDCUnpresented");
        public static WinFormsField TotalDualUnpres = new WinFormsField("TOTAL-DUAL-UNPRES", "TotalDualUnpres");
        public static WinFormsField DualCQUnissued = new WinFormsField("DUAL-CQ-UNISSUED", "DualCQUnissued");
        public static WinFormsField DualRIUnissued = new WinFormsField("DUAL-RI-UNISSUED", "DualRIUnissued");
        public static WinFormsField DualDCUnissued = new WinFormsField("DUAL-DC-UNISSUED", "DualDCUnissued");
        public static WinFormsField TotalDualUnissued = new WinFormsField("TOTAL-DUAL-UNISSUED", "TotalDualUnissued");
        public static WinFormsField DualCQFailed = new WinFormsField("DUAL-CQ-FAILED", "DualCQFailed");
        public static WinFormsField DualRIFailed = new WinFormsField("DUAL-RI-FAILED", "DualRIFailed");
        public static WinFormsField DualDCFailed = new WinFormsField("DUAL-DC-FAILED", "DualDCFailed");
        public static WinFormsField TotalDualFailed = new WinFormsField("TOTAL-DUAL-FAILED", "TotalDualFailed");
        public static WinFormsField DualCQCancelled = new WinFormsField("DUAL-CQ-CANCELLED", "DualCQCancelled");
        public static WinFormsField DualRICancelled = new WinFormsField("DUAL-RI-CANCELLED", "DualRICancelled");
        public static WinFormsField DualDCCancelled = new WinFormsField("DUAL-DC-CANCELLED", "DualDCCancelled");
        public static WinFormsField TotalDualCancelled = new WinFormsField("TOTAL-DUAL-CANCELLED", "TotalDualCancelled");
        public static WinFormsField DualCQReturned = new WinFormsField("DUAL-CQ-RETURNED", "DualCQReturned");
        public static WinFormsField DualRIReturned = new WinFormsField("DUAL-RI-RETURNED", "DualRIReturned");
        public static WinFormsField DualDCReturned = new WinFormsField("DUAL-DC-RETURNED", "DualDCReturned");
        public static WinFormsField TotalDualReturned = new WinFormsField("TOTAL-DUAL-RETURNED", "TotalDualReturned");
        public static WinFormsField DualCQDestroyed = new WinFormsField("DUAL-CQ-DESTROYED", "DualCQDestroyed");
        public static WinFormsField DualRIDestroyed = new WinFormsField("DUAL-RI-DESTROYED", "DualRIDestroyed");
        public static WinFormsField DualDCDestroyed = new WinFormsField("DUAL-DC-DESTROYED", "DualDCDestroyed");
        public static WinFormsField TotalDualDestroyed = new WinFormsField("TOTAL-DUAL-DESTROYED", "TotalDualDestroyed");
        public static WinFormsField DualFCUnpresented = new WinFormsField("DUAL-FC-UNPRESENTED", "DualFCUnpresented");
        public static WinFormsField DualFCPresented = new WinFormsField("DUAL-FC-PRESENTED", "DualFCPresented");
        public static WinFormsField DualFCReturned = new WinFormsField("DUAL-FC-RETURNED", "DualFCReturned");
        public static WinFormsField DualFCDestroyed = new WinFormsField("DUAL-FC-DESTROYED", "DualFCDestroyed");
        public static WinFormsField DualFCUnissued = new WinFormsField("DUAL-FC-UNISSUED", "DualFCUnissued");
        public static WinFormsField DualFCCancelled = new WinFormsField("DUAL-FC-CANCELLED", "DualFCCancelled");
        public static WinFormsField DualFCFailed = new WinFormsField("DUAL-FC-FAILED", "DualFCFailed");
    }
}
