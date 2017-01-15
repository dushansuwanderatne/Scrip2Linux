using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01027

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01027", "FormName");
		//Fields


        public static WinFormsField UpperCommentLine = new WinFormsField("UPPER-COMMENT-LINE", "UpperCommentLine");
        public static WinFormsField LowerCommentLine = new WinFormsField("LOWER-COMMENT-LINE", "LowerCommentLine");
        public static WinFormsField AdvCommentLine = new WinFormsField("ADV-COMMENT-LINE", "AdvCommentLine");
        public static WinFormsField MCApply = new WinFormsField("MC-APPLY", "MCApply");
        public static WinFormsField MCAllConvRate = new WinFormsField("MC-ALL-CONV-RATE", "MCAllConvRate");
        public static WinFormsField MCAllDesc = new WinFormsField("MC-ALL-DESC", "MCAllDesc");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField NbrMultCurrency = new WinFormsField("NBR-MULT-CURRENCY", "NbrMultCurrency");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
