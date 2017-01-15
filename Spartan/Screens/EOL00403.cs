using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00403", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField FromHin = new WinFormsField("FROM-HIN", "FromHin");
        public static WinFormsField TOHin = new WinFormsField("TO-HIN", "TOHin");
        public static WinFormsField FromHnaLine = new WinFormsField("FROM-HNA-LINE", "FromHnaLine");
        public static WinFormsField TOHnaLine = new WinFormsField("TO-HNA-LINE", "TOHnaLine");
        public static WinFormsField FromMiscDesc = new WinFormsField("FROM-MISC-DESC", "FromMiscDesc");
        public static WinFormsField TOMiscDesc = new WinFormsField("TO-MISC-DESC", "TOMiscDesc");
        public static WinFormsField FromRegister = new WinFormsField("FROM-REGISTER", "FromRegister");
        public static WinFormsField FromUnits = new WinFormsField("FROM-UNITS", "FromUnits");
        public static WinFormsField TORegister = new WinFormsField("TO-REGISTER", "TORegister");
        public static WinFormsField TOUnits = new WinFormsField("TO-UNITS", "TOUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField FromMoneyDesc = new WinFormsField("FROM-MONEY-DESC", "FromMoneyDesc");
        public static WinFormsField TOMoneyDesc = new WinFormsField("TO-MONEY-DESC", "TOMoneyDesc");
        public static WinFormsField FromClass = new WinFormsField("FROM-CLASS", "FromClass");
        public static WinFormsField FromTliv = new WinFormsField("FROM-TLIV", "FromTliv");
        public static WinFormsField TOClass = new WinFormsField("TO-CLASS", "TOClass");
        public static WinFormsField TOTliv = new WinFormsField("TO-TLIV", "TOTliv");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
