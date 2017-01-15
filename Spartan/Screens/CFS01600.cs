using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01600

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01600", "FormName");
		//Fields


        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField ClassAsx = new WinFormsField("CLASS-ASX", "ClassAsx");
        public static WinFormsField CompanyDir = new WinFormsField("COMPANY-DIR", "CompanyDir");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField ConvertTOAudInd = new WinFormsField("CONVERT-TO-AUD-IND", "ConvertTOAudInd");
        public static WinFormsField StoreExcRateInd = new WinFormsField("STORE-EXC-RATE-IND", "StoreExcRateInd");
        public static WinFormsField CompanyTypeInd = new WinFormsField("COMPANY-TYPE-IND", "CompanyTypeInd");
        public static WinFormsField FasterSecurity = new WinFormsField("FASTER-SECURITY", "FasterSecurity");
        public static WinFormsField AlternateClass = new WinFormsField("ALTERNATE-CLASS", "AlternateClass");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField CufsSecurityInd = new WinFormsField("CUFS-SECURITY-IND", "CufsSecurityInd");
        public static WinFormsField SettleASCufsInd = new WinFormsField("SETTLE-AS-CUFS-IND", "SettleASCufsInd");
        public static WinFormsField DisStxTradingInd = new WinFormsField("DIS-STX-TRADING-IND", "DisStxTradingInd");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ExchangeDescription = new WinFormsField("EXCHANGE-DESCRIPTION", "ExchangeDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchSecurity = new WinFormsField("SEARCH-SECURITY", "SearchSecurity");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
        public static WinFormsField SearchIsin = new WinFormsField("SEARCH-ISIN", "SearchIsin");
    }
}
