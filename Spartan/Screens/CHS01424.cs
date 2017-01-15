using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS01424

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS01424", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField DeliveringHin = new WinFormsField("DELIVERING-HIN", "DeliveringHin");
        public static WinFormsField DeliveringPid = new WinFormsField("DELIVERING-PID", "DeliveringPid");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField ReceivingPid = new WinFormsField("RECEIVING-PID", "ReceivingPid");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField CorporateAction1 = new WinFormsField("CORPORATE-ACTION-1", "CorporateAction1");
        public static WinFormsField OverideBMovement1 = new WinFormsField("OVERIDE-B-MOVEMENT-1", "OverideBMovement1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
