using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN41

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN41", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField FileGroupDesc = new WinFormsField("FILE-GROUP-DESC", "FileGroupDesc");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField FileGroupDescLG = new WinFormsField("FILE-GROUP-DESC-LG", "FileGroupDescLG");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
    }
}
