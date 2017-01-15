using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03103", "FormName");
		//Fields


        public static WinFormsField UrrAutoWithOth = new WinFormsField("URR-AUTO-WITH-OTH", "UrrAutoWithOth");
        public static WinFormsField UrrCondAutoWith = new WinFormsField("URR-COND-AUTO-WITH", "UrrCondAutoWith");
        public static WinFormsField UrrAutoWithLnkCde = new WinFormsField("URR-AUTO-WITH-LNK-CDE", "UrrAutoWithLnkCde");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
