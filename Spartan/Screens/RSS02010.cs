using Spartan.Core.WinForms.WinFormsObjects;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS02010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS02010", "FormName");
        //Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField Preload = new WinFormsField("PRELOAD", "Preload");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
