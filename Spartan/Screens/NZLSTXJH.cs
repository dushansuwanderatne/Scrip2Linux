using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZLSTXJH

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZLSTXJH", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SellBrokerCode = new WinFormsField("SELL-BROKER-CODE", "SellBrokerCode");
        public static WinFormsField BuyBrokerCode = new WinFormsField("BUY-BROKER-CODE", "BuyBrokerCode");
        public static WinFormsField NzseReference = new WinFormsField("NZSE-REFERENCE", "NzseReference");
        public static WinFormsField TransferQuantity = new WinFormsField("TRANSFER-QUANTITY", "TransferQuantity");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField DuplicateFlag = new WinFormsField("DUPLICATE-FLAG", "DuplicateFlag");
        public static WinFormsField HoldFlag = new WinFormsField("HOLD-FLAG", "HoldFlag");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
