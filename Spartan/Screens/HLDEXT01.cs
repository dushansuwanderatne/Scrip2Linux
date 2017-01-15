using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDEXT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDEXT01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderExtraIdentifier = new WinFormsField("HOLDER-EXTRA-IDENTIFIER", "HolderExtraIdentifier");
        public static WinFormsField HomePhone = new WinFormsField("HOME-PHONE", "HomePhone");
        public static WinFormsField WorkPhone = new WinFormsField("WORK-PHONE", "WorkPhone");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField MobilePhone = new WinFormsField("MOBILE-PHONE", "MobilePhone");
        public static WinFormsField PhoneMsgType = new WinFormsField("PHONE-MSG-TYPE", "PhoneMsgType");
        public static WinFormsField Abn = new WinFormsField("ABN", "Abn");
        public static WinFormsField AbnSuffix1 = new WinFormsField("ABN-SUFFIX-1", "AbnSuffix1");
        public static WinFormsField AbnJointInd1 = new WinFormsField("ABN-JOINT-IND-1", "AbnJointInd1");
        public static WinFormsField AmlStatusInd = new WinFormsField("AML-STATUS-IND", "AmlStatusInd");
        public static WinFormsField Abn2 = new WinFormsField("ABN-2", "Abn2");
        public static WinFormsField AbnSuffix2 = new WinFormsField("ABN-SUFFIX-2", "AbnSuffix2");
        public static WinFormsField AbnJointInd2 = new WinFormsField("ABN-JOINT-IND-2", "AbnJointInd2");
        public static WinFormsField AmlStatusDate = new WinFormsField("AML-STATUS-DATE", "AmlStatusDate");
        public static WinFormsField AmlStatusTime = new WinFormsField("AML-STATUS-TIME", "AmlStatusTime");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField EmailReturnDate = new WinFormsField("EMAIL-RETURN-DATE", "EmailReturnDate");
        public static WinFormsField EmailType = new WinFormsField("EMAIL-TYPE", "EmailType");
        public static WinFormsField EmailFailCount = new WinFormsField("EMAIL-FAIL-COUNT", "EmailFailCount");
        public static WinFormsField EWFlag = new WinFormsField("EW-FLAG", "EWFlag");
        public static WinFormsField CommMethod = new WinFormsField("COMM-METHOD", "CommMethod");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
