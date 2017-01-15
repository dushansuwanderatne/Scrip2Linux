using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSGDDF01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSGDDF01", "FormName");
		//Fields


        public static WinFormsField MsgddfKey0 = new WinFormsField("MSGDDF-KEY0", "MsgddfKey0");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField ActivityDate = new WinFormsField("ACTIVITY-DATE", "ActivityDate");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyAsxCode = new WinFormsField("COMPANY-ASX-CODE", "CompanyAsxCode");
        public static WinFormsField RecurringPeriod = new WinFormsField("RECURRING-PERIOD", "RecurringPeriod");
        public static WinFormsField ClientCodeTO = new WinFormsField("CLIENT-CODE-TO", "ClientCodeTO");
        public static WinFormsField UserIdentifierTO = new WinFormsField("USER-IDENTIFIER-TO", "UserIdentifierTO");
        public static WinFormsField PostedDate = new WinFormsField("POSTED-DATE", "PostedDate");
        public static WinFormsField FirstSummaryDate = new WinFormsField("FIRST-SUMMARY-DATE", "FirstSummaryDate");
        public static WinFormsField LastSummaryDate = new WinFormsField("LAST-SUMMARY-DATE", "LastSummaryDate");
        public static WinFormsField DeleteDate = new WinFormsField("DELETE-DATE", "DeleteDate");
        public static WinFormsField ModifiedDate = new WinFormsField("MODIFIED-DATE", "ModifiedDate");
        public static WinFormsField WarningDate = new WinFormsField("WARNING-DATE", "WarningDate");
        public static WinFormsField WhenEventOccurs = new WinFormsField("WHEN-EVENT-OCCURS", "WhenEventOccurs");
        public static WinFormsField MessageSentFlag = new WinFormsField("MESSAGE-SENT-FLAG", "MessageSentFlag");
        public static WinFormsField ConfidentialFlag = new WinFormsField("CONFIDENTIAL-FLAG", "ConfidentialFlag");
        public static WinFormsField SystemGeneratedFlag = new WinFormsField("SYSTEM-GENERATED-FLAG", "SystemGeneratedFlag");
        public static WinFormsField AutoDeleteFlag = new WinFormsField("AUTO-DELETE-FLAG", "AutoDeleteFlag");
        public static WinFormsField ShowLoginSummary = new WinFormsField("SHOW-LOGIN-SUMMARY", "ShowLoginSummary");
        public static WinFormsField UserNamePosted = new WinFormsField("USER-NAME-POSTED", "UserNamePosted");
        public static WinFormsField UserNameModified = new WinFormsField("USER-NAME-MODIFIED", "UserNameModified");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
