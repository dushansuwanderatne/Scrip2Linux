using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELRUN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELRUN01", "FormName");
		//Fields


        public static WinFormsField RunDate = new WinFormsField("RUN-DATE", "RunDate");
        public static WinFormsField Highlight = new WinFormsField("HIGHLIGHT", "Highlight");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField RunType = new WinFormsField("RUN-TYPE", "RunType");
        public static WinFormsField FileMmyy = new WinFormsField("FILE-MMYY", "FileMmyy");
        public static WinFormsField MoreComment = new WinFormsField("MORE-COMMENT", "MoreComment");
        public static WinFormsField InputAction = new WinFormsField("INPUT-ACTION", "InputAction");
        public static WinFormsField InputRun = new WinFormsField("INPUT-RUN", "InputRun");
    }
}
