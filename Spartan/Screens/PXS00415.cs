using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00415

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00415", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
        public static WinFormsField ResolutionNO1to20 = new WinFormsField("RESOLUTION-NO-1TO20", "ResolutionNO1to20");
        public static WinFormsField ResolutionNO21to40 = new WinFormsField("RESOLUTION-NO-21TO40", "ResolutionNO21to40");
        public static WinFormsField ResolutionNO41to60 = new WinFormsField("RESOLUTION-NO-41TO60", "ResolutionNO41to60");
        public static WinFormsField ResolutionNO61to80 = new WinFormsField("RESOLUTION-NO-61TO80", "ResolutionNO61to80");
        public static WinFormsField ResolutionNO81to99 = new WinFormsField("RESOLUTION-NO-81TO99", "ResolutionNO81to99");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField OutputFilename = new WinFormsField("OUTPUT-FILENAME", "OutputFilename");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
