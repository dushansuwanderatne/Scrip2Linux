using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS01402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS01402", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField CertificateNum = new WinFormsField("CERTIFICATE-NUM", "CertificateNum");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField ReceivingPid = new WinFormsField("RECEIVING-PID", "ReceivingPid");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField NominatedReg = new WinFormsField("NOMINATED-REG", "NominatedReg");
        public static WinFormsField SholderRefNumber = new WinFormsField("SHOLDER-REF-NUMBER", "SholderRefNumber");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField CorporateAction1 = new WinFormsField("CORPORATE-ACTION-1", "CorporateAction1");
        public static WinFormsField OverideBMovement1 = new WinFormsField("OVERIDE-B-MOVEMENT-1", "OverideBMovement1");
        public static WinFormsField RegDetails = new WinFormsField("REG-DETAILS", "RegDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
