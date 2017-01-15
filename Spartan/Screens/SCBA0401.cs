using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BoxNumber = new WinFormsField("BOX-NUMBER", "BoxNumber");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField BoxDetailLine = new WinFormsField("BOX-DETAIL-LINE", "BoxDetailLine");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
