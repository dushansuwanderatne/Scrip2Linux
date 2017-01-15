using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN12

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN12", "FormName");
		//Fields


        public static WinFormsField RpdDescription = new WinFormsField("RPD-DESCRIPTION", "RpdDescription");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField DssFilename = new WinFormsField("DSS-FILENAME", "DssFilename");
        public static WinFormsField DssOrderNumber = new WinFormsField("DSS-ORDER-NUMBER", "DssOrderNumber");
        public static WinFormsField DssSceCode = new WinFormsField("DSS-SCE-CODE", "DssSceCode");
        public static WinFormsField RpdAction = new WinFormsField("RPD-ACTION", "RpdAction");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
