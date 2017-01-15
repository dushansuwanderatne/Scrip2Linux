using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01020", "FormName");
		//Fields


        public static WinFormsField AutoAddBatchHeader = new WinFormsField("AUTO-ADD-BATCH-HEADER", "AutoAddBatchHeader");
        public static WinFormsField ProcessTfns = new WinFormsField("PROCESS-TFNS", "ProcessTfns");
        public static WinFormsField MultipleQueueInd = new WinFormsField("MULTIPLE-QUEUE-IND", "MultipleQueueInd");
        public static WinFormsField AlternateQueueName = new WinFormsField("ALTERNATE-QUEUE-NAME", "AlternateQueueName");
        public static WinFormsField PreloadNAInd = new WinFormsField("PRELOAD-NA-IND", "PreloadNAInd");
        public static WinFormsField UseSPChessNbrsInd = new WinFormsField("USE-SP-CHESS-NBRS-IND", "UseSPChessNbrsInd");
        public static WinFormsField InternetFloatInd = new WinFormsField("INTERNET-FLOAT-IND", "InternetFloatInd");
        public static WinFormsField InternetAppClass = new WinFormsField("INTERNET-APP-CLASS", "InternetAppClass");
        public static WinFormsField InternetPriotyClass = new WinFormsField("INTERNET-PRIOTY-CLASS", "InternetPriotyClass");
        public static WinFormsField InternetBrokerEntry = new WinFormsField("INTERNET-BROKER-ENTRY", "InternetBrokerEntry");
        public static WinFormsField InternetBrokerClass = new WinFormsField("INTERNET-BROKER-CLASS", "InternetBrokerClass");
        public static WinFormsField InternetAltidEntry = new WinFormsField("INTERNET-ALTID-ENTRY", "InternetAltidEntry");
        public static WinFormsField BrokerRptDailyInd = new WinFormsField("BROKER-RPT-DAILY-IND", "BrokerRptDailyInd");
        public static WinFormsField BrokerListType = new WinFormsField("BROKER-LIST-TYPE", "BrokerListType");
        public static WinFormsField UsingPrereserveInd = new WinFormsField("USING-PRERESERVE-IND", "UsingPrereserveInd");
        public static WinFormsField PrereserveFrom = new WinFormsField("PRERESERVE-FROM", "PrereserveFrom");
        public static WinFormsField PrereserveTO = new WinFormsField("PRERESERVE-TO", "PrereserveTO");
        public static WinFormsField AllocateBroker = new WinFormsField("ALLOCATE-BROKER", "AllocateBroker");
        public static WinFormsField BrokerFrom = new WinFormsField("BROKER-FROM", "BrokerFrom");
        public static WinFormsField BrokerTO = new WinFormsField("BROKER-TO", "BrokerTO");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
