using Spartan.Core.WinForms.WinFormsObjects;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01070
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS01070", "FormName");
        //Fields
        public static WinFormsField FormatDesc = new WinFormsField("FORMAT-DESC", "FormatDesc");
        public static WinFormsField PriceMethod = new WinFormsField("PRICE-METHOD", "PriceMethod");
        public static WinFormsField ClassA = new WinFormsField("CLASS-A", "ClassA");
        public static WinFormsField ClassPriceA = new WinFormsField("CLASS-PRICE-A", "ClassPriceA");
        public static WinFormsField ClassB = new WinFormsField("CLASS-B", "ClassB");
        public static WinFormsField ClassPriceB = new WinFormsField("CLASS-PRICE-B", "ClassPriceB");
        public static WinFormsField MethodConfirm = new WinFormsField("METHOD-CONFIRM", "MethodConfirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
