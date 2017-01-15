using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11001
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("OLS11001", "FormName");
        //Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField RecnRequired = new WinFormsField("RECN-REQUIRED", "RecnRequired");
        public static WinFormsField ChequeFormat = new WinFormsField("CHEQUE-FORMAT", "ChequeFormat");
        public static WinFormsField FilenameBody = new WinFormsField("FILENAME-BODY", "FilenameBody");
        public static WinFormsField FinaliseFileInd = new WinFormsField("FINALISE-FILE-IND", "FinaliseFileInd");
        public static WinFormsField Update = new WinFormsField("UPDATE", "Update");
        public static WinFormsField Origin = new WinFormsField("ORIGIN", "Origin");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}