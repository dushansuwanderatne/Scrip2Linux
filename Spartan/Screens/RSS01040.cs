using Spartan.Core.WinForms.WinFormsObjects;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01040
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS01040", "FormName");
        //Fields
        public static WinFormsField FormatDesc = new WinFormsField("FORMAT-DESC", "FormatDesc");
        public static WinFormsField Runits18From = new WinFormsField("RUNITS1-8-FROM", "Runits18From");
        public static WinFormsField Runits18TO = new WinFormsField("RUNITS1-8-TO", "Runits18TO");
        public static WinFormsField Runits916From = new WinFormsField("RUNITS9-16-FROM", "Runits916From");
        public static WinFormsField Runits916TO = new WinFormsField("RUNITS9-16-TO", "Runits916TO");
        public static WinFormsField UseClassPrice = new WinFormsField("USE-CLASS-PRICE", "UseClassPrice");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
