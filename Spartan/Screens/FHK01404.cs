using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01404", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ResidentTaxDeducted = new WinFormsField("RESIDENT-TAX-DEDUCTED", "ResidentTaxDeducted");
        public static WinFormsField TfnEntryDisallowed = new WinFormsField("TFN-ENTRY-DISALLOWED", "TfnEntryDisallowed");
        public static WinFormsField AtoWithholdTaxNbr = new WinFormsField("ATO-WITHHOLD-TAX-NBR", "AtoWithholdTaxNbr");
        public static WinFormsField StateTaxLodgement = new WinFormsField("STATE-TAX-LODGEMENT", "StateTaxLodgement");
        public static WinFormsField NewshnOption = new WinFormsField("NEWSHN-OPTION", "NewshnOption");
        public static WinFormsField NsnFormatNumber = new WinFormsField("NSN-FORMAT-NUMBER", "NsnFormatNumber");
        public static WinFormsField OSSequenceOption = new WinFormsField("OS-SEQUENCE-OPTION", "OSSequenceOption");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
