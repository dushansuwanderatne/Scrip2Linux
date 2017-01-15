using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS04603

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS04603", "FormName");
		//Fields


        public static WinFormsField FileGroupCode = new WinFormsField("FILE-GROUP-CODE", "FileGroupCode");
        public static WinFormsField GroupLongDesc = new WinFormsField("GROUP-LONG-DESC", "GroupLongDesc");
        public static WinFormsField FileTypeCode = new WinFormsField("FILE-TYPE-CODE", "FileTypeCode");
        public static WinFormsField FileTypeShortDesc = new WinFormsField("FILE-TYPE-SHORT-DESC", "FileTypeShortDesc");
        public static WinFormsField FileTypeDesc = new WinFormsField("FILE-TYPE-DESC", "FileTypeDesc");
        public static WinFormsField FileTypeMask = new WinFormsField("FILE-TYPE-MASK", "FileTypeMask");
        public static WinFormsField FileTypeDir = new WinFormsField("FILE-TYPE-DIR", "FileTypeDir");
        public static WinFormsField DssIndexedInd = new WinFormsField("DSS-INDEXED-IND", "DssIndexedInd");
        public static WinFormsField DssIndexingXml = new WinFormsField("DSS-INDEXING-XML", "DssIndexingXml");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
