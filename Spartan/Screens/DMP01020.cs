using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField DeleteNilCerts = new WinFormsField("DELETE-NIL-CERTS", "DeleteNilCerts");
        public static WinFormsField DeleteAllNils = new WinFormsField("DELETE-ALL-NILS", "DeleteAllNils");
        public static WinFormsField DelNilClass = new WinFormsField("DEL-NIL-CLASS", "DelNilClass");
        public static WinFormsField DelNilClass20 = new WinFormsField("DEL-NIL-CLASS-20", "DelNilClass20");
        public static WinFormsField DelNilRunNumber = new WinFormsField("DEL-NIL-RUN-NUMBER", "DelNilRunNumber");
        public static WinFormsField DelNilReport = new WinFormsField("DEL-NIL-REPORT", "DelNilReport");
        public static WinFormsField DelNilsIFAllNil = new WinFormsField("DEL-NILS-IF-ALL-NIL", "DelNilsIFAllNil");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
