using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1050", "FormName");
		//Fields


        public static WinFormsField PlanListOption = new WinFormsField("PLAN-LIST-OPTION", "PlanListOption");
        public static WinFormsField TaxApply = new WinFormsField("TAX-APPLY", "TaxApply");
        public static WinFormsField PlanScalebackApply = new WinFormsField("PLAN-SCALEBACK-APPLY", "PlanScalebackApply");
        public static WinFormsField PlanScaledownCode = new WinFormsField("PLAN-SCALEDOWN-CODE", "PlanScaledownCode");
        public static WinFormsField StatementFormat = new WinFormsField("STATEMENT-FORMAT", "StatementFormat");
        public static WinFormsField StatementScripSeq = new WinFormsField("STATEMENT-SCRIP-SEQ", "StatementScripSeq");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
