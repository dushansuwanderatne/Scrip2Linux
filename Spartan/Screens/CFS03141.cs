using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03141

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03141", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField CodeShortDesc = new WinFormsField("CODE-SHORT-DESC", "CodeShortDesc");
        public static WinFormsField CodeLongDesc = new WinFormsField("CODE-LONG-DESC", "CodeLongDesc");
        public static WinFormsField ExtraData1 = new WinFormsField("EXTRA-DATA-1", "ExtraData1");
        public static WinFormsField ExtraData2 = new WinFormsField("EXTRA-DATA-2", "ExtraData2");
        public static WinFormsField ExtraDataNum = new WinFormsField("EXTRA-DATA-NUM", "ExtraDataNum");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
