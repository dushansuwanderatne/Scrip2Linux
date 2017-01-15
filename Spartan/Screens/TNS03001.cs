using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS03001", "FormName");
		//Fields


        public static WinFormsField MenuItemIre = new WinFormsField("MENU-ITEM-IRE", "IRE.  Irish Tax Certification Export to ATO", "IrishTaxCertificationExporttoATO");
        public static WinFormsField MenuItemIri = new WinFormsField("MENU-ITEM-IRI", "IRI.  Irish Tax Certification Import from ATO", "IrishTaxCertificationImportfromATO");
        public static WinFormsField MenuItemIne = new WinFormsField("MENU-ITEM-INE", "INE.  Irish Tax Certification Export to IRD", "IrishTaxCertificationExporttoIRD");
        public static WinFormsField MenuItemIni = new WinFormsField("MENU-ITEM-INI", "INI.  Irish Tax Certification Import from IRD", "IrishTaxCertificationImportfromIRD");
        public static WinFormsField MenuItemIrr = new WinFormsField("MENU-ITEM-IRR", "IRR.  Irish Tax Reporting to Irish Revenue Office", "IrishTaxReportingtoIrishRevenueOffice");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit IRL Tax Processing", "ExitIRLTaxProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
