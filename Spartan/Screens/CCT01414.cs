using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01414

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01414", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField FullTransactionID = new WinFormsField("FULL-TRANSACTION-ID", "FullTransactionID");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField BrokerNonBrokerInd = new WinFormsField("BROKER-NON-BROKER-IND", "BrokerNonBrokerInd");
        public static WinFormsField DeliveringHin = new WinFormsField("DELIVERING-HIN", "DeliveringHin");
        public static WinFormsField DeliveringPid = new WinFormsField("DELIVERING-PID", "DeliveringPid");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField LocationOFReg = new WinFormsField("LOCATION-OF-REG", "LocationOFReg");
        public static WinFormsField SholderRefNumber = new WinFormsField("SHOLDER-REF-NUMBER", "SholderRefNumber");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField OverideMovement = new WinFormsField("OVERIDE-MOVEMENT", "OverideMovement");
        public static WinFormsField TaxFileNumber1 = new WinFormsField("TAX-FILE-NUMBER-1", "TaxFileNumber1");
        public static WinFormsField TaxFileNumber2 = new WinFormsField("TAX-FILE-NUMBER-2", "TaxFileNumber2");
        public static WinFormsField TaxFileNumber3 = new WinFormsField("TAX-FILE-NUMBER-3", "TaxFileNumber3");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
