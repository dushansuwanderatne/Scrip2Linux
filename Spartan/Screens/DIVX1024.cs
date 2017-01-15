using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1024

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1024", "FormName");
		//Fields
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField SourceDescription = new WinFormsField("SOURCE-DESCRIPTION", "SourceDescription");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField TaxCtryCode = new WinFormsField("TAX-CTRY-CODE", "TaxCtryCode");
        public static WinFormsField TaxHolderIdentifier = new WinFormsField("TAX-HOLDER-IDENTIFIER", "TaxHolderIdentifier");
        public static WinFormsField TaxResRndOpt = new WinFormsField("TAX-RES-RND-OPT", "TaxResRndOpt");
        public static WinFormsField TaxNresRndOpt = new WinFormsField("TAX-NRES-RND-OPT", "TaxNresRndOpt");
        public static WinFormsField TaxResRndMult = new WinFormsField("TAX-RES-RND-MULT", "TaxResRndMult");
        public static WinFormsField TaxNresRndMult = new WinFormsField("TAX-NRES-RND-MULT", "TaxNresRndMult");
        public static WinFormsField TaxResRndMin = new WinFormsField("TAX-RES-RND-MIN", "TaxResRndMin");
        public static WinFormsField TaxNresRndMin = new WinFormsField("TAX-NRES-RND-MIN", "TaxNresRndMin");
        public static WinFormsField OtherTaxCtryCode = new WinFormsField("OTHER-TAX-CTRY-CODE", "OtherTaxCtryCode");
        public static WinFormsField OtherTaxHolderID = new WinFormsField("OTHER-TAX-HOLDER-ID", "OtherTaxHolderID");
        public static WinFormsField OtherTaxResRndOpt = new WinFormsField("OTHER-TAX-RES-RND-OPT", "OtherTaxResRndOpt");
        public static WinFormsField OtherTaxNresRndOpt = new WinFormsField("OTHER-TAX-NRES-RND-OPT", "OtherTaxNresRndOpt");
        public static WinFormsField OtherTaxResRndMult = new WinFormsField("OTHER-TAX-RES-RND-MULT", "OtherTaxResRndMult");
        public static WinFormsField OtherTaxNresRndMult = new WinFormsField("OTHER-TAX-NRES-RND-MULT", "OtherTaxNresRndMult");
        public static WinFormsField OtherTaxResRndMin = new WinFormsField("OTHER-TAX-RES-RND-MIN", "OtherTaxResRndMin");
        public static WinFormsField OtherTaxNresRndMin = new WinFormsField("OTHER-TAX-NRES-RND-MIN", "OtherTaxNresRndMin");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField FundDistTaxInd = new WinFormsField("FUND-DIST-TAX-IND", "FundDistTaxInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
