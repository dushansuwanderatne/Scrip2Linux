using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLRRQ1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLRRQ1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField RegistrationRequestStatus = new WinFormsField("REGISTRATION-REQUEST-STATUS", "RegistrationRequestStatus");
        public static WinFormsField AvailableDate = new WinFormsField("AVAILABLE-DATE", "AvailableDate");
    }
}
