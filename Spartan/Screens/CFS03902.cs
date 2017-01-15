using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03902", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField PayMethodFrom = new WinFormsField("PAY-METHOD-FROM", "PayMethodFrom");
        public static WinFormsField PayMethodFromDesc = new WinFormsField("PAY-METHOD-FROM-DESC", "PayMethodFromDesc");
        public static WinFormsField PayStatusFrom = new WinFormsField("PAY-STATUS-FROM", "PayStatusFrom");
        public static WinFormsField PayStatusFromDesc = new WinFormsField("PAY-STATUS-FROM-DESC", "PayStatusFromDesc");
        public static WinFormsField PayMethodTO = new WinFormsField("PAY-METHOD-TO", "PayMethodTO");
        public static WinFormsField PayMethodTODesc = new WinFormsField("PAY-METHOD-TO-DESC", "PayMethodTODesc");
        public static WinFormsField PayStatusTO = new WinFormsField("PAY-STATUS-TO", "PayStatusTO");
        public static WinFormsField PayStatusTODesc = new WinFormsField("PAY-STATUS-TO-DESC", "PayStatusTODesc");
        public static WinFormsField AcuTranTypeCode = new WinFormsField("ACU-TRAN-TYPE-CODE", "AcuTranTypeCode");
        public static WinFormsField AcuBankSrc = new WinFormsField("ACU-BANK-SRC", "AcuBankSrc");
        public static WinFormsField AcuContraTranCode = new WinFormsField("ACU-CONTRA-TRAN-CODE", "AcuContraTranCode");
        public static WinFormsField AcuContraBankSrc = new WinFormsField("ACU-CONTRA-BANK-SRC", "AcuContraBankSrc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
