using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class IATACH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("IATACH01", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField IatName = new WinFormsField("IAT-NAME", "IatName");
        public static WinFormsField IatBankCode = new WinFormsField("IAT-BANK-CODE", "IatBankCode");
        public static WinFormsField IatAccNum = new WinFormsField("IAT-ACC-NUM", "IatAccNum");
        public static WinFormsField MoreText = new WinFormsField("MORE-TEXT", "MoreText");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
