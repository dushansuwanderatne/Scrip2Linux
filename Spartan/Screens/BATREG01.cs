using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BATREG01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BATREG01", "FormName");
		//Fields


        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Initials = new WinFormsField("INITIALS", "Initials");
        public static WinFormsField InputDate = new WinFormsField("INPUT-DATE", "InputDate");
        public static WinFormsField NumberApplication = new WinFormsField("NUMBER-APPLICATION", "NumberApplication");
        public static WinFormsField BatchCategory = new WinFormsField("BATCH-CATEGORY", "BatchCategory");
        public static WinFormsField ProcessedRun = new WinFormsField("PROCESSED-RUN", "ProcessedRun");
        public static WinFormsField BrokerClassFlag = new WinFormsField("BROKER-CLASS-FLAG", "BrokerClassFlag");
        public static WinFormsField SingleBrokerFlag = new WinFormsField("SINGLE-BROKER-FLAG", "SingleBrokerFlag");
        public static WinFormsField StartTrans = new WinFormsField("START-TRANS", "StartTrans");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField EndTrans = new WinFormsField("END-TRANS", "EndTrans");
        public static WinFormsField BatchTransDate = new WinFormsField("BATCH-TRANS-DATE", "BatchTransDate");
        public static WinFormsField MissingTrans = new WinFormsField("MISSING-TRANS", "MissingTrans");
        public static WinFormsField MissingTransFlag = new WinFormsField("MISSING-TRANS-FLAG", "MissingTransFlag");
        public static WinFormsField LastUsedTransNbr = new WinFormsField("LAST-USED-TRANS-NBR", "LastUsedTransNbr");
        public static WinFormsField AmountMoney = new WinFormsField("AMOUNT-MONEY", "AmountMoney");
        public static WinFormsField NumberUnits = new WinFormsField("NUMBER-UNITS", "NumberUnits");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
