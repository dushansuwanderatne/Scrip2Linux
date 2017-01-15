using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS12201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS12201", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ProcessInd = new WinFormsField("PROCESS-IND", "ProcessInd");
        public static WinFormsField InputFileName = new WinFormsField("INPUT-FILE-NAME", "InputFileName");
        public static WinFormsField InputFileType = new WinFormsField("INPUT-FILE-TYPE", "InputFileType");
        public static WinFormsField ReplaceDcrInd = new WinFormsField("REPLACE-DCR-IND", "ReplaceDcrInd");
        public static WinFormsField ReplaceChqInd = new WinFormsField("REPLACE-CHQ-IND", "ReplaceChqInd");
        public static WinFormsField JobID = new WinFormsField("JOB-ID", "JobID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
