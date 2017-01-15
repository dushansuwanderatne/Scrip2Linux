using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAXRAT02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAXRAT02", "FormName");
		//Fields


        public static WinFormsField EffDate = new WinFormsField("EFF-DATE", "EffDate");
        public static WinFormsField ExpDate = new WinFormsField("EXP-DATE", "ExpDate");
        public static WinFormsField CtryCode = new WinFormsField("CTRY-CODE", "CtryCode");
        public static WinFormsField TaxCode = new WinFormsField("TAX-CODE", "TaxCode");
        public static WinFormsField TaxDesc = new WinFormsField("TAX-DESC", "TaxDesc");
        public static WinFormsField ResIndTaxquot = new WinFormsField("RES-IND-TAXQUOT", "ResIndTaxquot");
        public static WinFormsField ResCoyTaxquot = new WinFormsField("RES-COY-TAXQUOT", "ResCoyTaxquot");
        public static WinFormsField NresIndTaxquot = new WinFormsField("NRES-IND-TAXQUOT", "NresIndTaxquot");
        public static WinFormsField NresCoyTaxquot = new WinFormsField("NRES-COY-TAXQUOT", "NresCoyTaxquot");
        public static WinFormsField ResIndTaxnquot = new WinFormsField("RES-IND-TAXNQUOT", "ResIndTaxnquot");
        public static WinFormsField ResCoyTaxnquot = new WinFormsField("RES-COY-TAXNQUOT", "ResCoyTaxnquot");
        public static WinFormsField NresIndTaxnquot = new WinFormsField("NRES-IND-TAXNQUOT", "NresIndTaxnquot");
        public static WinFormsField NresCoyTaxnquot = new WinFormsField("NRES-COY-TAXNQUOT", "NresCoyTaxnquot");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
