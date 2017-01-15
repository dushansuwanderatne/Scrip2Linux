using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SNAB0202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SNAB0202", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField PrePostTapeDesc = new WinFormsField("PRE-POST-TAPE-DESC", "PrePostTapeDesc");
        public static WinFormsField TotalEmployees = new WinFormsField("TOTAL-EMPLOYEES", "TotalEmployees");
    }
}
