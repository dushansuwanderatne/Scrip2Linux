using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01035

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01035", "FormName");
		//Fields


        public static WinFormsField DumpIsxClass = new WinFormsField("DUMP-ISX-CLASS", "DumpIsxClass");
        public static WinFormsField IsxSubSystemID1 = new WinFormsField("ISX-SUB-SYSTEM-ID-1", "IsxSubSystemID1");
        public static WinFormsField IsxSubSystemID2 = new WinFormsField("ISX-SUB-SYSTEM-ID-2", "IsxSubSystemID2");
        public static WinFormsField IsxSubSystemID3 = new WinFormsField("ISX-SUB-SYSTEM-ID-3", "IsxSubSystemID3");
        public static WinFormsField IsxSubSystemID4 = new WinFormsField("ISX-SUB-SYSTEM-ID-4", "IsxSubSystemID4");
        public static WinFormsField IsxSubSystemID5 = new WinFormsField("ISX-SUB-SYSTEM-ID-5", "IsxSubSystemID5");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
