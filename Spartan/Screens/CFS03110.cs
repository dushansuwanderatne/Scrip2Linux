using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03110", "FormName");
		//Fields


        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField CodeShortDesc = new WinFormsField("CODE-SHORT-DESC", "CodeShortDesc");
        public static WinFormsField CodeLongDesc = new WinFormsField("CODE-LONG-DESC", "CodeLongDesc");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField AddText = new WinFormsField("ADD-TEXT", "AddText");
        public static WinFormsField NextText = new WinFormsField("NEXT-TEXT", "NextText");
        public static WinFormsField AddDesc = new WinFormsField("ADD-DESC", "AddDesc");
        public static WinFormsField NextDesc = new WinFormsField("NEXT-DESC", "NextDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
