using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class GPT01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("GPT01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField GptAccount = new WinFormsField("GPT-ACCOUNT", "GptAccount");
        public static WinFormsField GptDesc = new WinFormsField("GPT-DESC", "GptDesc");
        public static WinFormsField GptBuild = new WinFormsField("GPT-BUILD", "GptBuild");
        public static WinFormsField GptDeprec = new WinFormsField("GPT-DEPREC", "GptDeprec");
        public static WinFormsField SpltAccount = new WinFormsField("SPLT-ACCOUNT", "SpltAccount");
        public static WinFormsField SpltDesc = new WinFormsField("SPLT-DESC", "SpltDesc");
        public static WinFormsField SpltBuild = new WinFormsField("SPLT-BUILD", "SpltBuild");
        public static WinFormsField SpltDeprec = new WinFormsField("SPLT-DEPREC", "SpltDeprec");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
