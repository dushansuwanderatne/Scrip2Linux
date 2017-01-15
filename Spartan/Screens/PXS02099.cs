using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02099", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField PersonA = new WinFormsField("PERSON-A", "PersonA");
        public static WinFormsField TypeA = new WinFormsField("TYPE-A", "TypeA");
        public static WinFormsField PerA = new WinFormsField("PER-A", "PerA");
        public static WinFormsField SharesA = new WinFormsField("SHARES-A", "SharesA");
        public static WinFormsField Nomb = new WinFormsField("NOMB", "Nomb");
        public static WinFormsField PersonB = new WinFormsField("PERSON-B", "PersonB");
        public static WinFormsField PerB = new WinFormsField("PER-B", "PerB");
        public static WinFormsField SharesB = new WinFormsField("SHARES-B", "SharesB");
        public static WinFormsField FailingA = new WinFormsField("FAILING-A", "FailingA");
        public static WinFormsField FailDesc = new WinFormsField("FAIL-DESC", "FailDesc");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
