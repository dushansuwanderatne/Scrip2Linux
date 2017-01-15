using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSOFTP1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSOFTP1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField TransferSequenceNbr = new WinFormsField("TRANSFER-SEQUENCE-NBR", "TransferSequenceNbr");
        public static WinFormsField SuccessItems = new WinFormsField("SUCCESS-ITEMS", "SuccessItems");
        public static WinFormsField InvalidItems = new WinFormsField("INVALID-ITEMS", "InvalidItems");
        public static WinFormsField UnsuccessfulItems = new WinFormsField("UNSUCCESSFUL-ITEMS", "UnsuccessfulItems");
        public static WinFormsField Timestamp = new WinFormsField("TIMESTAMP", "Timestamp");
    }
}
