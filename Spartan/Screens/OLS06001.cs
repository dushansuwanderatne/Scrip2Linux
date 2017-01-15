using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS06001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS06001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyEmployeeNO = new WinFormsField("BUY-EMPLOYEE-NO", "BuyEmployeeNO");
        public static WinFormsField EmployeeNameKey = new WinFormsField("EMPLOYEE-NAME-KEY", "EmployeeNameKey");
        public static WinFormsField BuySbn = new WinFormsField("BUY-SBN", "BuySbn");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
