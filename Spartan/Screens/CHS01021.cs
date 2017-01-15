using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS01021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TempUic = new WinFormsField("TEMP-UIC", "TempUic");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField ParticipantRef = new WinFormsField("PARTICIPANT-REF", "ParticipantRef");
        public static WinFormsField SupplementaryRef = new WinFormsField("SUPPLEMENTARY-REF", "SupplementaryRef");
        public static WinFormsField SholderRefNumber = new WinFormsField("SHOLDER-REF-NUMBER", "SholderRefNumber");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField OverideBMove = new WinFormsField("OVERIDE-B-MOVE", "OverideBMove");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField CertificateNum = new WinFormsField("CERTIFICATE-NUM", "CertificateNum");
        public static WinFormsField LocationOFReg = new WinFormsField("LOCATION-OF-REG", "LocationOFReg");
        public static WinFormsField AmountB = new WinFormsField("AMOUNT-B", "AmountB");
        public static WinFormsField TransBasis = new WinFormsField("TRANS-BASIS", "TransBasis");
        public static WinFormsField ReducingHldBal = new WinFormsField("REDUCING-HLD-BAL", "ReducingHldBal");
        public static WinFormsField BalanceInstruction = new WinFormsField("BALANCE-INSTRUCTION", "BalanceInstruction");
        public static WinFormsField AmountC = new WinFormsField("AMOUNT-C", "AmountC");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField ReferenceB = new WinFormsField("REFERENCE-B", "ReferenceB");
        public static WinFormsField DutyType = new WinFormsField("DUTY-TYPE", "DutyType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
