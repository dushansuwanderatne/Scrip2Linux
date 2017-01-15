using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS01407

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS01407", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField TargetTransactionID = new WinFormsField("TARGET-TRANSACTION-ID", "TargetTransactionID");
        public static WinFormsField ParticipantRef = new WinFormsField("PARTICIPANT-REF", "ParticipantRef");
        public static WinFormsField RejectedMovementRes = new WinFormsField("REJECTED-MOVEMENT-RES", "RejectedMovementRes");
    }
}
