using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserIdentifierFrom = new WinFormsField("USER-IDENTIFIER-FROM", "UserIdentifierFrom");
        public static WinFormsField UserIdentifierTo1 = new WinFormsField("USER-IDENTIFIER-TO1", "UserIdentifierTo1");
        public static WinFormsField UserIdentifierTo2 = new WinFormsField("USER-IDENTIFIER-TO2", "UserIdentifierTo2");
        public static WinFormsField AcknowledgeFlag = new WinFormsField("ACKNOWLEDGE-FLAG", "AcknowledgeFlag");
        public static WinFormsField OneOnly = new WinFormsField("ONE-ONLY", "OneOnly");
        public static WinFormsField EncryptFlag = new WinFormsField("ENCRYPT-FLAG", "EncryptFlag");
        public static WinFormsField PrivateFlag = new WinFormsField("PRIVATE-FLAG", "PrivateFlag");
        public static WinFormsField EncryptPassword1 = new WinFormsField("ENCRYPT-PASSWORD-1", "EncryptPassword1");
        public static WinFormsField EncryptPassword2 = new WinFormsField("ENCRYPT-PASSWORD-2", "EncryptPassword2");
        public static WinFormsField ExpiryDate = new WinFormsField("EXPIRY-DATE", "ExpiryDate");
        public static WinFormsField Priority = new WinFormsField("PRIORITY", "Priority");
        public static WinFormsField Priority2 = new WinFormsField("PRIORITY-2", "Priority2");
        public static WinFormsField LastTransactionDate = new WinFormsField("LAST-TRANSACTION-DATE", "LastTransactionDate");
        public static WinFormsField LogoutDate = new WinFormsField("LOGOUT-DATE", "LogoutDate");
    }
}
