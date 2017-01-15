using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BSS02203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BSS02203", "FormName");
		//Fields


        public static WinFormsField SPOrder = new WinFormsField("SP-ORDER", "SPOrder");
        public static WinFormsField SPDesc = new WinFormsField("SP-DESC", "SPDesc");
        public static WinFormsField SPHolders = new WinFormsField("SP-HOLDERS", "SPHolders");
        public static WinFormsField SPPlines = new WinFormsField("SP-PLINES", "SPPlines");
        public static WinFormsField SPTotamt = new WinFormsField("SP-TOTAMT", "SPTotamt");
        public static WinFormsField SPGstExempt = new WinFormsField("SP-GST-EXEMPT", "SPGstExempt");
        public static WinFormsField SeqNbr = new WinFormsField("SEQ-NBR", "SeqNbr");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
    }
}
