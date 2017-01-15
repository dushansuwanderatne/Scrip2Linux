using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField CompanyDirectory = new WinFormsField("COMPANY-DIRECTORY", "CompanyDirectory");
        public static WinFormsField SecurityNameKey = new WinFormsField("SECURITY-NAME-KEY", "SecurityNameKey");
        public static WinFormsField SecurityAbbrevDesc = new WinFormsField("SECURITY-ABBREV-DESC", "SecurityAbbrevDesc");
        public static WinFormsField SecurityDesc = new WinFormsField("SECURITY-DESC", "SecurityDesc");
        public static WinFormsField NationalityDec = new WinFormsField("NATIONALITY-DEC", "NationalityDec");
        public static WinFormsField RegistrarID = new WinFormsField("REGISTRAR-ID", "RegistrarID");
        public static WinFormsField SettlementAllowed = new WinFormsField("SETTLEMENT-ALLOWED", "SettlementAllowed");
        public static WinFormsField SecurityCategory = new WinFormsField("SECURITY-CATEGORY", "SecurityCategory");
        public static WinFormsField DbvAllowed = new WinFormsField("DBV-ALLOWED", "DbvAllowed");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField RurRequired = new WinFormsField("RUR-REQUIRED", "RurRequired");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField SecurityStatus = new WinFormsField("SECURITY-STATUS", "SecurityStatus");
        public static WinFormsField EffectiveDate = new WinFormsField("EFFECTIVE-DATE", "EffectiveDate");
        public static WinFormsField StampDutyExempt = new WinFormsField("STAMP-DUTY-EXEMPT", "StampDutyExempt");
        public static WinFormsField SecurityReconDate = new WinFormsField("SECURITY-RECON-DATE", "SecurityReconDate");
        public static WinFormsField StampCurrency = new WinFormsField("STAMP-CURRENCY", "StampCurrency");
        public static WinFormsField FullReconDate = new WinFormsField("FULL-RECON-DATE", "FullReconDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
        public static WinFormsField SearchIsin = new WinFormsField("SEARCH-ISIN", "SearchIsin");
    }
}
