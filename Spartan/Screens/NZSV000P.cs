using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NZSV000P

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NZSV000P", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Nzlsrv000pUserPassword = new WinFormsField("NZLSRV000P-USER-PASSWORD", "Nzlsrv000pUserPassword");
        public static WinFormsField Nzlsrv000pLocalTime = new WinFormsField("NZLSRV000P-LOCAL-TIME", "Nzlsrv000pLocalTime");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
