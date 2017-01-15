using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01027

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01027", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField LowerCommentLine = new WinFormsField("LOWER-COMMENT-LINE", "LowerCommentLine");
        public static WinFormsField UpperCommentLine = new WinFormsField("UPPER-COMMENT-LINE", "UpperCommentLine");
        public static WinFormsField AdviceCommentLine = new WinFormsField("ADVICE-COMMENT-LINE", "AdviceCommentLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
