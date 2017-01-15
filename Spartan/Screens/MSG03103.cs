using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG03103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG03103", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserNamePosted = new WinFormsField("USER-NAME-POSTED", "UserNamePosted");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField UserIdentifierTo1 = new WinFormsField("USER-IDENTIFIER-TO1", "UserIdentifierTo1");
        public static WinFormsField UserIdentifierTo2 = new WinFormsField("USER-IDENTIFIER-TO2", "UserIdentifierTo2");
        public static WinFormsField ActivityDate = new WinFormsField("ACTIVITY-DATE", "ActivityDate");
        public static WinFormsField WarningFlag = new WinFormsField("WARNING-FLAG", "WarningFlag");
        public static WinFormsField WarningDate = new WinFormsField("WARNING-DATE", "WarningDate");
        public static WinFormsField WhenEventOccurs = new WinFormsField("WHEN-EVENT-OCCURS", "WhenEventOccurs");
        public static WinFormsField AutoDeleteFlag = new WinFormsField("AUTO-DELETE-FLAG", "AutoDeleteFlag");
        public static WinFormsField DeleteDate = new WinFormsField("DELETE-DATE", "DeleteDate");
        public static WinFormsField FirstSummaryDate = new WinFormsField("FIRST-SUMMARY-DATE", "FirstSummaryDate");
        public static WinFormsField SummaryAfterEvent = new WinFormsField("SUMMARY-AFTER-EVENT", "SummaryAfterEvent");
        public static WinFormsField LastSummaryDate = new WinFormsField("LAST-SUMMARY-DATE", "LastSummaryDate");
        public static WinFormsField ShowLoginSummary = new WinFormsField("SHOW-LOGIN-SUMMARY", "ShowLoginSummary");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
