using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS01104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS01104", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField OtherTaxCode = new WinFormsField("OTHER-TAX-CODE", "OtherTaxCode");
        public static WinFormsField DeleteInd = new WinFormsField("DELETE-IND", "DeleteInd");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField HolderExemptInd = new WinFormsField("HOLDER-EXEMPT-IND", "HolderExemptInd");
        public static WinFormsField IrdChar1to3 = new WinFormsField("IRD-CHAR-1TO3", "IrdChar1to3");
        public static WinFormsField IrdChar4to6 = new WinFormsField("IRD-CHAR-4TO6", "IrdChar4to6");
        public static WinFormsField IrdChar7to9 = new WinFormsField("IRD-CHAR-7TO9", "IrdChar7to9");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
