using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RUNSTS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RUNSTS01", "FormName");
		//Fields


        public static WinFormsField RunDate1 = new WinFormsField("RUN-DATE1", "RunDate1");
        public static WinFormsField RunDate2 = new WinFormsField("RUN-DATE2", "RunDate2");
        public static WinFormsField RunDate3 = new WinFormsField("RUN-DATE3", "RunDate3");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Constant1 = new WinFormsField("CONSTANT1", "Constant1");
        public static WinFormsField Ranges = new WinFormsField("RANGES", "Ranges");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
