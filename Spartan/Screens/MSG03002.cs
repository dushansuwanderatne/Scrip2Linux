using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG03002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG03002", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 3", "3");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserTO = new WinFormsField("USER-TO", "UserTO");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField ActivityDate = new WinFormsField("ACTIVITY-DATE", "ActivityDate");
        public static WinFormsField CompanyAsxCode = new WinFormsField("COMPANY-ASX-CODE", "CompanyAsxCode");
        public static WinFormsField DiaryLine = new WinFormsField("DIARY-LINE", "DiaryLine");
        public static WinFormsField RecurringPeriod = new WinFormsField("RECURRING-PERIOD", "RecurringPeriod");
        public static WinFormsField ConfidentialFlag = new WinFormsField("CONFIDENTIAL-FLAG", "ConfidentialFlag");
        public static WinFormsField EncryptPassword1 = new WinFormsField("ENCRYPT-PASSWORD-1", "EncryptPassword1");
        public static WinFormsField EncryptPassword2 = new WinFormsField("ENCRYPT-PASSWORD-2", "EncryptPassword2");
    }
}
