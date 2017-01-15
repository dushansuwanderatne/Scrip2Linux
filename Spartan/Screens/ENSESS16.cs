using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS16

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS16", "FormName");
		//Fields
        public static WinFormsField StoppedSaving = new WinFormsField("STOPPED-SAVING", "StoppedSaving");
        public static WinFormsField NbrRestarts = new WinFormsField("NBR-RESTARTS", "NbrRestarts");
        public static WinFormsField ResidualInd = new WinFormsField("RESIDUAL-IND", "ResidualInd");
        public static WinFormsField HoldEndPrdMths = new WinFormsField("HOLD-END-PRD-MTHS", "HoldEndPrdMths");
        public static WinFormsField HoldEndPrdDays = new WinFormsField("HOLD-END-PRD-DAYS", "HoldEndPrdDays");
        public static WinFormsField TaxEndPrdMths = new WinFormsField("TAX-END-PRD-MTHS", "TaxEndPrdMths");
        public static WinFormsField TaxEndPrdDays = new WinFormsField("TAX-END-PRD-DAYS", "TaxEndPrdDays");
        public static WinFormsField Unmatched = new WinFormsField("UNMATCHED", "Unmatched");
        public static WinFormsField BonusUnmatched = new WinFormsField("BONUS-UNMATCHED", "BonusUnmatched");
        public static WinFormsField RolledOverResInd = new WinFormsField("ROLLED-OVER-RES-IND", "RolledOverResInd");
        public static WinFormsField RolledOverAccumPer = new WinFormsField("ROLLED-OVER-ACCUM-PER", "RolledOverAccumPer");
    }
}
