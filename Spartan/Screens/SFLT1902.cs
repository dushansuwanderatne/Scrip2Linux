using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT1902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT1902", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField IssueFloatDesc = new WinFormsField("ISSUE-FLOAT-DESC", "IssueFloatDesc");
        public static WinFormsField OutputName = new WinFormsField("OUTPUT-NAME", "OutputName");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
