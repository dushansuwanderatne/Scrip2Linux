using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLSTXJF

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLSTXJF", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField TransferQuantity = new WinFormsField("TRANSFER-QUANTITY", "TransferQuantity");
        public static WinFormsField BrokerReference = new WinFormsField("BROKER-REFERENCE", "BrokerReference");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField HolderOrigin = new WinFormsField("HOLDER-ORIGIN", "HolderOrigin");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField DuplicateFlag = new WinFormsField("DUPLICATE-FLAG", "DuplicateFlag");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
