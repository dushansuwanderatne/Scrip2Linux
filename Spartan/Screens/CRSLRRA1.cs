using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLRRA1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLRRA1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField TransactionID = new WinFormsField("TRANSACTION-ID", "TransactionID");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField RegistrationRequestDropNum = new WinFormsField("REGISTRATION-REQUEST-DROP-NUM", "RegistrationRequestDropNum");
        public static WinFormsField RegisteredDate = new WinFormsField("REGISTERED-DATE", "RegisteredDate");
        public static WinFormsField RegisteredTime = new WinFormsField("REGISTERED-TIME", "RegisteredTime");
        public static WinFormsField DeliveryReason = new WinFormsField("DELIVERY-REASON", "DeliveryReason");
    }
}
