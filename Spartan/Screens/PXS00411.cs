using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00411

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00411", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField NomPersonType = new WinFormsField("NOM-PERSON-TYPE", "NomPersonType");
        public static WinFormsField PrintHolderID = new WinFormsField("PRINT-HOLDER-ID", "PrintHolderID");
        public static WinFormsField OutputFilename = new WinFormsField("OUTPUT-FILENAME", "OutputFilename");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
