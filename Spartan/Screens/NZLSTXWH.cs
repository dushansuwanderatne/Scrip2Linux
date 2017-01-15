using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLSTXWH

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLSTXWH", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ServiceID = new WinFormsField("SERVICE-ID", "ServiceID");
        public static WinFormsField HolderOrigin = new WinFormsField("HOLDER-ORIGIN", "HolderOrigin");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField ParticCode = new WinFormsField("PARTIC-CODE", "ParticCode");
        public static WinFormsField EnquiryDate = new WinFormsField("ENQUIRY-DATE", "EnquiryDate");
        public static WinFormsField TransferType = new WinFormsField("TRANSFER-TYPE", "TransferType");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
