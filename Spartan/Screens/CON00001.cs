using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00001", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField PrincipalRegister = new WinFormsField("PRINCIPAL-REGISTER", "PrincipalRegister");
        public static WinFormsField ScripSequence = new WinFormsField("SCRIP-SEQUENCE", "ScripSequence");
        public static WinFormsField CompanyCountry = new WinFormsField("COMPANY-COUNTRY", "CompanyCountry");
        public static WinFormsField ChangeNoticeOption = new WinFormsField("CHANGE-NOTICE-OPTION", "ChangeNoticeOption");
        public static WinFormsField FastEnable = new WinFormsField("FAST-ENABLE", "FastEnable");
        public static WinFormsField StationeryOption = new WinFormsField("STATIONERY-OPTION", "StationeryOption");
        public static WinFormsField NonStandardTax = new WinFormsField("NON-STANDARD-TAX", "NonStandardTax");
        public static WinFormsField NonResAll = new WinFormsField("NON-RES-ALL", "NonResAll");
        public static WinFormsField CompanyTax = new WinFormsField("COMPANY-TAX", "CompanyTax");
        public static WinFormsField IndividualTax = new WinFormsField("INDIVIDUAL-TAX", "IndividualTax");
        public static WinFormsField RetainAid = new WinFormsField("RETAIN-AID", "RetainAid");
        public static WinFormsField VarFlag1Opt = new WinFormsField("VAR-FLAG-1-OPT", "VarFlag1Opt");
        public static WinFormsField VarFlag2Opt = new WinFormsField("VAR-FLAG-2-OPT", "VarFlag2Opt");
    }
}
