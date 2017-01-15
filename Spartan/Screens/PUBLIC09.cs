using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC09

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC09", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField NameAddress = new WinFormsField("NAME-ADDRESS", "NameAddress");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Cdesc = new WinFormsField("CDESC", "Cdesc");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField OffDate = new WinFormsField("OFF-DATE", "OffDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
