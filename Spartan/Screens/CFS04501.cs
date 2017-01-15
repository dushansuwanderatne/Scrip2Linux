using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04501", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField FileGroupDesc = new WinFormsField("FILE-GROUP-DESC", "FileGroupDesc");
        public static WinFormsField FileGPLongDesc = new WinFormsField("FILE-GP-LONG-DESC", "FileGPLongDesc");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
