using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01701", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SubMessageType = new WinFormsField("SUB-MESSAGE-TYPE", "SubMessageType");
        public static WinFormsField Mode = new WinFormsField("MODE", "Mode");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        public static WinFormsField DataAction = new WinFormsField("DATA-ACTION", "DataAction");
        public static WinFormsField MessageID = new WinFormsField("MESSAGE-ID", "MessageID");
        public static WinFormsField StartTime = new WinFormsField("START-TIME", "StartTime");
        public static WinFormsField Interval = new WinFormsField("INTERVAL", "Interval");
        public static WinFormsField EndTime = new WinFormsField("END-TIME", "EndTime");
        public static WinFormsField Event = new WinFormsField("EVENT", "Event");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchMessage = new WinFormsField("SEARCH-MESSAGE", "SearchMessage");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
