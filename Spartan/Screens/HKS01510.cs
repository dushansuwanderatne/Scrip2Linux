using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01510

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01510", "FormName");
		//Fields


        public static WinFormsField DeceasedBuyFlag = new WinFormsField("DECEASED-BUY-FLAG", "DeceasedBuyFlag");
        public static WinFormsField DeceasedSellFlag = new WinFormsField("DECEASED-SELL-FLAG", "DeceasedSellFlag");
        public static WinFormsField UrrMonday = new WinFormsField("URR-MONDAY", "UrrMonday");
        public static WinFormsField UrrTuesday = new WinFormsField("URR-TUESDAY", "UrrTuesday");
        public static WinFormsField UrrWednesday = new WinFormsField("URR-WEDNESDAY", "UrrWednesday");
        public static WinFormsField UrrThursday = new WinFormsField("URR-THURSDAY", "UrrThursday");
        public static WinFormsField UrrFriday = new WinFormsField("URR-FRIDAY", "UrrFriday");
        public static WinFormsField UrrEvery2days = new WinFormsField("URR-EVERY-2DAYS", "UrrEvery2days");
        public static WinFormsField NextUrrDate = new WinFormsField("NEXT-URR-DATE", "NextUrrDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
