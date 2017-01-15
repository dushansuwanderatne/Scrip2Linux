using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01029

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01029", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PlanListOption = new WinFormsField("PLAN-LIST-OPTION", "PlanListOption");
        public static WinFormsField TaxApply = new WinFormsField("TAX-APPLY", "TaxApply");
        public static WinFormsField PlnaltProgram = new WinFormsField("PLNALT-PROGRAM", "PlnaltProgram");
        public static WinFormsField SpecialStatementCpl = new WinFormsField("SPECIAL-STATEMENT-CPL", "SpecialStatementCpl");
        public static WinFormsField StatementCplName = new WinFormsField("STATEMENT-CPL-NAME", "StatementCplName");
        public static WinFormsField StatementFormat = new WinFormsField("STATEMENT-FORMAT", "StatementFormat");
        public static WinFormsField ScripCombinedStat = new WinFormsField("SCRIP-COMBINED-STAT", "ScripCombinedStat");
        public static WinFormsField CombinedExtraPrint = new WinFormsField("COMBINED-EXTRA-PRINT", "CombinedExtraPrint");
        public static WinFormsField StatementScripSeq = new WinFormsField("STATEMENT-SCRIP-SEQ", "StatementScripSeq");
        public static WinFormsField ScripRequired = new WinFormsField("SCRIP-REQUIRED", "ScripRequired");
        public static WinFormsField UpperCommentPrint = new WinFormsField("UPPER-COMMENT-PRINT", "UpperCommentPrint");
        public static WinFormsField LowerCommentPrint = new WinFormsField("LOWER-COMMENT-PRINT", "LowerCommentPrint");
    }
}
