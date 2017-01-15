using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EAS01022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EAS01022", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotNum = new WinFormsField("ALLOT-NUM", "AllotNum");
        public static WinFormsField AllotDesc = new WinFormsField("ALLOT-DESC", "AllotDesc");
        public static WinFormsField VestRepDate = new WinFormsField("VEST-REP-DATE", "VestRepDate");
        public static WinFormsField VestRepHead = new WinFormsField("VEST-REP-HEAD", "VestRepHead");
        public static WinFormsField VestRepSeq = new WinFormsField("VEST-REP-SEQ", "VestRepSeq");
        public static WinFormsField VestProgName = new WinFormsField("VEST-PROG-NAME", "VestProgName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
