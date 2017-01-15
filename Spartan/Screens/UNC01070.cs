using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UNC01070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UNC01070", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CNSelcls1 = new WinFormsField("CN-SELCLS-1", "CNSelcls1");
        public static WinFormsField CNSelcls2 = new WinFormsField("CN-SELCLS-2", "CNSelcls2");
        public static WinFormsField CNSelcls3 = new WinFormsField("CN-SELCLS-3", "CNSelcls3");
        public static WinFormsField CNSelcls4 = new WinFormsField("CN-SELCLS-4", "CNSelcls4");
        public static WinFormsField CNSelcls5 = new WinFormsField("CN-SELCLS-5", "CNSelcls5");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
