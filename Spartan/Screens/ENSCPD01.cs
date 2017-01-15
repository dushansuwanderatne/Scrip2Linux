using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSCPD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSCPD01", "FormName");
		//Fields


        public static WinFormsField RunHeldOver = new WinFormsField("RUN-HELD-OVER", "RunHeldOver");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField DocumentType = new WinFormsField("DOCUMENT-TYPE", "DocumentType");
        public static WinFormsField PendingReason = new WinFormsField("PENDING-REASON", "PendingReason");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RunNspSent = new WinFormsField("RUN-NSP-SENT", "RunNspSent");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SrchRunHeld = new WinFormsField("SRCH-RUN-HELD", "SrchRunHeld");
        public static WinFormsField SrchHolderID = new WinFormsField("SRCH-HOLDER-ID", "SrchHolderID");
        public static WinFormsField SrchStatus = new WinFormsField("SRCH-STATUS", "SrchStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
