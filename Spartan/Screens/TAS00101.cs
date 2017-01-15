using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00101", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 3", "3");
        public static WinFormsField PersonName = new WinFormsField("PERSON-NAME", "PersonName");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Task = new WinFormsField("TASK", "Task");
        public static WinFormsField Project = new WinFormsField("PROJECT", "Project");
        public static WinFormsField RequestedBY = new WinFormsField("REQUESTED-BY", "RequestedBY");
        public static WinFormsField OurRef = new WinFormsField("OUR-REF", "OurRef");
        public static WinFormsField ProgName = new WinFormsField("PROG-NAME", "ProgName");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField TimeSpent = new WinFormsField("TIME-SPENT", "TimeSpent");
        public static WinFormsField TotalTime = new WinFormsField("TOTAL-TIME", "TotalTime");
    }
}
