using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00213

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00213", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField ResolutionNum = new WinFormsField("RESOLUTION-NUM", "ResolutionNum");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField LongDesc = new WinFormsField("LONG-DESC", "LongDesc");
        public static WinFormsField VotingFrmDesc = new WinFormsField("VOTING-FRM-DESC", "VotingFrmDesc");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField GroupColour1 = new WinFormsField("GROUP-COLOUR-1", "GroupColour1");
        public static WinFormsField GroupColour2 = new WinFormsField("GROUP-COLOUR-2", "GroupColour2");
        public static WinFormsField GroupColour3 = new WinFormsField("GROUP-COLOUR-3", "GroupColour3");
        public static WinFormsField GroupColour4 = new WinFormsField("GROUP-COLOUR-4", "GroupColour4");
        public static WinFormsField GroupColour5 = new WinFormsField("GROUP-COLOUR-5", "GroupColour5");
        public static WinFormsField GroupColour6 = new WinFormsField("GROUP-COLOUR-6", "GroupColour6");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
