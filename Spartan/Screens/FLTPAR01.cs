using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLTPAR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLTPAR01", "FormName");
		//Fields


        public static WinFormsField FltparKey0 = new WinFormsField("FLTPAR-KEY0", "FltparKey0");
        public static WinFormsField ProjectID = new WinFormsField("PROJECT-ID", "ProjectID");
        public static WinFormsField PreRegCompany = new WinFormsField("PRE-REG-COMPANY", "PreRegCompany");
        public static WinFormsField ProcessingMethod = new WinFormsField("PROCESSING-METHOD", "ProcessingMethod");
        public static WinFormsField InternetCompany = new WinFormsField("INTERNET-COMPANY", "InternetCompany");
        public static WinFormsField FloatCompany = new WinFormsField("FLOAT-COMPANY", "FloatCompany");
        public static WinFormsField StartApplicationID = new WinFormsField("START-APPLICATION-ID", "StartApplicationID");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndApplicationID = new WinFormsField("END-APPLICATION-ID", "EndApplicationID");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField PaymentSource = new WinFormsField("PAYMENT-SOURCE", "PaymentSource");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField SkipSeqNOCheckInd = new WinFormsField("SKIP-SEQ-NO-CHECK-IND", "SkipSeqNOCheckInd");
        public static WinFormsField VarFlag = new WinFormsField("VAR-FLAG", "VarFlag");
        public static WinFormsField LoadBrokerCodeFlg = new WinFormsField("LOAD-BROKER-CODE-FLG", "LoadBrokerCodeFlg");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
