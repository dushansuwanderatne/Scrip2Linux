using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL02302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL02302", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField Register1 = new WinFormsField("REGISTER-1", "Register1");
        public static WinFormsField RegType1 = new WinFormsField("REG-TYPE-1", "RegType1");
        public static WinFormsField Register2 = new WinFormsField("REGISTER-2", "Register2");
        public static WinFormsField RegType2 = new WinFormsField("REG-TYPE-2", "RegType2");
        public static WinFormsField EmpStatus = new WinFormsField("EMP-STATUS", "EmpStatus");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField RelIFNOSavings = new WinFormsField("REL-IF-NO-SAVINGS", "RelIFNOSavings");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField ReleaseMode = new WinFormsField("RELEASE-MODE", "ReleaseMode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
