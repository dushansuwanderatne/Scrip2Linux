using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03150

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03150", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField FrmHdrTableCode = new WinFormsField("FRM-HDR-TABLE-CODE", "FrmHdrTableCode");
        public static WinFormsField FrmHdrCodeDesc = new WinFormsField("FRM-HDR-CODE-DESC", "FrmHdrCodeDesc");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField CodeShortDesc = new WinFormsField("CODE-SHORT-DESC", "CodeShortDesc");
        public static WinFormsField CodeLongDesc = new WinFormsField("CODE-LONG-DESC", "CodeLongDesc");
        public static WinFormsField Heading1 = new WinFormsField("HEADING-1", "Heading1");
        public static WinFormsField Heading2 = new WinFormsField("HEADING-2", "Heading2");
        public static WinFormsField Heading3 = new WinFormsField("HEADING-3", "Heading3");
        public static WinFormsField Data1 = new WinFormsField("DATA-1", "Data1");
        public static WinFormsField Data2 = new WinFormsField("DATA-2", "Data2");
        public static WinFormsField NumData = new WinFormsField("NUM-DATA", "NumData");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
