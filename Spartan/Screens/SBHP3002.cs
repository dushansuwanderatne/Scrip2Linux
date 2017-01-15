using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP3002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP3002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderAddress = new WinFormsField("HOLDER-ADDRESS", "HolderAddress");
        public static WinFormsField OldCentreCode = new WinFormsField("OLD-CENTRE-CODE", "OldCentreCode");
        public static WinFormsField OldCentreDesc = new WinFormsField("OLD-CENTRE-DESC", "OldCentreDesc");
        public static WinFormsField NewCentreCode = new WinFormsField("NEW-CENTRE-CODE", "NewCentreCode");
        public static WinFormsField NewCentreDesc = new WinFormsField("NEW-CENTRE-DESC", "NewCentreDesc");
        public static WinFormsField OldCurrencyCode = new WinFormsField("OLD-CURRENCY-CODE", "OldCurrencyCode");
        public static WinFormsField OldCurrencyDesc = new WinFormsField("OLD-CURRENCY-DESC", "OldCurrencyDesc");
        public static WinFormsField NewCurrencyCode = new WinFormsField("NEW-CURRENCY-CODE", "NewCurrencyCode");
        public static WinFormsField NewCurrencyDesc = new WinFormsField("NEW-CURRENCY-DESC", "NewCurrencyDesc");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
