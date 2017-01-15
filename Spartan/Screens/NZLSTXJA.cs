using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLSTXJA

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLSTXJA", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MarkingFlag = new WinFormsField("MARKING-FLAG", "MarkingFlag");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField Quantity = new WinFormsField("QUANTITY", "Quantity");
        public static WinFormsField LineCount = new WinFormsField("LINE-COUNT", "LineCount");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField HolderOrigin = new WinFormsField("HOLDER-ORIGIN", "HolderOrigin");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField TransferQuantity = new WinFormsField("TRANSFER-QUANTITY", "TransferQuantity");
        public static WinFormsField BrokerReference = new WinFormsField("BROKER-REFERENCE", "BrokerReference");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField ReissueBalance = new WinFormsField("REISSUE-BALANCE", "ReissueBalance");
        public static WinFormsField ReissueInstruction = new WinFormsField("REISSUE-INSTRUCTION", "ReissueInstruction");
        public static WinFormsField ExceptionFlag = new WinFormsField("EXCEPTION-FLAG", "ExceptionFlag");
        public static WinFormsField DuplicateFlag = new WinFormsField("DUPLICATE-FLAG", "DuplicateFlag");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField ContinuationMarker = new WinFormsField("CONTINUATION-MARKER", "ContinuationMarker");
        public static WinFormsField Currency = new WinFormsField("CURRENCY", "Currency");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
