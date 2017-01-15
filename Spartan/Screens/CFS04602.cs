using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04602", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FileTypeCode = new WinFormsField("FILE-TYPE-CODE", "FileTypeCode");
        public static WinFormsField FileTypeDesc = new WinFormsField("FILE-TYPE-DESC", "FileTypeDesc");
        public static WinFormsField LitAdd = new WinFormsField("LIT-ADD", "LitAdd");
        public static WinFormsField LitForward = new WinFormsField("LIT-FORWARD", "LitForward");
        public static WinFormsField LitBack = new WinFormsField("LIT-BACK", "LitBack");
        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField GroupLongDesc = new WinFormsField("GROUP-LONG-DESC", "GroupLongDesc");
        public static WinFormsField FileTypeMask = new WinFormsField("FILE-TYPE-MASK", "FileTypeMask");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
