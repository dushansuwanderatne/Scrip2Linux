using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkNumber = new WinFormsField("BULK-NUMBER", "BulkNumber");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField AgentCode = new WinFormsField("AGENT-CODE", "AgentCode");
        public static WinFormsField RequiredUnits = new WinFormsField("REQUIRED-UNITS", "RequiredUnits");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField BrokerReference = new WinFormsField("BROKER-REFERENCE", "BrokerReference");
        public static WinFormsField SplitNumber1 = new WinFormsField("SPLIT-NUMBER-1", "SplitNumber1");
        public static WinFormsField SplitUnits1 = new WinFormsField("SPLIT-UNITS-1", "SplitUnits1");
        public static WinFormsField SplitNumber2 = new WinFormsField("SPLIT-NUMBER-2", "SplitNumber2");
        public static WinFormsField SplitUnits2 = new WinFormsField("SPLIT-UNITS-2", "SplitUnits2");
        public static WinFormsField SplitNumber3 = new WinFormsField("SPLIT-NUMBER-3", "SplitNumber3");
        public static WinFormsField SplitUnits3 = new WinFormsField("SPLIT-UNITS-3", "SplitUnits3");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
