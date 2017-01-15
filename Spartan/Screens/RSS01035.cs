using Spartan.Core.WinForms.WinFormsObjects;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01035
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS01035", "FormName");
        //Fields
        public static WinFormsField FormatDesc = new WinFormsField("FORMAT-DESC", "FormatDesc");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField Cat = new WinFormsField("CAT", "Cat");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
