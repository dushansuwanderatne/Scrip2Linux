using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10027

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10027", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Variable Flag 1", "VariableFlag1");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2. Variable Flag 2", "VariableFlag2");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3. Variable Flag 3", "VariableFlag3");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4. Variable Flag 4", "VariableFlag4");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5. Variable Flag 5", "VariableFlag5");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6. Annual Report", "AnnualReport");
        public static WinFormsField MenuItem7 = new WinFormsField("MENU-ITEM-7", "7. Exception Flag", "ExceptionFlag");
        public static WinFormsField MenuItem8 = new WinFormsField("MENU-ITEM-8", "8. Alternate ID", "AlternateID");
        public static WinFormsField MenuItem9 = new WinFormsField("MENU-ITEM-9", "9. Variable Fields", "VariableFields");
        public static WinFormsField MenuItem10 = new WinFormsField("MENU-ITEM-10", "10. Holder Group Code", "HolderGroupCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Flags = new WinFormsField("FLAGS", "Flags");
        public static WinFormsField SecondFlag = new WinFormsField("SECOND-FLAG", "SecondFlag");
        public static WinFormsField SeparatePrintFiles = new WinFormsField("SEPARATE-PRINT-FILES", "SeparatePrintFiles");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
