using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AESLAS04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AESLAS04", "FormName");
		//Fields


        public static WinFormsField AssocPayInstID = new WinFormsField("ASSOC-PAY-INST-ID", "AssocPayInstID");
        public static WinFormsField AssocBankCode = new WinFormsField("ASSOC-BANK-CODE", "AssocBankCode");
        public static WinFormsField AssocSwiftCode = new WinFormsField("ASSOC-SWIFT-CODE", "AssocSwiftCode");
        public static WinFormsField AssocAccountNumber = new WinFormsField("ASSOC-ACCOUNT-NUMBER", "AssocAccountNumber");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField InputID = new WinFormsField("INPUT-ID", "InputID");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
