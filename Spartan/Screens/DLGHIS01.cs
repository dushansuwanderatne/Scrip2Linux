using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DLGHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DLGHIS01", "FormName");
		//Fields


        public static WinFormsField DlghisKey0 = new WinFormsField("DLGHIS-KEY0", "DlghisKey0");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField DealingTransStatus = new WinFormsField("DEALING-TRANS-STATUS", "DealingTransStatus");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField DealingID = new WinFormsField("DEALING-ID", "DealingID");
        public static WinFormsField DlgTransNumber = new WinFormsField("DLG-TRANS-NUMBER", "DlgTransNumber");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField TranSequence = new WinFormsField("TRAN-SEQUENCE", "TranSequence");
        public static WinFormsField VersionNumber = new WinFormsField("VERSION-NUMBER", "VersionNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
