using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP6002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP6002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Grp = new WinFormsField("GRP", "Grp");
        public static WinFormsField CurrCode = new WinFormsField("CURR-CODE", "CurrCode");
        public static WinFormsField CntCde1 = new WinFormsField("CNT-CDE-1", "CntCde1");
        public static WinFormsField CntCde2 = new WinFormsField("CNT-CDE-2", "CntCde2");
        public static WinFormsField CntCde3 = new WinFormsField("CNT-CDE-3", "CntCde3");
        public static WinFormsField CntCde4 = new WinFormsField("CNT-CDE-4", "CntCde4");
        public static WinFormsField Lre = new WinFormsField("LRE", "Lre");
        public static WinFormsField EmpGde = new WinFormsField("EMP-GDE", "EmpGde");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField OutputFilename = new WinFormsField("OUTPUT-FILENAME", "OutputFilename");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
