using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10046
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10046", "FormName");
        //Fields
        public static WinFormsField WebProxyMailing = new WinFormsField("WEB-PROXY-MAILING", "WebProxyMailing");
        public static WinFormsField ProxyMeeting = new WinFormsField("PROXY-MEETING", "ProxyMeeting");
        public static WinFormsField RequiredPin = new WinFormsField("REQUIRED-PIN", "RequiredPin");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}