using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS30

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS30", "FormName");
		//Fields


        public static WinFormsField MenuItemJobdsp = new WinFormsField("MENU-ITEM-JOBDSP", "JOBDSP.  List jobs currently in QUEUE", "ListjobscurrentlyinQUEUE");
        public static WinFormsField MenuItemDropj = new WinFormsField("MENU-ITEM-DROPJ", "DROPJ.  Drop a job from QUEUE", "DropajobfromQUEUE");
        public static WinFormsField MenuItemRwait = new WinFormsField("MENU-ITEM-RWAIT", "RWAIT.  Remove Wait/Defer Time on JOB", "RemoveWait/DeferTimeonJOB");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
