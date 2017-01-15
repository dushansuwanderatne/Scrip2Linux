using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EAS01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EAS01020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotNum = new WinFormsField("ALLOT-NUM", "AllotNum");
        public static WinFormsField AllotDesc = new WinFormsField("ALLOT-DESC", "AllotDesc");
        public static WinFormsField AllotRepDate = new WinFormsField("ALLOT-REP-DATE", "AllotRepDate");
        public static WinFormsField AllotRepHead = new WinFormsField("ALLOT-REP-HEAD", "AllotRepHead");
        public static WinFormsField AllotRepSeq = new WinFormsField("ALLOT-REP-SEQ", "AllotRepSeq");
        public static WinFormsField AllotProgName = new WinFormsField("ALLOT-PROG-NAME", "AllotProgName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
