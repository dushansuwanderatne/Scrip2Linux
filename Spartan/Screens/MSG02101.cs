using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02101", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserIdentifierFrom = new WinFormsField("USER-IDENTIFIER-FROM", "UserIdentifierFrom");
        public static WinFormsField UserTO = new WinFormsField("USER-TO", "UserTO");
        public static WinFormsField CallerName = new WinFormsField("CALLER-NAME", "CallerName");
        public static WinFormsField CallerCompany = new WinFormsField("CALLER-COMPANY", "CallerCompany");
        public static WinFormsField CallerPhoneNO = new WinFormsField("CALLER-PHONE-NO", "CallerPhoneNO");
        public static WinFormsField MessagePriority = new WinFormsField("MESSAGE-PRIORITY", "MessagePriority");
        public static WinFormsField MessageLine = new WinFormsField("MESSAGE-LINE", "MessageLine");
        public static WinFormsField CalledBack = new WinFormsField("CALLED-BACK", "CalledBack");
        public static WinFormsField ReturnCall = new WinFormsField("RETURN-CALL", "ReturnCall");
        public static WinFormsField WillCallBack = new WinFormsField("WILL-CALL-BACK", "WillCallBack");
    }
}
