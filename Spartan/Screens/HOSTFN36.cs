using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN36

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN36", "FormName");
		//Fields


        public static WinFormsField Frequency = new WinFormsField("FREQUENCY", "Frequency");
        public static WinFormsField DayOFMonth = new WinFormsField("DAY-OF-MONTH", "DayOFMonth");
        public static WinFormsField DowYN = new WinFormsField("DOW-YN", "DowYN");
        public static WinFormsField JobFilename = new WinFormsField("JOB-FILENAME", "JobFilename");
        public static WinFormsField OrderID = new WinFormsField("ORDER-ID", "OrderID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
