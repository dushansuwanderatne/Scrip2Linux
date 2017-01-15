using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01602", "FormName");
		//Fields


        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField CompanyDir = new WinFormsField("COMPANY-DIR", "CompanyDir");
        public static WinFormsField CompanyClass = new WinFormsField("COMPANY-CLASS", "CompanyClass");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField SrnRequired = new WinFormsField("SRN-REQUIRED", "SrnRequired");
        public static WinFormsField SecurityRestriction = new WinFormsField("SECURITY-RESTRICTION", "SecurityRestriction");
        public static WinFormsField FullReconDate = new WinFormsField("FULL-RECON-DATE", "FullReconDate");
        public static WinFormsField LastFullRecon = new WinFormsField("LAST-FULL-RECON", "LastFullRecon");
        public static WinFormsField NewSecurityCode = new WinFormsField("NEW-SECURITY-CODE", "NewSecurityCode");
        public static WinFormsField CrestLiveDate = new WinFormsField("CREST-LIVE-DATE", "CrestLiveDate");
        public static WinFormsField ClassChangeDate = new WinFormsField("CLASS-CHANGE-DATE", "ClassChangeDate");
        public static WinFormsField CrestTransitionDate = new WinFormsField("CREST-TRANSITION-DATE", "CrestTransitionDate");
        public static WinFormsField DirectoryCodeChange = new WinFormsField("DIRECTORY-CODE-CHANGE", "DirectoryCodeChange");
        public static WinFormsField RurRequired = new WinFormsField("RUR-REQUIRED", "RurRequired");
        public static WinFormsField NewUic = new WinFormsField("NEW-UIC", "NewUic");
        public static WinFormsField NationalityDec = new WinFormsField("NATIONALITY-DEC", "NationalityDec");
        public static WinFormsField NewIsin = new WinFormsField("NEW-ISIN", "NewIsin");
        public static WinFormsField TakeoverAgentID = new WinFormsField("TAKEOVER-AGENT-ID", "TakeoverAgentID");
        public static WinFormsField TakeoverAccountID = new WinFormsField("TAKEOVER-ACCOUNT-ID", "TakeoverAccountID");
        public static WinFormsField CorporateAction = new WinFormsField("CORPORATE-ACTION", "CorporateAction");
        public static WinFormsField CorpActionID = new WinFormsField("CORP-ACTION-ID", "CorpActionID");
        public static WinFormsField EXDate = new WinFormsField("EX-DATE", "EXDate");
        public static WinFormsField RecordDate = new WinFormsField("RECORD-DATE", "RecordDate");
        public static WinFormsField AllotmentDate = new WinFormsField("ALLOTMENT-DATE", "AllotmentDate");
        public static WinFormsField AllotmentClass = new WinFormsField("ALLOTMENT-CLASS", "AllotmentClass");
        public static WinFormsField DespatchDate = new WinFormsField("DESPATCH-DATE", "DespatchDate");
        public static WinFormsField TakeCumClassDate = new WinFormsField("TAKE-CUM-CLASS-DATE", "TakeCumClassDate");
    }
}
