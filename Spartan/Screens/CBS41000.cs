using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS41000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS41000", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField TransferNbr = new WinFormsField("TRANSFER-NBR", "TransferNbr");
        public static WinFormsField Seq = new WinFormsField("SEQ", "Seq");
        //public static WinFormsField TransferNbr = new WinFormsField("TRANSFER-NBR", "TransferNbr");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField DisplayDesc = new WinFormsField("DISPLAY-DESC", "DisplayDesc");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField ParticipantName = new WinFormsField("PARTICIPANT-NAME", "ParticipantName");
        public static WinFormsField RefNbr = new WinFormsField("REF-NBR", "RefNbr");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField Ind = new WinFormsField("IND", "Ind");
        public static WinFormsField ShareholderNbr = new WinFormsField("SHAREHOLDER-NBR", "ShareholderNbr");
        public static WinFormsField CertsYN = new WinFormsField("CERTS-YN", "CertsYN");
        public static WinFormsField TransferCerts = new WinFormsField("TRANSFER-CERTS", "TransferCerts");
        public static WinFormsField CertificateID = new WinFormsField("CERTIFICATE-ID", "CertificateID");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField First = new WinFormsField("1ST", "1st");
        //public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Delete = new WinFormsField("DELETE", "Delete");
    }
}
