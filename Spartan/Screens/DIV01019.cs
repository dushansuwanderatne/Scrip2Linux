using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01019

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01019", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AdvCommentLine = new WinFormsField("ADV-COMMENT-LINE", "AdvCommentLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
