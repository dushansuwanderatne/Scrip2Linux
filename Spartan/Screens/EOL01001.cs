using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField SearchUsan = new WinFormsField("SEARCH-USAN", "SearchUsan");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}