using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00201", "FormName");
		//Fields


        public static WinFormsField RunDate1Input = new WinFormsField("RUN-DATE1-INPUT", "RunDate1Input");
        public static WinFormsField RunDate2Input = new WinFormsField("RUN-DATE2-INPUT", "RunDate2Input");
        public static WinFormsField RunDate3Input = new WinFormsField("RUN-DATE3-INPUT", "RunDate3Input");
        public static WinFormsField PasswordInput = new WinFormsField("PASSWORD-INPUT", "PasswordInput");
        public static WinFormsField PasswordOutput = new WinFormsField("PASSWORD-OUTPUT", "PasswordOutput");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
