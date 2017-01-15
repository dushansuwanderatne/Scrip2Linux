using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS41090

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS41090", "FormName");
		//Fields


        public static WinFormsField ParticipantName = new WinFormsField("PARTICIPANT-NAME", "ParticipantName");
        public static WinFormsField HolderNad = new WinFormsField("HOLDER-NAD", "HolderNad");
        public static WinFormsField DisplayDesc = new WinFormsField("DISPLAY-DESC", "DisplayDesc");
        public static WinFormsField TransferCerts = new WinFormsField("TRANSFER-CERTS", "TransferCerts");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField CertUnits = new WinFormsField("CERT-UNITS", "CertUnits");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
