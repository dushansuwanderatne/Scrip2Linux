using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01404", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField ReceivingPid = new WinFormsField("RECEIVING-PID", "ReceivingPid");
        public static WinFormsField Pin = new WinFormsField("PIN", "Pin");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField BrokerNonBrokerInd = new WinFormsField("BROKER-NON-BROKER-IND", "BrokerNonBrokerInd");
        public static WinFormsField LocationOFReg = new WinFormsField("LOCATION-OF-REG", "LocationOFReg");
        public static WinFormsField SholderRefNumber = new WinFormsField("SHOLDER-REF-NUMBER", "SholderRefNumber");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField OverideMovement = new WinFormsField("OVERIDE-MOVEMENT", "OverideMovement");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
