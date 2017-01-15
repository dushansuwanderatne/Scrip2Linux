using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAXRAT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAXRAT01", "FormName");
		//Fields


        public static WinFormsField AddText = new WinFormsField("ADD-TEXT", "AddText");
        public static WinFormsField AddDesc = new WinFormsField("ADD-DESC", "AddDesc");
        public static WinFormsField NextText = new WinFormsField("NEXT-TEXT", "NextText");
        public static WinFormsField NextDesc = new WinFormsField("NEXT-DESC", "NextDesc");
        public static WinFormsField TaxCodeDesc = new WinFormsField("TAX-CODE-DESC", "TaxCodeDesc");
        public static WinFormsField EffDate = new WinFormsField("EFF-DATE", "EffDate");
        public static WinFormsField CtryCode = new WinFormsField("CTRY-CODE", "CtryCode");
        public static WinFormsField Index = new WinFormsField("INDEX", "Index");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField TaxCode = new WinFormsField("TAX-CODE", "TaxCode");
        public static WinFormsField ExpDate = new WinFormsField("EXP-DATE", "ExpDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
