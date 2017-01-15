using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP08099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP08099", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField PersonA = new WinFormsField("PERSON-A", "PersonA");
        public static WinFormsField TypeA = new WinFormsField("TYPE-A", "TypeA");
        public static WinFormsField SharesA = new WinFormsField("SHARES-A", "SharesA");
        public static WinFormsField PerA = new WinFormsField("PER-A", "PerA");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
